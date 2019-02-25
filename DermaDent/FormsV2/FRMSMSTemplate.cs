using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent.FormsV2
{
    public partial class FRMSMSTemplate : Form
    {
        public FRMSMSTemplate()
        {
            InitializeComponent();
            TXBXTemplate.Text = DermaDent.Properties.Settings.Default.SMSTemplate;
            TXBXPassword.Text = "**********";
            TXBXOutPutNo.Text = DermaDent.Properties.Settings.Default.OutPutSMSNumbre;
            TXBXUserName.Text = DermaDent.Properties.Settings.Default.SMSPanelUserName;
        }

        private void BTNSaveChanges_Click(object sender, EventArgs e)
        {
            DermaDent.Properties.Settings.Default.SMSTemplate = TXBXTemplate.Text;
            DermaDent.Properties.Settings.Default.OutPutSMSNumbre=TXBXOutPutNo.Text;
            DermaDent.Properties.Settings.Default.SMSPanelUserName = TXBXUserName.Text;
            if (TXBXPassword.Text != "**********")
                DermaDent.Properties.Settings.Default.SMSPanellPass = TXBXPassword.Text;
            DermaDent.Properties.Settings.Default.Save();
            this.Close();
        }

        private void ReviewTemplate(object sender, EventArgs e)
        {
            string s = TXBXTemplate.Text;
            //[time]
            //[date]
            //[wn]
            //[mn]
            //YYYY
            //MM
            //DD
            //HH
            //mm
            string tme = DateTime.Now.ToString("HH:mm");
            string dte = PersianDateTime.GetPersianDate(DateTime.Now);
            string weekdayname = PersianDateTime.GetDayOfWeekName(DateTime.Now);
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            int year = pc.GetYear(DateTime.Now);
            int month= pc.GetMonth(DateTime.Now);
            int day = pc.GetDayOfMonth(DateTime.Now);
            string monthname = PersianDateTime.Months[month];
            s=s.Replace("[time]", tme);
            s=s.Replace("[date]", dte);
            s=s.Replace("[wn]", weekdayname);
            s=s.Replace("[mn]", monthname);
            s=s.Replace("[YYYY]", year.ToString());
            s=s.Replace("[MM]", month.ToString());
            s=s.Replace("[DD]", day.ToString());
            s=s.Replace("[date]", dte);
            s=s.Replace("[date]", dte);
            s=s.Replace("[HH]", DateTime.Now.Hour.ToString("00"));
            s=s.Replace("[mm]", DateTime.Now.Minute.ToString("00"));
            LBLSampleText.Text = s;
        }
    }
}
