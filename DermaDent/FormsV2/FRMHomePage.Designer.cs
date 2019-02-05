namespace DermaDent
{
    partial class FRMHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMHomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ورودوویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTBTNRegisterNewPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNTratmentAndDetect = new System.Windows.Forms.ToolStripMenuItem();
            this.سیستموقتدهیبهبیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTBTNTimeAllocatedPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.TTBTNExit = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTBTnCashier = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتگزارشدرمانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTManageRadioGraphyImages = new System.Windows.Forms.ToolStripMenuItem();
            this.تعاریفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNTTDeclareServices = new System.Windows.Forms.ToolStripMenuItem();
            this.نیروهایتخصصیمرکزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعرفههایدرمانیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.روزشیفتهایکاریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTTimeDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشپرداختهایبیمارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشکارکردپزشکانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشصندقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTBTNPatientTimes = new System.Windows.Forms.ToolStripMenuItem();
            this.LSTPatientLST = new System.Windows.Forms.ToolStripMenuItem();
            this.امکاناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتتصاویررادیوگرافیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دربارهنرمافزارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.TTBTNErrorReport = new System.Windows.Forms.ToolStripMenuItem();
            this.درخواستکمکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LBLUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBLTTTodayDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNICReserveTime = new DermaDent.IconnedButton();
            this.BTNPanelEdit = new DermaDent.IconnedButton();
            this.BTNPanelRegistery = new DermaDent.IconnedButton();
            this.BTNPanelReports = new DermaDent.IconnedButton();
            this.BTNPanelDeclaration = new DermaDent.IconnedButton();
            this.BTNPanelTools = new DermaDent.IconnedButton();
            this.BTNPanelInfo = new DermaDent.IconnedButton();
            this.BTNPanelExit = new DermaDent.IconnedButton();
            this.UpdateStates = new System.Windows.Forms.Timer(this.components);
            this.جستوجویسریعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ورودوویرایشToolStripMenuItem,
            this.عملیاتToolStripMenuItem,
            this.تعاریفToolStripMenuItem,
            this.گزارشهاToolStripMenuItem,
            this.امکاناتToolStripMenuItem,
            this.دربارهنرمافزارToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // ورودوویرایشToolStripMenuItem
            // 
            this.ورودوویرایشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTBTNRegisterNewPatient,
            this.BTNTratmentAndDetect,
            this.سیستموقتدهیبهبیمارToolStripMenuItem,
            this.TTBTNTimeAllocatedPatient,
            this.TTBTNExit});
            this.ورودوویرایشToolStripMenuItem.Name = "ورودوویرایشToolStripMenuItem";
            resources.ApplyResources(this.ورودوویرایشToolStripMenuItem, "ورودوویرایشToolStripMenuItem");
            // 
            // TTBTNRegisterNewPatient
            // 
            this.TTBTNRegisterNewPatient.Image = global::DermaDent.Properties.Resources.Healthcare_Clinic_icon;
            this.TTBTNRegisterNewPatient.Name = "TTBTNRegisterNewPatient";
            resources.ApplyResources(this.TTBTNRegisterNewPatient, "TTBTNRegisterNewPatient");
            this.TTBTNRegisterNewPatient.Click += new System.EventHandler(this.RegisterNewPatient);
            // 
            // BTNTratmentAndDetect
            // 
            this.BTNTratmentAndDetect.Image = global::DermaDent.Properties.Resources.Doctor_icon;
            this.BTNTratmentAndDetect.Name = "BTNTratmentAndDetect";
            resources.ApplyResources(this.BTNTratmentAndDetect, "BTNTratmentAndDetect");
            this.BTNTratmentAndDetect.Click += new System.EventHandler(this.BTNTratmentAndDetect_Click);
            // 
            // سیستموقتدهیبهبیمارToolStripMenuItem
            // 
            this.سیستموقتدهیبهبیمارToolStripMenuItem.Image = global::DermaDent.Properties.Resources.violetrectTime_Machine_icon;
            this.سیستموقتدهیبهبیمارToolStripMenuItem.Name = "سیستموقتدهیبهبیمارToolStripMenuItem";
            resources.ApplyResources(this.سیستموقتدهیبهبیمارToolStripMenuItem, "سیستموقتدهیبهبیمارToolStripMenuItem");
            this.سیستموقتدهیبهبیمارToolStripMenuItem.Click += new System.EventHandler(this.سیستموقتدهیبهبیمارToolStripMenuItem_Click);
            // 
            // TTBTNTimeAllocatedPatient
            // 
            this.TTBTNTimeAllocatedPatient.Image = global::DermaDent.Properties.Resources.Apps_preferences_system_time_icon;
            this.TTBTNTimeAllocatedPatient.Name = "TTBTNTimeAllocatedPatient";
            resources.ApplyResources(this.TTBTNTimeAllocatedPatient, "TTBTNTimeAllocatedPatient");
            this.TTBTNTimeAllocatedPatient.Click += new System.EventHandler(this.TTBTNTimeAllocatedPatient_Click);
            // 
            // TTBTNExit
            // 
            this.TTBTNExit.Image = global::DermaDent.Properties.Resources.Exit;
            this.TTBTNExit.Name = "TTBTNExit";
            resources.ApplyResources(this.TTBTNExit, "TTBTNExit");
            this.TTBTNExit.Click += new System.EventHandler(this.TTBTNExit_Click);
            // 
            // عملیاتToolStripMenuItem
            // 
            this.عملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTBTnCashier,
            this.ثبتگزارشدرمانToolStripMenuItem,
            this.TTManageRadioGraphyImages,
            this.جستوجویسریعToolStripMenuItem});
            this.عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            resources.ApplyResources(this.عملیاتToolStripMenuItem, "عملیاتToolStripMenuItem");
            // 
            // TTBTnCashier
            // 
            this.TTBTnCashier.Image = global::DermaDent.Properties.Resources.pricelist;
            this.TTBTnCashier.Name = "TTBTnCashier";
            resources.ApplyResources(this.TTBTnCashier, "TTBTnCashier");
            this.TTBTnCashier.Click += new System.EventHandler(this.TTBTnCashier_Click);
            // 
            // ثبتگزارشدرمانToolStripMenuItem
            // 
            this.ثبتگزارشدرمانToolStripMenuItem.Image = global::DermaDent.Properties.Resources.Reports_icon;
            this.ثبتگزارشدرمانToolStripMenuItem.Name = "ثبتگزارشدرمانToolStripMenuItem";
            resources.ApplyResources(this.ثبتگزارشدرمانToolStripMenuItem, "ثبتگزارشدرمانToolStripMenuItem");
            // 
            // TTManageRadioGraphyImages
            // 
            this.TTManageRadioGraphyImages.Image = global::DermaDent.Properties.Resources.skleton;
            this.TTManageRadioGraphyImages.Name = "TTManageRadioGraphyImages";
            resources.ApplyResources(this.TTManageRadioGraphyImages, "TTManageRadioGraphyImages");
            this.TTManageRadioGraphyImages.Click += new System.EventHandler(this.TTManageRadioGraphyImages_Click);
            // 
            // تعاریفToolStripMenuItem
            // 
            this.تعاریفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNTTDeclareServices,
            this.نیروهایتخصصیمرکزToolStripMenuItem,
            this.تعرفههایدرمانیToolStripMenuItem,
            this.روزشیفتهایکاریToolStripMenuItem,
            this.TTTimeDetails});
            this.تعاریفToolStripMenuItem.Name = "تعاریفToolStripMenuItem";
            resources.ApplyResources(this.تعاریفToolStripMenuItem, "تعاریفToolStripMenuItem");
            // 
            // BTNTTDeclareServices
            // 
            this.BTNTTDeclareServices.Image = global::DermaDent.Properties.Resources.checklist_icon;
            this.BTNTTDeclareServices.Name = "BTNTTDeclareServices";
            resources.ApplyResources(this.BTNTTDeclareServices, "BTNTTDeclareServices");
            this.BTNTTDeclareServices.Click += new System.EventHandler(this.BTNTTDeclareServices_Click);
            // 
            // نیروهایتخصصیمرکزToolStripMenuItem
            // 
            resources.ApplyResources(this.نیروهایتخصصیمرکزToolStripMenuItem, "نیروهایتخصصیمرکزToolStripMenuItem");
            this.نیروهایتخصصیمرکزToolStripMenuItem.Image = global::DermaDent.Properties.Resources.User_Group_icon;
            this.نیروهایتخصصیمرکزToolStripMenuItem.Name = "نیروهایتخصصیمرکزToolStripMenuItem";
            // 
            // تعرفههایدرمانیToolStripMenuItem
            // 
            resources.ApplyResources(this.تعرفههایدرمانیToolStripMenuItem, "تعرفههایدرمانیToolStripMenuItem");
            this.تعرفههایدرمانیToolStripMenuItem.Image = global::DermaDent.Properties.Resources.pricelist;
            this.تعرفههایدرمانیToolStripMenuItem.Name = "تعرفههایدرمانیToolStripMenuItem";
            // 
            // روزشیفتهایکاریToolStripMenuItem
            // 
            resources.ApplyResources(this.روزشیفتهایکاریToolStripMenuItem, "روزشیفتهایکاریToolStripMenuItem");
            this.روزشیفتهایکاریToolStripMenuItem.Name = "روزشیفتهایکاریToolStripMenuItem";
            // 
            // TTTimeDetails
            // 
            this.TTTimeDetails.Name = "TTTimeDetails";
            resources.ApplyResources(this.TTTimeDetails, "TTTimeDetails");
            this.TTTimeDetails.Click += new System.EventHandler(this.TTTimeDetails_Click);
            // 
            // گزارشهاToolStripMenuItem
            // 
            this.گزارشهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشپرداختهایبیمارToolStripMenuItem,
            this.گزارشکارکردپزشکانToolStripMenuItem,
            this.گزارشصندقToolStripMenuItem,
            this.TTBTNPatientTimes,
            this.LSTPatientLST});
            this.گزارشهاToolStripMenuItem.Name = "گزارشهاToolStripMenuItem";
            resources.ApplyResources(this.گزارشهاToolStripMenuItem, "گزارشهاToolStripMenuItem");
            // 
            // گزارشپرداختهایبیمارToolStripMenuItem
            // 
            this.گزارشپرداختهایبیمارToolStripMenuItem.Image = global::DermaDent.Properties.Resources.Cash_icon;
            this.گزارشپرداختهایبیمارToolStripMenuItem.Name = "گزارشپرداختهایبیمارToolStripMenuItem";
            resources.ApplyResources(this.گزارشپرداختهایبیمارToolStripMenuItem, "گزارشپرداختهایبیمارToolStripMenuItem");
            // 
            // گزارشکارکردپزشکانToolStripMenuItem
            // 
            this.گزارشکارکردپزشکانToolStripMenuItem.Image = global::DermaDent.Properties.Resources.cashier;
            this.گزارشکارکردپزشکانToolStripMenuItem.Name = "گزارشکارکردپزشکانToolStripMenuItem";
            resources.ApplyResources(this.گزارشکارکردپزشکانToolStripMenuItem, "گزارشکارکردپزشکانToolStripMenuItem");
            // 
            // گزارشصندقToolStripMenuItem
            // 
            resources.ApplyResources(this.گزارشصندقToolStripMenuItem, "گزارشصندقToolStripMenuItem");
            this.گزارشصندقToolStripMenuItem.Image = global::DermaDent.Properties.Resources.cashier_icon;
            this.گزارشصندقToolStripMenuItem.Name = "گزارشصندقToolStripMenuItem";
            // 
            // TTBTNPatientTimes
            // 
            this.TTBTNPatientTimes.Image = global::DermaDent.Properties.Resources.Health_care_shield_icon32;
            this.TTBTNPatientTimes.Name = "TTBTNPatientTimes";
            resources.ApplyResources(this.TTBTNPatientTimes, "TTBTNPatientTimes");
            this.TTBTNPatientTimes.Click += new System.EventHandler(this.TTBTNPatientTimes_Click);
            // 
            // LSTPatientLST
            // 
            this.LSTPatientLST.Name = "LSTPatientLST";
            resources.ApplyResources(this.LSTPatientLST, "LSTPatientLST");
            this.LSTPatientLST.Click += new System.EventHandler(this.LSTPatientLST_Click);
            // 
            // امکاناتToolStripMenuItem
            // 
            this.امکاناتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتتصاویررادیوگرافیToolStripMenuItem});
            this.امکاناتToolStripMenuItem.Name = "امکاناتToolStripMenuItem";
            resources.ApplyResources(this.امکاناتToolStripMenuItem, "امکاناتToolStripMenuItem");
            // 
            // مدیریتتصاویررادیوگرافیToolStripMenuItem
            // 
            this.مدیریتتصاویررادیوگرافیToolStripMenuItem.Name = "مدیریتتصاویررادیوگرافیToolStripMenuItem";
            resources.ApplyResources(this.مدیریتتصاویررادیوگرافیToolStripMenuItem, "مدیریتتصاویررادیوگرافیToolStripMenuItem");
            // 
            // دربارهنرمافزارToolStripMenuItem
            // 
            this.دربارهنرمافزارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNAboutUs,
            this.TTBTNErrorReport,
            this.درخواستکمکToolStripMenuItem});
            this.دربارهنرمافزارToolStripMenuItem.Name = "دربارهنرمافزارToolStripMenuItem";
            resources.ApplyResources(this.دربارهنرمافزارToolStripMenuItem, "دربارهنرمافزارToolStripMenuItem");
            // 
            // BTNAboutUs
            // 
            this.BTNAboutUs.Image = global::DermaDent.Properties.Resources.Aboutus_icon;
            this.BTNAboutUs.Name = "BTNAboutUs";
            resources.ApplyResources(this.BTNAboutUs, "BTNAboutUs");
            this.BTNAboutUs.Click += new System.EventHandler(this.AboutUs);
            // 
            // TTBTNErrorReport
            // 
            this.TTBTNErrorReport.Image = global::DermaDent.Properties.Resources.deleteerror_file_icon;
            this.TTBTNErrorReport.Name = "TTBTNErrorReport";
            resources.ApplyResources(this.TTBTNErrorReport, "TTBTNErrorReport");
            this.TTBTNErrorReport.Click += new System.EventHandler(this.TTBTNErrorReport_Click);
            // 
            // درخواستکمکToolStripMenuItem
            // 
            this.درخواستکمکToolStripMenuItem.Image = global::DermaDent.Properties.Resources.help_icon;
            this.درخواستکمکToolStripMenuItem.Name = "درخواستکمکToolStripMenuItem";
            resources.ApplyResources(this.درخواستکمکToolStripMenuItem, "درخواستکمکToolStripMenuItem");
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBLUserName,
            this.LBLTTTodayDateTime});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // LBLUserName
            // 
            this.LBLUserName.Name = "LBLUserName";
            resources.ApplyResources(this.LBLUserName, "LBLUserName");
            // 
            // LBLTTTodayDateTime
            // 
            this.LBLTTTodayDateTime.Name = "LBLTTTodayDateTime";
            this.LBLTTTodayDateTime.Padding = new System.Windows.Forms.Padding(200, 0, 200, 0);
            resources.ApplyResources(this.LBLTTTodayDateTime, "LBLTTTodayDateTime");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BTNICReserveTime);
            this.panel1.Controls.Add(this.BTNPanelEdit);
            this.panel1.Controls.Add(this.BTNPanelRegistery);
            this.panel1.Controls.Add(this.BTNPanelReports);
            this.panel1.Controls.Add(this.BTNPanelDeclaration);
            this.panel1.Controls.Add(this.BTNPanelTools);
            this.panel1.Controls.Add(this.BTNPanelInfo);
            this.panel1.Controls.Add(this.BTNPanelExit);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BTNICReserveTime
            // 
            resources.ApplyResources(this.BTNICReserveTime, "BTNICReserveTime");
            this.BTNICReserveTime.Image = global::DermaDent.Properties.Resources.Table;
            this.BTNICReserveTime.Name = "BTNICReserveTime";
            this.BTNICReserveTime.UseVisualStyleBackColor = true;
            this.BTNICReserveTime.Click += new System.EventHandler(this.BTNICReserveTime_Click);
            // 
            // BTNPanelEdit
            // 
            resources.ApplyResources(this.BTNPanelEdit, "BTNPanelEdit");
            this.BTNPanelEdit.Image = global::DermaDent.Properties.Resources.Text_Edit_icon;
            this.BTNPanelEdit.Name = "BTNPanelEdit";
            this.BTNPanelEdit.UseVisualStyleBackColor = true;
            // 
            // BTNPanelRegistery
            // 
            resources.ApplyResources(this.BTNPanelRegistery, "BTNPanelRegistery");
            this.BTNPanelRegistery.Image = global::DermaDent.Properties.Resources.Tooth_blue_icon;
            this.BTNPanelRegistery.Name = "BTNPanelRegistery";
            this.BTNPanelRegistery.UseVisualStyleBackColor = true;
            this.BTNPanelRegistery.Click += new System.EventHandler(this.BTNPanelRegistery_Click);
            // 
            // BTNPanelReports
            // 
            resources.ApplyResources(this.BTNPanelReports, "BTNPanelReports");
            this.BTNPanelReports.Image = global::DermaDent.Properties.Resources.Reports_icon;
            this.BTNPanelReports.Name = "BTNPanelReports";
            this.BTNPanelReports.UseVisualStyleBackColor = true;
            // 
            // BTNPanelDeclaration
            // 
            resources.ApplyResources(this.BTNPanelDeclaration, "BTNPanelDeclaration");
            this.BTNPanelDeclaration.Image = global::DermaDent.Properties.Resources.Apps_preferences_contact_list_icon;
            this.BTNPanelDeclaration.Name = "BTNPanelDeclaration";
            this.BTNPanelDeclaration.UseVisualStyleBackColor = true;
            // 
            // BTNPanelTools
            // 
            resources.ApplyResources(this.BTNPanelTools, "BTNPanelTools");
            this.BTNPanelTools.Image = global::DermaDent.Properties.Resources.toolsicon;
            this.BTNPanelTools.Name = "BTNPanelTools";
            this.BTNPanelTools.UseVisualStyleBackColor = true;
            // 
            // BTNPanelInfo
            // 
            resources.ApplyResources(this.BTNPanelInfo, "BTNPanelInfo");
            this.BTNPanelInfo.Image = global::DermaDent.Properties.Resources.Report2;
            this.BTNPanelInfo.Name = "BTNPanelInfo";
            this.BTNPanelInfo.UseVisualStyleBackColor = true;
            // 
            // BTNPanelExit
            // 
            resources.ApplyResources(this.BTNPanelExit, "BTNPanelExit");
            this.BTNPanelExit.Image = global::DermaDent.Properties.Resources.Exit;
            this.BTNPanelExit.Name = "BTNPanelExit";
            this.BTNPanelExit.UseVisualStyleBackColor = true;
            this.BTNPanelExit.Click += new System.EventHandler(this.BTNPanelExit_Click);
            // 
            // UpdateStates
            // 
            this.UpdateStates.Enabled = true;
            this.UpdateStates.Interval = 1000;
            this.UpdateStates.Tick += new System.EventHandler(this.UpdateStates_Tick);
            // 
            // جستوجویسریعToolStripMenuItem
            // 
            this.جستوجویسریعToolStripMenuItem.Image = global::DermaDent.Properties.Resources._145;
            this.جستوجویسریعToolStripMenuItem.Name = "جستوجویسریعToolStripMenuItem";
            resources.ApplyResources(this.جستوجویسریعToolStripMenuItem, "جستوجویسریعToolStripMenuItem");
            this.جستوجویسریعToolStripMenuItem.Click += new System.EventHandler(this.QuickSearchForm);
            // 
            // FRMHomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMHomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ورودوویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعاریفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem امکاناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهنرمافزارToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LBLUserName;
        private System.Windows.Forms.ToolStripStatusLabel LBLTTTodayDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem TTBTNRegisterNewPatient;
        private System.Windows.Forms.ToolStripMenuItem BTNTratmentAndDetect;
        private System.Windows.Forms.ToolStripMenuItem سیستموقتدهیبهبیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTBTNTimeAllocatedPatient;
        private System.Windows.Forms.ToolStripMenuItem TTBTNExit;
        private System.Windows.Forms.ToolStripMenuItem گزارشپرداختهایبیمارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BTNAboutUs;
        private IconnedButton BTNPanelExit;
        private IconnedButton BTNPanelInfo;
        private IconnedButton BTNPanelTools;
        private IconnedButton BTNPanelDeclaration;
        private IconnedButton BTNPanelRegistery;
        private IconnedButton BTNPanelReports;
        private System.Windows.Forms.ToolStripMenuItem BTNTTDeclareServices;
        private System.Windows.Forms.ToolStripMenuItem نیروهایتخصصیمرکزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعرفههایدرمانیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem روزشیفتهایکاریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشکارکردپزشکانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشصندقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTBTNErrorReport;
        private System.Windows.Forms.ToolStripMenuItem درخواستکمکToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTBTnCashier;
        private System.Windows.Forms.ToolStripMenuItem ثبتگزارشدرمانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTManageRadioGraphyImages;
        private System.Windows.Forms.ToolStripMenuItem TTBTNPatientTimes;
        private IconnedButton BTNICReserveTime;
        private IconnedButton BTNPanelEdit;
        private System.Windows.Forms.ToolStripMenuItem مدیریتتصاویررادیوگرافیToolStripMenuItem;
        private System.Windows.Forms.Timer UpdateStates;
        private System.Windows.Forms.ToolStripMenuItem LSTPatientLST;
        private System.Windows.Forms.ToolStripMenuItem TTTimeDetails;
        private System.Windows.Forms.ToolStripMenuItem جستوجویسریعToolStripMenuItem;
    }
}