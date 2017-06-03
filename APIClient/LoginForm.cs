using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace APIClient
{
    public partial class LoginForm : Form
    {
        public ClientCredential LoginResult { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            CookieReader.SupressCookiePersist();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.ToString().Contains("pan.baidu.com/disk/home"))
            {
                string cookies = CookieReader.GetCookie(webBrowser1.Url.ToString());
                Dictionary<string, string> dict = CookiesToDict(cookies);
                string uk = Regex.Match(webBrowser1.DocumentText, "uk\":([0-9]*)").Groups[1].Value;
                if (uk != "")
                {
                    LoginResult = new ClientCredential();
                    LoginResult.UK = uk;
                    LoginResult.STOKEN = dict["STOKEN"];
                    LoginResult.BDUSS = dict["BDUSS"];
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private Dictionary<string, string> CookiesToDict(string cookies)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string[] cookies_split = cookies.Split(';');
            foreach (string cookie in cookies_split)
            {
                string[] cookie_split = cookie.Split('=');
                if (cookie_split.Length != 2)
                    continue;
                dict.Add(cookie_split[0].Trim(), cookie_split[1].Trim());
            }
            return dict;
        }

        /// <summary>
        /// WinInet.dll wrapper
        /// </summary>
        internal static class CookieReader
        {
            /// <summary>
            /// Enables the retrieval of cookies that are marked as "HTTPOnly". 
            /// Do not use this flag if you expose a scriptable interface, 
            /// because this has security implications. It is imperative that 
            /// you use this flag only if you can guarantee that you will never 
            /// expose the cookie to third-party code by way of an 
            /// extensibility mechanism you provide. 
            /// Version:  Requires Internet Explorer 8.0 or later.
            /// </summary>
            private const int INTERNET_COOKIE_HTTPONLY = 0x00002000;

            [DllImport("wininet.dll", SetLastError = true)]
            private static extern bool InternetGetCookieEx(
                string url,
                string cookieName,
                StringBuilder cookieData,
                ref int size,
                int flags,
                IntPtr pReserved);
            [DllImport("wininet.dll", SetLastError = true)]
            private static extern bool InternetSetOption(
                int hInternet,
                int dwOption,
                IntPtr lpBuffer,
                int dwBufferLength
            );

            /// <summary>
            /// Returns cookie contents as a string
            /// </summary>
            /// <param name="url"></param>
            /// <returns></returns>
            public static string GetCookie(string url)
            {
                int size = 512;
                StringBuilder sb = new StringBuilder(size);
                if (!InternetGetCookieEx(url, null, sb, ref size, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero))
                {
                    if (size < 0)
                    {
                        return null;
                    }
                    sb = new StringBuilder(size);
                    if (!InternetGetCookieEx(url, null, sb, ref size, INTERNET_COOKIE_HTTPONLY, IntPtr.Zero))
                    {
                        return null;
                    }
                }
                return sb.ToString();
            }
            public static bool SupressCookiePersist()
            {
                // 3 = INTERNET_SUPPRESS_COOKIE_PERSIST 
                // 81 = INTERNET_OPTION_SUPPRESS_BEHAVIOR
                return SetOption(81, 3);
            }

            public static bool EndBrowserSession()
            {
                // 42 = INTERNET_OPTION_END_BROWSER_SESSION 
                return SetOption(42, null);
            }

            static bool SetOption(int settingCode, int? option)
            {
                IntPtr optionPtr = IntPtr.Zero;
                int size = 0;
                if (option.HasValue)
                {
                    size = sizeof(int);
                    optionPtr = Marshal.AllocCoTaskMem(size);
                    Marshal.WriteInt32(optionPtr, option.Value);
                }

                bool success = InternetSetOption(0, settingCode, optionPtr, size);

                if (optionPtr != IntPtr.Zero) Marshal.Release(optionPtr);
                return success;
            }

            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CookieReader.EndBrowserSession();
        }
    }
}
