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
        public event EventHandler StateChanged;
        public event Action<string> DownloadError;
        #endregion

        #region Public fields
        public List<string> Mirrors { get; set; }
        public long FileLength { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string FullFileName => Path.Combine(FilePath, FileName);
        public EngineState State { get; private set; } = EngineState.Stopped;
        public long DownloadedSize { get { return stateMonitor.DownloadSize; } }
        public double Rate { get { return stateMonitor.Rate > 1 ? 1 : stateMonitor.Rate; } }
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
        
        public int MaxWorkers { get; set; } = 32;
        public int MinWorkers { get; set; } = 16;
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
                new Thread(() =>
                {
                    SetState(EngineState.Stopping);
                    requestedStopping = true;
                    stateMonitor.StopSpeedTimer();
                    cacheManager.Pause();
                    SetState(EngineState.Stopped);
                }).Start();
            }
        }
        public void Stop()
        {
            if (State == EngineState.Running || State == EngineState.Error)
            {
                new Thread(() =>
                {
                    SetState(EngineState.Stopping);
                    requestedStopping = true;
                    stateMonitor.StopSpeedTimer();
                    cacheManager.Cancel();
                    Task.WaitAll(tasks.ToArray());
                    SetState(EngineState.Stopped);
                }).Start();
            }
        }
        public void LoadBasicInfo()
        {
            int reload = 0;
            reload:
            reload++;
            if (reload > 3)
                throw new Exception("下载失败。GET 失败。");
            if (isLoaded)
                return;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Mirrors[0]);
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
                    FileName = Uri.UnescapeDataString(Regex.Match(fileName, "filename=(.*)").Groups[1].Value.Trim('"'));
            }
            catch (Exception)
            {
                goto reload;
            }
        }
        public static void LoadBasicInfo(string url, out string filename, out long filelength)
        {
            int reload = 0;
            reload:
            reload++;
            if (reload > 3)
                throw new Exception("下载失败。GET 失败。");
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
                goto reload;
            }

        }

        #endregion

        #region Private methods
        private void StartDownload()
        {
            try
            {
                ServicePointManager.DefaultConnectionLimit = 1000;

                chunkManager = new ChunkManager(FileLength, Path.Combine(FilePath, FileName) + ".tep");
                cacheManager = new CacheManager(Path.Combine(FilePath, FileName));
                stateMonitor = new StateMonitor(FileLength);

                stateMonitor.ResumeBytes(chunkManager.TepSavedDownloadedSize);  //continue progress
                SetState(EngineState.Running);

                //start workers
                while (tasks.Count < MaxWorkers)
                {
                    foreach (string mirror in Mirrors)
                    {
                        if (tasks.Count < MaxWorkers)
                        {
                            tasks.Add(Task.Factory.StartNew(DownloadWorker, mirror));
                        }
                    }
                }

                Task.WaitAll(tasks.ToArray());  //wait for exit
                if (!requestedStopping)
                    Finish();
            }
            catch (Exception ex)
            {
                DownloadError($"主线程错误：{ex.Message}");
                SetState(EngineState.Error);
            }
        }
        private void DownloadWorker(object mirror)
        {
            try
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
                        request.ReadWriteTimeout = 800;
                        request.Timeout = 2000;
                        request.AddRange("bytes", chunk.Start, chunk.End);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream ws = response.GetResponseStream();

                        //----transfer bytes----
                        MemoryStream ms = new MemoryStream();
                        int read = 0;
                        byte[] buffer = new byte[1024 * 8];
                        while((read = ws.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            ms.Write(buffer, 0, read);
                            stateMonitor.AddBytes(read);
                        }
                        //----transfer bytes----
                        
                        cacheManager.FinishChunk(ms.ToArray(), chunk);
                        ws.Close();
                        response.Close();
                        //request.Abort();
                    }
                    catch (Exception)
                    {
                        if (chunkManager.GiveUpChunk(chunk, mirror as string) && workersRunning > MinWorkers)
                            break;
                        Thread.Sleep(3000);
                    }
                }
                Interlocked.Decrement(ref workersRunning);
            }
            catch (Exception ex)
            {
                DownloadError($"工作线程错误：{ex.Message}");
                SetState(EngineState.Error);
            }
        }

        private void SetState(EngineState state)
        {
            State = state;
            StateChanged?.Invoke(null, null);
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
        Error
    }
}
