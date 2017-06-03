using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Model
{
    public class CreateDirectoryResult
    {
        public long fs_id { get; set; }
        public string path { get; set; }
        public int ctime { get; set; }
        public int mtime { get; set; }
        public int status { get; set; }
        public int isdir { get; set; }
        public int errno { get; set; }
        public string name { get; set; }
    }

}
