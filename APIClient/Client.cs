using APIClient.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace APIClient
{
    public class Client
    {
        #region Fields
        public static ClientCredential Authentication { get; set; }
        #endregion

        #region Methods
        const string MainServer = "http://pan.baidu.com";
        const string PCSServer = "http://d.pcs.baidu.com";
        const string DiskAPIServer = "http://diskapi.baidu.com";
        const string PassportServer = "https://passport.baidu.com";
        const string PCSDataServer = "http://pcsdata.baidu.com";
        
        private HttpWebRequest GetRequest(string uri)
        {
            GC.Collect();
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.UserAgent = "netdisk;5.5.4.1;PC;PC-Windows;10.0.14393;WindowsBaiduYunGuanJia";
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("STOKEN", Authentication.STOKEN, "/", "baidu.com"));
            request.CookieContainer.Add(new Cookie("BDUSS", Authentication.BDUSS, "/", "baidu.com"));
            request.SendChunked = false;
            return request;
        }

        /// <summary>
        /// 非API接口。弹出网页抓取Cookies保存在当前实例中。
        /// </summary>
        /// <returns></returns>
        public bool Login()
        {
            LoginForm loginfrm = new LoginForm();
            if (loginfrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Authentication = loginfrm.LoginResult;
                if (CheckIsLogined())
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        
        public bool CheckIsLogined()
        {
            return GetQuota().errno == 0;
        }

        public QuotaResult GetQuota()
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/quota?checkexpire=1&checkfree=1");
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<QuotaResult>(json);
            }
            catch (Exception)
            {
                return new QuotaResult();
            }
        }

        public UserInfoResult GetUserInfo()
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/user/getinfo");
                request.Method = "POST";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"user_list=[{Authentication.UK}]");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<UserInfoResult>(json);
            }
            catch (Exception)
            {
                return new UserInfoResult();
            }
        }
        public ListFileResult GetFileList(string path)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/list?dir={Uri.EscapeDataString(path)}&page=1&num=100000");
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<ListFileResult>(json);
            }
            catch (Exception)
            {
                return new ListFileResult();
            }
        }
        public DownloadResult GetDownload(string path)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{PCSServer}/rest/2.0/pcs/file?app_id=250528&method=locatedownload&ver=4.0&path={Uri.EscapeDataString(path)}");
                request.Method = "POST";
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<DownloadResult>(json);
            }
            catch (Exception)
            {
                return new DownloadResult();
            }
        }
        public TimestampResult GetTimestamp()
        {
            try
            {
                HttpWebRequest request = GetRequest($"{DiskAPIServer}/rest/2.0/netdisk/timestamp?method=get");
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<TimestampResult>(json);
            }
            catch (Exception)
            {
                return new TimestampResult();
            }
        }
        public ListFileResult Search(string keyword, string path = "/")
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/search?recursion=1&dir={Uri.EscapeDataString(path)}&key={Uri.EscapeDataString(keyword)}&page=1&num=1000");
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<ListFileResult>(json);
            }
            catch (Exception)
            {
                return new ListFileResult();
            }
        }

        public bool GetIfConnected()
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/res/static/thirdparty/connect.jpg");
                request.GetResponse().GetResponseStream().Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Logout()
        {
            try
            {
                HttpWebRequest request = GetRequest($"{PassportServer}/?logout");
                request.GetResponse().GetResponseStream().Close();
                Authentication = new ClientCredential();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public FileOperationResult DeleteFiles(string[] files)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/filemanager?opera=delete");
                request.Method = "POST";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"filelist={JsonConvert.SerializeObject(files)}");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<FileOperationResult>(json);
            }
            catch (Exception)
            {
                return new FileOperationResult();
            }
        }
        public FileOperationResult CopyFiles(CopyMoveRequest[] requests)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/filemanager?opera=copy");
                request.Method = "POST";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"filelist={JsonConvert.SerializeObject(requests)}");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<FileOperationResult>(json);
            }
            catch (Exception)
            {
                return new FileOperationResult();
            }
        }
        public FileOperationResult MoveFiles(CopyMoveRequest[] requests)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/filemanager?opera=move");
                request.Method = "POST";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"filelist={JsonConvert.SerializeObject(requests)}");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<FileOperationResult>(json);
            }
            catch (Exception)
            {
                return new FileOperationResult();
            }
        }
        public FileOperationResult RenameFiles(RenameRequest[] requests)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/filemanager?opera=rename");
                request.Method = "POST";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"filelist={JsonConvert.SerializeObject(requests)}");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<FileOperationResult>(json);
            }
            catch (Exception)
            {
                return new FileOperationResult();
            }
        }
        public Image GetThumbnail(string path, int quality, int width, int height)
        {
            
            try
            {
                HttpWebRequest request = GetRequest($"{PCSDataServer}/rest/2.0/pcs/thumbnail?app_id=250528&method=generate&ec=1&path={Uri.EscapeDataString(path)}&quality={quality}&height={height}&width={width}");
                request.Method = "GET";
                return Image.FromStream(request.GetResponse().GetResponseStream());
            }
            catch (Exception)
            {
                return null;
            }
        }
        public ShareResult Share(string[] pathlist)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/share/pset");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"path_list={JsonConvert.SerializeObject(pathlist)}&channel_list=[]&public=1&shorturl=1&schannel=0");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<ShareResult>(json);
            }
            catch (Exception)
            {
                return new ShareResult();
            }
        }
        public ShareResult SharePrivate(string[] pathlist, string password)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/share/pset");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"path_list={JsonConvert.SerializeObject(pathlist)}&channel_list=[]&public=0&shorturl=1&schannel=4&pwd={Uri.EscapeDataString(password)}");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<ShareResult>(json);
            }
            catch (Exception)
            {
                return new ShareResult();
            }
        }
        public CreateDirectoryResult CreateDirectory(string path)
        {
            try
            {
                HttpWebRequest request = GetRequest($"{MainServer}/api/create?a=commit");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write($"path={Uri.EscapeDataString(path)}&size=0&isdir=1&block_list=[]&method=post");
                writer.Close();
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                string json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<CreateDirectoryResult>(json);
            }
            catch (Exception)
            {
                return new CreateDirectoryResult();
            }
        }
        #endregion

    }
    public class ClientCredential
    {
        public string BDUSS { get; set; }
        public string STOKEN { get; set; }
        public string UK { get; set; }
    }
    public class Errno
    {
        private static Errno _instance = null;
        private Dictionary<int, string> errnoTable = null;
        private Errno()
        {
            errnoTable = JsonConvert.DeserializeObject<Dictionary<int, string>>(Properties.Resources.ErrnoDescriptionJson);
        }
        public static Errno Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Errno();
                return _instance;
            }
        }

        public string GetDescription(int errno)
        {
            string d = "";
            bool success = errnoTable.TryGetValue(errno, out d);
            if (success)
                return d;
            else
                return "未知错误";
        }
    }
}
