using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIClient.Model
{
    public class UserInfoResult
    {
        public int errno { get; set; }
        public long request_id { get; set; }
        public Record[] records { get; set; }
    }
    public class Record
    {
        public long uk { get; set; }
        public string uname { get; set; }
        public string nick_name { get; set; }
        public string intro { get; set; }
        public string avatar_url { get; set; }
        public int follow_flag { get; set; }
        public int black_flag { get; set; }
        public string follow_source { get; set; }
        public string display_name { get; set; }
        public string remark { get; set; }
        public string priority_name { get; set; }
    }
}
