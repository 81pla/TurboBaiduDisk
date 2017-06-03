using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.Model
{
    public class ShareResult
    {
        public int errno { get; set; }
        public long request_id { get; set; }
        public long shareid { get; set; }
        public string link { get; set; }
        public string shorturl { get; set; }
        public bool premis { get; set; }
    }

}
