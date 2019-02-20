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
        public static async void SendReq(string data)
        {
            var t = new System.Net.Http.StringContent(data);
            var response = await client.PostAsync("http://37.130.202.188/api/select", t);
            srespond = await response.Content.ReadAsStringAsync();
        }
        public static void SendSMS(List<string>recievers,string cntent,DateTime? sendDate=null)
        {
            serverInteracts.PanelPasswordpass = "015987530";
            serverInteracts.PanelUserName = "09025374173";
            string fromGateway = "50002040";
            SmsMessages sm = new SmsMessages(cntent, recievers, fromGateway, sendDate);
            sm.flush();

        }

        class serverInteracts
        {
            protected string command{ get; set; }
            public static string PanelUserName { get; set; }
            public static string PanelPasswordpass { get; set; }
        }
        class SmsMessages : serverInteracts
        {

            public string uname { get { return PanelUserName; } }
            public string pass { get { return PanelPasswordpass; } }
            public string op { get { return command; } }
            public string from { get { return GateWayNo; } }
            public IList<string> to { get { return RecieversNo; }  }
            private string GateWayNo { get; set; }
            private IList<string> RecieversNo;
            public string message { get { return content; } }
            private string content { get; set; }
            private DateTime SentDate;
            public string time { get { if (SentDate < DateTime.Now.AddSeconds(30)) return string.Empty; else return SentDate.ToString("yyyy-MM-dd"); } }
            public SmsMessages(string content, IList<string> RecieversNo=null,string from=null,DateTime ?sendDate=null)
            {
                if (RecieversNo != null)
                    this.RecieversNo = RecieversNo;
                else
                    RecieversNo = new List<string>();
                this.command = "send";
                this.GateWayNo = from;
                this.content = content;
                if (sendDate.HasValue)
                    this.SentDate = sendDate.Value;

            }
            void setGateway(string gateway)
            {
                GateWayNo = gateway;
            }
            void addReciever(string no)
            {
                RecieversNo.Add(no);
            }

            internal void flush()
            {
                string complete = Newtonsoft.Json.JsonConvert.SerializeObject(this);
                SendReq(complete);
            }
        }
    }
}
