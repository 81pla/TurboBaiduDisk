using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Model
{
    public class CreateFileResult
    {
        public long fs_id { get; set; }
        public string md5 { get; set; }
        public string server_filename { get; set; }
        public int category { get; set; }
        public string path { get; set; }
        public int size { get; set; }
        public int ctime { get; set; }
        public int mtime { get; set; }
        public int isdir { get; set; }
        public int errno { get; set; }
        public string name { get; set; }
    }

}
