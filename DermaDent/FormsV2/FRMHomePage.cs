using DermaDent.FormsV2;
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
    public partial class FRMHomePage : Form
    {
        DSDentAssist.RobotManager _RobotManager = new DSDentAssist.RobotManager("495512196:AAEEFp8bS53i9LJiIfSxgkMPblKHOXrZ5oo");//Aren Bot=564766994:AAEJUk5VqNtpDc6JzbWPKumbuGK0bzktHOQ
        SoftwareUserInfo _userInfo;
        public FRMHomePage( SoftwareUserInfo sui)
        {
            InitializeComponent();
            LBLUserName.Text = string.Format("{0}: {1}","نام کاربر ",sui.name);
            _userInfo = sui;
        }

        private void AboutUs(object sender, EventArgs e)
        {
            new FRMAboutUS().ShowDialog();
        }
 

        private void BTNTratmentAndDetect_Click(object sender, EventArgs e)
        {
            showDiagnosesForm();
        }
        public void showDiagnosesForm()
        {
            FRMDiagnosisTreatmentPlan diagnosesForm = new FRMDiagnosisTreatmentPlan();
            diagnosesForm.MdiParent = this;
            diagnosesForm.Show();
        }

        private void سیستموقتدهیبهبیمارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMTimeAllocationSystem frmtas = new FRMTimeAllocationSystem();
            frmtas.MdiParent = this;
            frmtas.Show();
        }

        private void TTBTNTimeAllocatedPatient_Click(object sender, EventArgs e)
        {
            FRMReserverdTime frt = new FRMReserverdTime();
            frt.MdiParent = this;
            frt.Show();
        }

        private void BTNPanelRegistery_Click(object sender, EventArgs e)
        {
            DisplayNewPatientRegisterForm();
        }

        private void RegisterNewPatient(object sender, EventArgs e)
        {
            DisplayNewPatientRegisterForm();
        }

        public void DisplayNewPatientRegisterForm()
        {
            FRMPatientInfo frmpi = new FRMPatientInfo();
            frmpi.MdiParent = this;
            frmpi.Show();
        }

        private void TTBTnCashier_Click(object sender, EventArgs e)
        {
            FRMCashier frmc = new FRMCashier();
           // frmc.MdiParent = this;
            frmc.Show();
        }

        private void TTBTNPatientTimes_Click(object sender, EventArgs e)
        {
            LoadPatientRespect();
        }
        private void LoadPatientRespect()
        {
            FRMPatientRespect frmrspct = new FRMPatientRespect(_userInfo.name);
            frmrspct.MdiParent = this;
            frmrspct.Show();
        }

        private void BTNICReserveTime_Click(object sender, EventArgs e)
        {
            FRMAllocatTime frmat = new FRMAllocatTime(_userInfo.name);
            frmat.MdiParent = this;
            frmat.Show();
        }

        private void BTNPanelExit_Click(object sender, EventArgs e)
        {
            SignOut();
        }

        private void TTBTNExit_Click(object sender, EventArgs e)
        {
            SignOut();
        }
        public void SignOut()
        {
            if (MessageBox.Show("آیا مطمئن هستید می خواهید خارج شوید ؟", "هشدار!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void TTBTNErrorReport_Click(object sender, EventArgs e)
        {
            FRMReportSoftwareError frmrse = new FRMReportSoftwareError();
            frmrse.MdiParent = this;
            frmrse.Show();
        }

        private void UpdateStates_Tick(object sender, EventArgs e)
        {
            LBLTTTodayDateTime.Text ="امروز :  " +PersianDateTime.GetDayOfWeekName(DateTime.Now)+"  "+ PersianDateTime.GetPersianDate(DateTime.Now);
        }

        private void BTNTTDeclareServices_Click(object sender, EventArgs e)
        {
            FRMDeclareServices frmds = new FRMDeclareServices();
            frmds.MdiParent = this.MdiParent;
            frmds.Show();
        }

        private void LSTPatientLST_Click(object sender, EventArgs e)
        {
            FRMUserProfileList frmupl = new FRMUserProfileList();
            frmupl.MdiParent = this;
            frmupl.Show();
        }

        private void TTManageRadioGraphyImages_Click(object sender, EventArgs e)
        {
            FRMManageDocuments frmmd = new FRMManageDocuments();
            frmmd.MdiParent = this;
            frmmd.Show();
        }

        private void TTTimeDetails_Click(object sender, EventArgs e)
        {
            FRMTimingDiagnoses frmt = new FRMTimingDiagnoses();
            frmt.MdiParent = this;
            frmt.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool bHandled = false;
            // switch case is the easy way, a hash or map would be better, 
            // but more work to get set up.
            switch (keyData)
            {
                case Keys.F3:
                    ShowSearchBar();
                    bHandled = true;
                    break;
                case Keys.F6:
                    bHandled = true;
                    break;
                case Keys.F5:
                    bHandled = true;
                    break;
                case Keys.F4:
                    bHandled = true;
                    break;
            }
            return bHandled;
        }

        void ShowSearchBar()
        {
            FRMSearchPatient FSP = new FRMSearchPatient();
            FSP.MdiParent = this.ParentForm;
            FSP.Show();
        }
        private void QuickSearchForm(object sender, EventArgs e)
        {
            FRMSearchPatient FSP = new FRMSearchPatient();
            FSP.ShowDialog();
        }
    }
}
