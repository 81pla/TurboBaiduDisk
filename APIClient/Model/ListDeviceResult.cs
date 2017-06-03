using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIClient.Model
{
    public class ListDeviceResult
    {
        public Device[] device_list { get; set; }
        public long request_id { get; set; }
    }
    
    public class Device
    {
        public string device_id { get; set; }
        public string device_type { get; set; }
        public string status { get; set; }
        public string ctime { get; set; }
        public string mtime { get; set; }
        public string is_auth { get; set; }
        public string device_desc { get; set; }
        public string device_version { get; set; }
        public int?[] device_capacity { get; set; }
        public string device_category { get; set; }
        public int has_access_token { get; set; }
        public int task_count { get; set; }
        public ConnectInfo connect_info { get; set; }
        public int is_online { get; set; }
    }

    public class ConnectInfo
    {
        public int time { get; set; }
        public int lo { get; set; }
        public string oip { get; set; }
        public string iip { get; set; }
        public int nat { get; set; }
        public int ba { get; set; }
        public int net { get; set; }
        public string ssid { get; set; }
        public int si { get; set; }
        public string channel_id { get; set; }
        public int udp_port { get; set; }
    }

}
