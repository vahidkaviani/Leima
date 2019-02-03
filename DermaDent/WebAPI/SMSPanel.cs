using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DermaDent.WebAPI
{
    class SMSPanel
    {
        string sendreq(string uri,string content)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/69.0.3497.100 Safari/537.36";
            request.Referer = "37.130.202.188";
            request.Method = "POST";
            request.ContentType = "application/json;charset=utf-8";
            
             try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch
            {
                return null;
            }
        }
        private static readonly HttpClient client = new HttpClient();
        public static string srespond;
        public async void endReq(string data)
        {
            var t = new System.Net.Http.StringContent("data");
            var response = await client.PostAsync("http://37.130.202.188/api/select", t);
            srespond = await response.Content.ReadAsStringAsync();
        }
    }
}
