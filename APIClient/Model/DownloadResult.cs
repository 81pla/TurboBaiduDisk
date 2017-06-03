using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIClient.Model
{
    public class DownloadResult
    {
        public string client_ip { get; set; }
        public Url[] urls { get; set; }
        public RankParam rank_param { get; set; }
        public int sl { get; set; }
        public int max_timeout { get; set; }
        public int min_timeout { get; set; }
        public long request_id { get; set; }
    }
    
    public class RankParam
    {
        public int max_continuous_failure { get; set; }
        public int bak_rank_slice_num { get; set; }
    }

    public class Url
    {
        public string url { get; set; }
        public int rank { get; set; }
    }

}
