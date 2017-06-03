using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIClient.Model
{
    public class QuotaResult
    {
        public int errno { get; set; }
        public long total { get; set; }
        public long free { get; set; }
        public long request_id { get; set; }
        public bool expire { get; set; }
        public long used { get; set; }
    }
    public enum ErrorNumber
    {
        Success = 0,
        FileAlreadyExists = 12,
    }
}
