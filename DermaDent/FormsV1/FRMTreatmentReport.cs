using DSoftShopcheeBot;
using number2Text;
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
    public partial class FRMTreatmentReport : Form
    {
        int PID = 0;
        int DrID = -1;
        int _VisitTimeId = -1;
        public FRMTreatmentReport(int pid,int? VisitTimeId=-1)
        {
            if (VisitTimeId.HasValue)
                _VisitTimeId = VisitTimeId.Value;
            InitializeComponent();
            InitServiceList();
            InitDoctorList();
            PID = pid;
            InitForm(pid);
            UpdatePatientList();
            LSTVUTemp.MouseClick += TempLSTVU_MouseClick;
           
        }

        int SelectedItemListview = -1;
        private void TempLSTVU_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SelectedItemListview = LSTVUTemp.HitTest(e.X, e.Y).Item.Index;

                if (SelectedItemListview >= 0)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add("حذف", RemoveService);
                    m.Show(LSTVUTemp, new Point(e.X, e.Y));
                }
            }
        }

        private void RemoveService(object sender, EventArgs e)
        {
            if (SelectedItemListview >= 0)
            {
                LSTVUTemp.Items.RemoveAt(SelectedItemListview);
                UpdateSumofServicePrice();
            }
        }
        public void InitServiceList()
        {

            LSTVUServiceList.Items.Clear();
            var result = new DatabaseManager().GetData(@"SELECT TOP 1000 [IDService]
                                                      ,[NameService]
                                                      FROM  [infoService]
                                                      WHERE IDService>99");

            for (int i = 0; i < result.Rows.Count; i++)
            {
             ListViewItem lvi=new ListViewItem(result.Rows[i][0] + "," + result.Rows[i][1]);
                LSTVUServiceList.Items.Add(lvi);
            }

        }

        public void InitDoctorList()
        {
          
            if (_VisitTimeId > 0)
            {
                var res = Transaction.GetVisitTimeDetail(_VisitTimeId);
                
                
                if (res.Rows.Count > 0)
                {
                    int drid = (int)res.Rows[0]["DoctorID"];
                    doctorNameComboBox.SelectedIndex =drid-1;
                    var dd = Transaction.GetDoctorDetails(drid);
                    int proindex = (int)(decimal)dd.Rows[0]["id_typeSpecial"];
                    profeciencyCombobox1.SelectedIndex = proindex- 1;
                }
            }
            else if(doctorNameComboBox.Items.Count>0)
                doctorNameComboBox.SelectedIndex = 0;
            

        }
        public void InitForm(int patientID)
        {
            var result = new DatabaseManager().GetData(@"SELECT  [IDsick]
                                    ,[FNamesick]
                                    ,[LNamesick]
                                    ,[meliCode]
                                    ,[Birthday]
                                    ,[Tel]
                                    FROM [InfoSick] WHERE IDsick='" + patientID.ToString() + "'" +
                                    "ORDER BY date_create DESC");

            if (result.Rows.Count > 0)
            {
                LBLName.Text =(string) result.Rows[0]["FNamesick"];
                LBLFamily.Text= (string)result.Rows[0]["LNamesick"];
            }
            LBLFileId.Text = patientID.ToString();
            var pc = new System.Globalization.PersianCalendar();
            LBLDateTime.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString() + "/" + pc.GetDayOfMonth(DateTime.Now).ToString();
        }
        private void LSTVUServiceList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<string> servicedArea = teethQuadrant1.GetServiceArea();
            if (servicedArea.Count==0)
            {
                LBLRepeatedService.Text="Please define service Area First";
                return;
            }
            foreach (string ServicedObject in servicedArea)
            for (int i = 0; i < LSTVUServiceList.SelectedItems.Count; i++)
            {
                ListViewItem found = LSTVUTemp.FindItemWithText(LSTVUServiceList.SelectedItems[i].Text);
                int search = 0;
                while (found!=null&&search<LSTVUTemp.Items.Count)
                {
                    search++;
                        if (found.SubItems[1].Text == ServicedObject)
                        {
                            LBLRepeatedService.Text = "ثبت خدمت تکراری";
                            continue;
                        }
                    if (found.Index < LSTVUTemp.Items.Count-1)
                        found = LSTVUTemp.FindItemWithText(LSTVUServiceList.SelectedItems[i].Text, false, found.Index + 1);
                }
                LBLRepeatedService.Text = "";
                int servicecode = int.Parse(LSTVUServiceList.SelectedItems[i].Text.Split(',')[0]);
                //LSTVUTemp.Items.Add(LSTVUServiceList.SelectedItems[i].Text, LSTVUServiceList.SelectedItems[i].Text,0);
                //ListViewItem lvi = new ListViewItem(new string[] {, teethQuadrant1.GetServiceArea(), "CL3" }, LSTVUServiceList.SelectedItems[i].Text);
                AddService(LSTVUServiceList.SelectedItems[i].Text, servicecode, profeciencyCombobox1.GetProfeciencyType(),ServicedObject);
            }
            if (LSTVUTemp.Items.Count > 0)
                LSTVUPatient.Enabled = false;
            UpdateSumofServicePrice();
            teethQuadrant1.Clear();
        }

        int _Price = 0;

        public void UpdateSumofServicePrice()
        {
            List<TreatmentServiceItem> billInvoice = new List<TreatmentServiceItem>();
            for (int i = 0; i < LSTVUTemp.Items.Count; i++)
            {
                string[] srvc = LSTVUTemp.Items[i].SubItems[0].Text.Split(',');
                TreatmentServiceItem t = new TreatmentServiceItem();
                t.servicename = srvc[1];
                t.PatientID = LBLFileId.Text;
                t.DoctorID = LSTVUTemp.Items[i].SubItems[4].Text;
                t.Tooth = LSTVUTemp.Items[i].SubItems[1].Text;
                t.ServicePrice = int.Parse(LSTVUTemp.Items[i].SubItems[2].Text);
                t.profeciencytype = int.Parse(LSTVUTemp.Items[i].SubItems[5].Text);
                t.ServiceCode = int.Parse(srvc[0]);
                t.DrSharePercent = Transaction.GetDrshare(int.Parse(t.DoctorID));
                billInvoice.Add(t);
            }

            int TotalPrice = 0;
            foreach (var item in billInvoice)
            {
                if (item.ServicePrice > 0)
                    TotalPrice += item.ServicePrice;
            }

            _Price = TotalPrice;
            string tp = TotalPrice.ToString("N");
            TXTBXSumOfService.Text =tp.Substring(0,tp.Length-3);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<TreatmentServiceItem> billInvoice = new List<TreatmentServiceItem>();
            for (int i = 0; i < LSTVUTemp.Items.Count; i++)
            {
                string[] srvc = LSTVUTemp.Items[i].SubItems[0].Text.Split(',');
                TreatmentServiceItem t = new TreatmentServiceItem();
                t.servicename = srvc[1];
                t.PatientID = LBLFileId.Text;
                t.DoctorID = LSTVUTemp.Items[i].SubItems[4].Text;
                t.Tooth = LSTVUTemp.Items[i].SubItems[1].Text;
                t.ServicePrice = int.Parse(LSTVUTemp.Items[i].SubItems[2].Text);
                t.profeciencytype = int.Parse(LSTVUTemp.Items[i].SubItems[5].Text);
                t.ServiceCode = int.Parse(srvc[0]);
                t.DrSharePercent = Transaction.GetDrshare(int.Parse(t.DoctorID));
                t.DrshareFinal = (float)((t.DrSharePercent* t.ServicePrice)/100.0);
                billInvoice.Add(t);
            }

            int TotalPrice = 0;
            foreach (var item in billInvoice)
            {
                if (item.ServicePrice > 0)
                    TotalPrice += item.ServicePrice;
            }

            _Price = TotalPrice;
            TXTBXSumOfService.Text = TotalPrice.ToString("N");
            int InvoiceHeaderNo = Transaction.CreateNewInvoiceHeader(TotalPrice, "vch", int.Parse(LBLFileId.Text));
            foreach (var item in billInvoice)
            {
                Transaction.RegisterNewInvoiceElement(item, DateTime.Now, "vch", InvoiceHeaderNo);
            }
            LBLRepeatedService.Text = "ثبت شد!";
            LSTVUPatient.Enabled = true;
            LSTVUTemp.Items.Clear();
        }
        private void BTNSwitchToCash_Click(object sender, EventArgs e)
        {
            FRMCashier cashierForm = new FRMCashier(PID);
            cashierForm.ShowDialog();
            this.Close();
        }

        private void LSTVUPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val;
            try
            {
                if (int.TryParse(LSTVUPatient.SelectedItems[0].SubItems[2].Text, out val))
                {
                    InitForm(val);
                    this.PID = val;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
 
        }
        private  void UpdatePatientList(string name=null,string id=null)
        {
            LSTVUPatient.Items.Clear();
            var result = Transaction.GetPatientList(FirstName: name, FileID: id);
            for (int i = 0; i < result.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((string)result.Rows[i]["FNameSick"]);
                item.SubItems.Add((string)result.Rows[i]["LNameSick"]);
                item.SubItems.Add(((decimal)result.Rows[i]["IDsick"]).ToString());
                LSTVUPatient.Items.Add(item);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Trim().Length == 0)
                UpdatePatientList();

            if (((TextBox)sender).Text.Trim().Length < 3)
                return;

            int n;
            bool isNumeric = int.TryParse(((TextBox)sender).Text, out n);
            if (isNumeric)
                UpdatePatientList(id:n.ToString());
            if (!isNumeric)
            {
                UpdatePatientList(((TextBox)sender).Text, null);
            }
        }
        private void EnterOnService(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    for (int i = 0; i < LSTVUServiceList.SelectedItems.Count; i++)
            //    {
            //        if (LSTVUTemp.FindItemWithText(LSTVUServiceList.SelectedItems[i].Text) != null)
            //        {
            //            LBLRepeatedService.Text = "ثبت خدمت تکراری";
            //            return;
            //        }
            //        else
            //            LBLRepeatedService.Text = "";

            //        ListViewItem lvi = new ListViewItem(new string[] { LSTVUServiceList.SelectedItems[i].Text, teethQuadrant1.GetServiceArea(), "3500000" }, LSTVUServiceList.SelectedItems[i].Text);
            //        LSTVUTemp.Items.Add(lvi);
            //    }
            //if (LSTVUTemp.Items.Count > 0)
            //    LSTVUPatient.Enabled = false;
        }

        public void AddService(string ServiceName,int ServiceCode,int Profeciency,string ServicedObject)
        {
            int price = Transaction.GetServicePrice(ServiceCode, profeciencyCombobox1.GetProfeciencyType());
           ListViewItem lvi = new ListViewItem(new string[] { ServiceName, ServicedObject, price.ToString(), doctorNameComboBox.GetDoctorName(), doctorNameComboBox.GetDoctorID().ToString(), profeciencyCombobox1.GetProfeciencyType().ToString() }, ServiceName);
            LSTVUTemp.Items.Add(lvi);
        }

        private void TXTBXSumOfService_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string number = TXTBXSumOfService.Text.Replace(",", "");
                number=(int.Parse(number) / 10).ToString();
                string result = new PNumberTString().num2str(number);
                LBLPriceInText.Text = result+" تومان";
            }
            catch (Exception ex)
            {
            }
        }
    }
}
