using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TurboEngine.Core
{
    class StateMonitor
    {
        public event Action StateRefresh;
        public long DownloadSize { get { return downloadSize; } }
        public double Rate { get { return (double)downloadSize / fileLength; } }
        public double Speed {
            get
            {
                if (speedList.Count == 0)
                    return 0;
                long sum = 0;
                foreach (long speed in speedList.ToArray())
                    sum += speed;
                return (double)sum / speedList.Count;
            }
        }

        private long downloadSize = 0;
        private long fileLength;
        private Timer speedTimer;
        private long lastDownloadSize = 0;

        private List<long> speedList;
        public StateMonitor(long fileLength)
        {
            this.fileLength = fileLength;
            speedList = new List<long>();
            StartSpeedTimer();
        }
        public void StartSpeedTimer()
        {
            speedTimer = new Timer(SpeedTimer, null, 0, 1000);
        }
        public void StopSpeedTimer()
        {
            speedTimer.Dispose();
        }
        private void SpeedTimer(object state)
        {
            speedList.Add(downloadSize - lastDownloadSize);
            if (speedList.Count > 5)
                speedList.RemoveAt(0);
            lastDownloadSize = downloadSize;
            
        }
        public void AddBytes(long count)
        {
            Interlocked.Add(ref downloadSize, count);
            StateRefresh?.Invoke();
        }
        public void ResumeBytes(long count)
        {
            downloadSize = count;
            lastDownloadSize = count;
        }
    }
}
