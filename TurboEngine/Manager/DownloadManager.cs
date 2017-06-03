using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TurboEngine.Core;

namespace TurboEngine.Manager
{
    class DownloadManager
    {

        #region Singlelon
        private DownloadManager()
        {

        }
        private static DownloadManager _instance = null;
        public static DownloadManager Instance {
            get
            {
                if (_instance == null)
                    _instance = new DownloadManager();
                return _instance;
            }
        }
        #endregion

        #region Events
        public event EventHandler<AddedNewTaskEventArgs> AddedNewTask;
        public event EventHandler<TaskUpdateEventArgs> TaskUpdate;
        #endregion

        #region Private Fields
        private TaskSemaphore taskSemaphore;
        private List<Task> Tasks = new List<Task>();
        #endregion

        #region Public Methods
        public void AddTask(Task task)
        {
            AddedNewTask?.Invoke(this, new AddedNewTaskEventArgs() { NewTask = task });
        }
        public Task GetTask(string destPath)
        {
            foreach (Task task in Tasks)
                if (task.ToPath == destPath)
                    return task;
            return null;
        }
        #endregion

        #region Private Methods
        #endregion
    }

    public class TaskUpdateEventArgs : EventArgs
    {
        public TaskStateInfo Info { get; set; }
    }
    public class TaskStateInfo
    {
        public string FileName { get; set; }
        public TaskState State { get; set; }
        public double Speed { get; set; }
        public double Rate { get; set; }
        public long BytesFinished { get; set; }
        public long FileLength { get; set; }
    }
    public class AddedNewTaskEventArgs : EventArgs
    {
        public Task NewTask { get; set; }
    }
    public enum TaskState
    {
        Running,
        Finished,
        Stopped
    }
    public class DownloadException : Exception
    {
        public DownloadException(string message)
            :base(message)
        {

        }
    }
}
