using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace TurboEngine.Core
{
    public class DownloadEngine
    {
        #region Events
        public event Action ProgressRefresh;
        #endregion

        #region Public fields
        public List<string> Mirrors { get; set; }
        public long FileLength { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public EngineState State { get; private set; } = EngineState.Stopped;
        public long DownloadedSize { get { return stateMonitor.DownloadSize; } }
        public double Rate { get { return stateMonitor.Rate; } }
        public double Speed { get { return stateMonitor.Speed; } }
        public int RunningWorkers { get { return workersRunning; } }
        #endregion

        #region Private fields
        private CacheManager cacheManager;
        private ChunkManager chunkManager;
        private StateMonitor stateMonitor;

        private bool requestedStopping = false;
        private List<Task> tasks = new List<Task>();
        private int workersRunning = 0;
        private bool isLoaded => FileLength != 0 && FileName != null;

        const int WorkersPerMirror = 3;
        const int MaxWorkers = 32;
        const int MinWorkers = 8;
        #endregion

        #region Public methods
        public DownloadEngine()
        {

        }
        public DownloadEngine(List<string> mirrors)
        {
            Mirrors = mirrors;
        }
        public void Start()
        {
            if(State == EngineState.Stopped)
            {
                new Thread(() =>
                {
                    SetState(EngineState.Starting);
                    LoadBasicInfo();
                    StartDownload();
                }).Start();
            }
        }
        public void Pause()
        {
            if (State == EngineState.Running)
            {
                Task.Run(new Action(() =>
                {
                    SetState(EngineState.Stopping);
                    requestedStopping = true;
                    stateMonitor.StopSpeedTimer();
                    cacheManager.Pause();
                    Task.WaitAll(tasks.ToArray());
                    SetState(EngineState.Stopped);
                }));
                
            }
        }
        public void Stop()
        {
            if (State == EngineState.Running)
            {
                Task.Run(new Action(() =>
                {
                    SetState(EngineState.Stopping);
                    requestedStopping = true;
                    stateMonitor.StopSpeedTimer();
                    cacheManager.Cancel();
                    Task.WaitAll(tasks.ToArray());
                    SetState(EngineState.Stopped);
                }));
                
            }
        }
        public void LoadBasicInfo()
        {
            if (isLoaded)
                return;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Mirrors[2]);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                FileLength = response.ContentLength;
                string s = response.Headers["Content-Disposition"];
                byte[] ss = Encoding.GetEncoding("iso-8859-1").GetBytes(s);
                byte[] sss = Encoding.Convert(Encoding.UTF8, Encoding.Default, ss);

                string fileName = Encoding.Default.GetString(sss);
                if (string.IsNullOrEmpty(fileName))
                    FileName = response.ResponseUri.Segments[response.ResponseUri.Segments.Length - 1];
                else
                    FileName = Regex.Match(fileName, "filename=\"(.*)\"").Groups[1].Value;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void LoadBasicInfo(string url, out string filename, out long filelength)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                filelength = response.ContentLength;
                string s = response.Headers["Content-Disposition"];
                byte[] ss = Encoding.GetEncoding("iso-8859-1").GetBytes(s);
                byte[] sss = Encoding.Convert(Encoding.UTF8, Encoding.Default, ss);

                string fileName = Encoding.Default.GetString(sss);
                if (string.IsNullOrEmpty(fileName))
                    filename = response.ResponseUri.Segments[response.ResponseUri.Segments.Length - 1];
                else
                    filename = Regex.Match(fileName, "filename=\"(.*)\"").Groups[1].Value;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Private methods
        private void StartDownload()
        {
            ServicePointManager.DefaultConnectionLimit = 100;
            chunkManager = new ChunkManager(FileLength, Path.Combine(FilePath, FileName) + ".tep");
            cacheManager = new CacheManager(Path.Combine(FilePath, FileName));
            stateMonitor = new StateMonitor(FileLength);

            stateMonitor.StateRefresh += new Action(() =>
            {
                ProgressRefresh?.BeginInvoke(null, null);
            });

            stateMonitor.ResumeBytes(chunkManager.TepSavedDownloadedSize);
            SetState(EngineState.Running);

            for (int i = 1; i <= WorkersPerMirror; i++)
            {
                foreach (string mirror in Mirrors)
                {
                    if (tasks.Count < MaxWorkers)
                    {
                        tasks.Add(Task.Factory.StartNew(DownloadWorker, mirror));
                    }
                }
            }
            Task.WaitAll(tasks.ToArray());
            if (!requestedStopping)
                Finish();
        }
        private void DownloadWorker(object mirror)
        {
            Interlocked.Increment(ref workersRunning);
            while (!requestedStopping)
            {
                Chunk chunk = chunkManager.GetNextChunk();
                if (chunk == null)
                    break;
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(mirror as string);
                    request.SendChunked = false;
                    request.KeepAlive = false;
                    request.ReadWriteTimeout = 5000;
                    request.Timeout = 5000;
                    request.AddRange("bytes", chunk.Start, chunk.End);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream ws = response.GetResponseStream();
                    MemoryStream ms = new MemoryStream();
                    ws.CopyTo(ms);
                    stateMonitor.AddBytes(ms.Length);
                    cacheManager.FinishChunk(ms.ToArray(), chunk);
                    ws.Close();
                    response.Close();
                    //request.Abort();
                }
                catch (Exception)
                {
                    if(chunkManager.GiveUpChunk(chunk, mirror as string) && workersRunning > 2)
                        break;
                }
            }
            Interlocked.Decrement(ref workersRunning);
        }

        private void SetState(EngineState state)
        {
            State = state;
            ProgressRefresh?.Invoke();
        }
        private void Finish()
        {
            stateMonitor.StopSpeedTimer();
            cacheManager.Finish();
            SetState(EngineState.Finished);
        }
        #endregion

    }
    public enum EngineState
    {
        Starting,
        Running,
        Finished,
        Stopping,
        Stopped,
    }
}
