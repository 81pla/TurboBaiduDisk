using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboEngine.Manager
{
    public abstract class Task
    {
        public event EventHandler<TaskUpdateEventArgs> TaskUpdate;
        public TaskState State { get; private set; }
        public string FromPath { get; set; }
        public string ToPath { get; set; }
        public long FileLength { get; set; }
        public abstract void Start();
        public abstract void Stop();
        public abstract void Pause();
    }
}
