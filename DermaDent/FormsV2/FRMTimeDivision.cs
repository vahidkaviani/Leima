using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaDent
{
    public partial class FRMTimeDivision : Form
    {
        public FRMTimeDivision()
        {
            InitializeComponent();
            TXTBXDateFrom.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            TXTBXTimeFrom.Text = DateTime.Now.ToString("HH:mm");

            TXTBXDateTo.Text = PersianDateTime.GetPersianDate(DateTime.Now.AddDays(1));
            TXTBXTimeTo.Text = DateTime.Now.ToString("HH:mm");
        }

        private void BTNAllocateTimes_Click(object sender, EventArgs e)
        {
            try
            {
                int drid;
                try
                {
                    drid = int.Parse(((string)(doctorNameComboBox1.SelectedItem)).Split(',')[0]);
                }
                catch
                {
                    MessageBox.Show("پزشک معالج؟");
                    return;
                }
                //if (string.IsNullOrEmpty(TXTBXFileID.Text))
                //    MessageBox.Show("شماره پرونده ؟");

                List<int> weekWorkingDays = new List<int>();
                if (CHBXFriday.Checked)
                    weekWorkingDays.Add((int)DayOfWeek.Friday);
                if (CHBXSaturday.Checked)
                    weekWorkingDays.Add((int)DayOfWeek.Saturday);
                if (CHBXSunday.Checked)
                    weekWorkingDays.Add((int)DayOfWeek.Sunday);
                if (CHBXMonday.Checked)
                    weekWorkingDays.Add((int)DayOfWeek.Monday);
                if (CHBXTuesday.Checked)
                    weekWorkingDays.Add((int)DayOfWeek.Tuesday);
                if (CHBXWednesday.Checked)
                    weekWorkingDays.Add((int)DayOfWeek.Wednesday);
                if (CHBXThursday.Checked)
                    weekWorkingDays.Add((int)DayOfWeek.Thursday);

                int fromHour = int.Parse(TXTBXTimeFrom.Text.Split(':')[0]);
                int fromMinut = int.Parse(TXTBXTimeFrom.Text.Split(':')[1]);


                int hoursInterval = int.Parse(TXBXTimeIntervals.Text.Split(':')[0]);
                int minutsInterval = int.Parse(TXBXTimeIntervals.Text.Split(':')[1]);
                TimeSpan interval = new TimeSpan(hoursInterval, minutsInterval, 0);


                int toHour = int.Parse(TXTBXTimeTo.Text.Split(':')[0]);
                int toMinut = int.Parse(TXTBXTimeTo.Text.Split(':')[1]);
                TimeSpan startTime = new TimeSpan(fromHour, fromMinut, 0);
                TimeSpan endTime = new TimeSpan(toHour, toMinut, 0);
                string[] fromDatestring = TXTBXDateFrom.Text.Split('/');
                string[] toDatestring = TXTBXDateTo.Text.Split('/');
                int fromYear = int.Parse(fromDatestring[0]);
                int fromMonth = int.Parse(fromDatestring[1]);
                int fromDay = int.Parse(fromDatestring[2]);
                int toYear = int.Parse(toDatestring[0]);
                int toMonth = int.Parse(toDatestring[1]);
                int toDay = int.Parse(toDatestring[2]);
                DateTime fromDate = new System.Globalization.PersianCalendar().ToDateTime(fromYear, fromMonth, fromDay, fromHour, fromMinut, 0, 0);
                DateTime toDate = new System.Globalization.PersianCalendar().ToDateTime(toYear, toMonth, toDay, toHour, toMinut, 0, 0);

                int totaldays = 0;
                int totalTimes = 0;
                for (; fromDate < toDate; fromDate = fromDate.AddDays(1), totaldays++)
                    if (weekWorkingDays.Contains((int)fromDate.DayOfWeek))
                        for (TimeSpan iter = startTime; iter < endTime; iter = iter.Add(interval), totalTimes++)
                            Transaction.RegisterVisitTime(drid, "", PersianDateTime.GetPersianDate(fromDate), iter, false, 1, 0, "0", "1,,,", null);
                //DateTime dt = new System.Globalization.PersianCalendar().ToDateTime(farsiCalendar1._PresentingYear, farsiCalendar1._PresentingMonth, farsiCalendar1._SelectedDay, hour, minut, 1, 1);
                //Transaction.RegisterVisitTime(drid, CMBBXServiceName.SelectedItem.ToString(), persianDateTimeBox1.Text, TimeSpan.Parse(maskedTextBox1.Text), true, 1, CMBBXServiceName.SelectedIndex, TXTBXFileID.Text, "1,,,", null);
                //updateTimeLists();
                string message = string.Format("{0} {1} {2} {3}", totaldays, " روز کاری", totalTimes, "نوبت در روز ایجاد شد");
                MessageBox.Show(message);
                this.Close();
            }
            catch (Exception ex){ MessageBox.Show("خطا"); }
        }

        private void iconnedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
