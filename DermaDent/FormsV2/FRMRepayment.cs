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
    public partial class FRMRepayment : Form
    {
        public string _PatientID { get; set; }
        public FRMRepayment(string PatientID=null)
        {
            InitializeComponent();
            label5.Text = PersianDateTime.GetPersianDate(DateTime.Now);
            persianDateTimeBox1.Text= PersianDateTime.GetPersianDate(DateTime.Now);
            if (!string.IsNullOrEmpty(PatientID))
            {
                _PatientID = PatientID;
                UpdateUserDetail();
            }

        }
        void UpdateUserDetail()
        {
            LBLFileID.Text = _PatientID;
            var v = Transaction.GetPatientList(FileID:_PatientID);
            if (v.Rows.Count < 1)
                return;
            LBLFirstName.Text = (string)v.Rows[0]["FNameSick"];
            LBLLastName.Text = (string)v.Rows[0]["LNameSick"];
        }
        private void TXTBXPrePay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    if (TXTBXPrePay.Text.EndsWith("%"))
                    {
                        int val = int.Parse(TXTBXPrePay.Text.Replace("%", ""));
                        double Total = double.Parse(TXTBXTotalPrice.Text);
                        TXTBXPrePay.Text = (Total * val / 100).ToString("N0");
                        LBLPrePayPercent.Text = string.Format("{0}%", val);
                    }
                    else
                    {
                        int val = int.Parse(TXTBXPrePay.Text);
                        double Total = double.Parse(TXTBXTotalPrice.Text);
                        LBLPrePayPercent.Text = string.Format("{0}%", (val * 100) / Total);
                    }
                }
                catch
                {
                }
            }
        }

        private void TXTBXNextPayCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r')
                return;
            int PayCount = int.Parse(TXTBXNextPayCount.Text);
            int TotalPrice = int.Parse(TXTBXTotalPrice.Text);
            int prePay = int.Parse(TXTBXPrePay.Text.Replace(",",""));
            int Remain = TotalPrice - prePay;
            TXTBXNextPayValue.Text = (Remain / PayCount).ToString();
        }

        private void TXTBXNextPayValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\r')
                return;
            int PayCount = 0;
            int TotalPrice = int.Parse(TXTBXTotalPrice.Text);
            int prePay = int.Parse(TXTBXPrePay.Text.Replace(",", ""));
            int Remain = TotalPrice - prePay;
            int nextPayValue = int.Parse(TXTBXNextPayValue.Text);
            PayCount = (Remain / nextPayValue);
            TXTBXNextPayCount.Text = PayCount.ToString();
            int Concatenation = (Remain - PayCount * nextPayValue);
            LBLFinPay.Text = string .Format("قسط پایانی : {0}",Concatenation);
            
        }

        void UpdateTable ()
        {


            DTGPaymentProgram.Rows.Clear();
            int NextPayCount = int.Parse(TXTBXNextPayCount.Text);
            int NextPayValue = int.Parse(TXTBXNextPayValue.Text);
            int TotalPrice = int.Parse(TXTBXTotalPrice.Text);
            int prePay = int.Parse(TXTBXPrePay.Text.Replace(",", ""));
            int Remain = TotalPrice - prePay;

            DTGPaymentProgram.Rows.Add(NextPayCount);
            

            string[] dates= persianDateTimeBox1.Text.Split('/');
            int StartYear = int.Parse(dates[0]);
            int StartMonth = int.Parse(dates[1]);
            int StartDay = int.Parse(dates[2]);
            for (int i = 0; i < NextPayCount; i++)
            {
                if (StartMonth == 12)
                {
                    StartMonth = 1;
                    StartYear++;
                }
                else
                    StartMonth++;
                DTGPaymentProgram.Rows[i].Cells["No"].Value = (i + 1).ToString();
                DTGPaymentProgram.Rows[i].Cells["PaiableValue"].Value = NextPayValue;
                DTGPaymentProgram.Rows[i].Cells["WeekDayMonth"].Value = PersianDateTime.WeekDayNames[PersianDateTime.GetDaOfWeek(StartYear, StartMonth, StartDay)] + "/" + PersianDateTime.Months[StartMonth];
                DTGPaymentProgram.Rows[i].Cells["PaymentTime"].Value = string.Format("{0}/{1:00}/{2:00}", StartYear, StartMonth, StartDay);
            }

            int finRepay = Remain - NextPayCount * NextPayValue;
            if (finRepay > 0)
            {
                if (StartMonth == 12)
                {
                    StartMonth = 1;
                    StartYear++;
                }
                else
                    StartMonth++;
                DTGPaymentProgram.Rows.Add();
                DTGPaymentProgram.Rows[NextPayCount].Cells["No"].Value = (NextPayCount+1).ToString();
                DTGPaymentProgram.Rows[NextPayCount].Cells["PaiableValue"].Value = finRepay;
                DTGPaymentProgram.Rows[NextPayCount].Cells["WeekDayMonth"].Value = PersianDateTime.WeekDayNames[PersianDateTime.GetDaOfWeek(StartYear, StartMonth, StartDay)] + "/" + PersianDateTime.Months[StartMonth];
                DTGPaymentProgram.Rows[NextPayCount].Cells["PaymentTime"].Value = string.Format("{0}/{1:00}/{2:00}", StartYear, StartMonth, StartDay);
            }
        }
        
        private void TXTBXCalculate_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void BTNCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconnedButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                MessageBox.Show("با موفقیت ثبت شد");
                this.Close();
            }

        }
    }
}
