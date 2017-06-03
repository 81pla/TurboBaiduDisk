using APIClient;
using APIClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboEngine.Core;

namespace TurboEngine.Manager
{
    public class DownloadTask : Task
    {
        public List<string> Mirrors { get; set; }
        private DownloadEngine engine;
        public DownloadTask()
        {

        }
        public TaskStateInfo Info {
            get
            {
                return new TaskStateInfo()
                {
                    State = State,
                    BytesFinished = engine.DownloadedSize,
                    FileLength = FileLength,
                    FileName = ToPath,
                    Rate = engine.Rate,
                    Speed = engine.Speed
                };
            }
        }
        public override void Start()
        {
            if (State != TaskState.Stopped)
                return;
            if (Mirrors == null)
                GetMirrors();
            engine = new DownloadEngine(Mirrors);
            engine.FilePath = ToPath.Remove(ToPath.LastIndexOf('\\'));
            engine.Start();
        }
        private void GetMirrors()
        {
            Client client = new Client();
            DownloadResult dresult = client.GetDownload(FromPath);
            if (dresult.urls == null)
                throw new DownloadException("获取下载链接失败");

            if (dresult.urls[0].url.Contains("wenxintishi"))
                throw new DownloadException("资源已被封禁");

            foreach (Url url in dresult.urls)
                Mirrors.Add(url.url);
        }

        public override void Stop()
        {
            if (State != TaskState.Running)
                return;
        }

        public override void Pause()
        {
            if (State != TaskState.Running)
                return;
        }

    }
}
