namespace DermaDent
{
    partial class FRMAllocatTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAllocatTime));
            this.BTNClose = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.BTNAllocatedTime = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTNDefineTimes = new System.Windows.Forms.Button();
            this.BTNSearchTimeAllocatedPatient = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTNNextMonth = new System.Windows.Forms.Button();
            this.BTNPreviousMonth = new System.Windows.Forms.Button();
            this.farsiCalendar1 = new DermaDent.FarsiDatePicker();
            this.GVQList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTGVReservedTimeList = new System.Windows.Forms.DataGridView();
            this.QueueNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendsms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNSearchPatient = new DermaDent.IconnedButton();
            this.TXTBXFileID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LBLLastName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.doctorNameComboBox1 = new DermaDent.DoctorNameComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BTNSaveTime = new System.Windows.Forms.Button();
            this.persianDateTimeBox1 = new DermaDent.PersianDateTimeBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.NUDYear = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBBXServiceName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CMBBXMonthNames = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CMBBXDay = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LBLWorkingUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVQList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVReservedTimeList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDYear)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNClose
            // 
            this.BTNClose.Image = global::DermaDent.Properties.Resources.Exit;
            this.BTNClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNClose.Location = new System.Drawing.Point(12, 3);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(114, 46);
            this.BTNClose.TabIndex = 0;
            this.BTNClose.Text = "خروج";
            this.BTNClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // button6
            // 
            this.button6.Image = global::DermaDent.Properties.Resources.Report2;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(362, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 46);
            this.button6.TabIndex = 0;
            this.button6.Text = "گزارش فعالیت کاربران";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::DermaDent.Properties.Resources.Table;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(482, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 46);
            this.button5.TabIndex = 0;
            this.button5.Text = "کارت تعیین وقت";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTNAllocatedTime
            // 
            this.BTNAllocatedTime.Image = global::DermaDent.Properties.Resources.Help_book;
            this.BTNAllocatedTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNAllocatedTime.Location = new System.Drawing.Point(581, 3);
            this.BTNAllocatedTime.Name = "BTNAllocatedTime";
            this.BTNAllocatedTime.Size = new System.Drawing.Size(129, 46);
            this.BTNAllocatedTime.TabIndex = 0;
            this.BTNAllocatedTime.Text = "گزارش لیست تعیین وقت";
            this.BTNAllocatedTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNAllocatedTime.UseVisualStyleBackColor = true;
            this.BTNAllocatedTime.Click += new System.EventHandler(this.BTNAllocatedTime_Click);
            // 
            // button3
            // 
            this.button3.Image = global::DermaDent.Properties.Resources.NotesBook;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(716, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 46);
            this.button3.TabIndex = 0;
            this.button3.Text = "تاریخچه کل نوبت های یک بیمار";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNDefineTimes
            // 
            this.BTNDefineTimes.Image = global::DermaDent.Properties.Resources.ClockDe;
            this.BTNDefineTimes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNDefineTimes.Location = new System.Drawing.Point(877, 3);
            this.BTNDefineTimes.Name = "BTNDefineTimes";
            this.BTNDefineTimes.Size = new System.Drawing.Size(78, 46);
            this.BTNDefineTimes.TabIndex = 0;
            this.BTNDefineTimes.Text = "تقسیم زمان";
            this.BTNDefineTimes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNDefineTimes.UseVisualStyleBackColor = true;
            this.BTNDefineTimes.Click += new System.EventHandler(this.BTNDefineTimes_Click);
            // 
            // BTNSearchTimeAllocatedPatient
            // 
            this.BTNSearchTimeAllocatedPatient.Image = global::DermaDent.Properties.Resources.Search;
            this.BTNSearchTimeAllocatedPatient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTNSearchTimeAllocatedPatient.Location = new System.Drawing.Point(1104, 3);
            this.BTNSearchTimeAllocatedPatient.Name = "BTNSearchTimeAllocatedPatient";
            this.BTNSearchTimeAllocatedPatient.Size = new System.Drawing.Size(68, 46);
            this.BTNSearchTimeAllocatedPatient.TabIndex = 0;
            this.BTNSearchTimeAllocatedPatient.Text = "جست و جو";
            this.BTNSearchTimeAllocatedPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNSearchTimeAllocatedPatient.UseVisualStyleBackColor = true;
            this.BTNSearchTimeAllocatedPatient.Click += new System.EventHandler(this.BTNSearchTimeAllocatedPatient_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTNNextMonth);
            this.tabPage2.Controls.Add(this.BTNPreviousMonth);
            this.tabPage2.Controls.Add(this.farsiCalendar1);
            this.tabPage2.Controls.Add(this.GVQList);
            this.tabPage2.Controls.Add(this.DTGVReservedTimeList);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 640);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "رزرو وقت پزشکان";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTNNextMonth
            // 
            this.BTNNextMonth.Location = new System.Drawing.Point(184, 0);
            this.BTNNextMonth.Name = "BTNNextMonth";
            this.BTNNextMonth.Size = new System.Drawing.Size(39, 23);
            this.BTNNextMonth.TabIndex = 12;
            this.BTNNextMonth.Text = ">";
            this.BTNNextMonth.UseVisualStyleBackColor = true;
            this.BTNNextMonth.Click += new System.EventHandler(this.BTNNextMonth_Click);
            // 
            // BTNPreviousMonth
            // 
            this.BTNPreviousMonth.Location = new System.Drawing.Point(229, 0);
            this.BTNPreviousMonth.Name = "BTNPreviousMonth";
            this.BTNPreviousMonth.Size = new System.Drawing.Size(39, 23);
            this.BTNPreviousMonth.TabIndex = 11;
            this.BTNPreviousMonth.Text = "<";
            this.BTNPreviousMonth.UseVisualStyleBackColor = true;
            this.BTNPreviousMonth.Click += new System.EventHandler(this.BTNPreviousMonth_Click);
            // 
            // farsiCalendar1
            // 
            this.farsiCalendar1._DaysInMonth = 31;
            this.farsiCalendar1._PresentingMonth = 4;
            this.farsiCalendar1._PresentingYear = 1397;
            this.farsiCalendar1._SelectedDay = 26;
            this.farsiCalendar1.BackColor = System.Drawing.Color.MidnightBlue;
            this.farsiCalendar1.CBackColor = System.Drawing.Color.Navy;
            this.farsiCalendar1.CNoneWorkingDayColor = System.Drawing.Color.Red;
            this.farsiCalendar1.CTodayFullDate = System.Drawing.Color.White;
            this.farsiCalendar1.CTodayFullDateColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.farsiCalendar1.CTodayRectColor = System.Drawing.Color.Lavender;
            this.farsiCalendar1.CWorkingDayColor = System.Drawing.Color.Yellow;
            this.farsiCalendar1.Location = new System.Drawing.Point(6, 6);
            this.farsiCalendar1.Name = "farsiCalendar1";
            this.farsiCalendar1.Size = new System.Drawing.Size(466, 279);
            this.farsiCalendar1.TabIndex = 11;
            // 
            // GVQList
            // 
            this.GVQList.AllowUserToAddRows = false;
            this.GVQList.AllowUserToDeleteRows = false;
            this.GVQList.AllowUserToResizeRows = false;
            this.GVQList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GVQList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVQList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.GVQList.Location = new System.Drawing.Point(946, 291);
            this.GVQList.Name = "GVQList";
            this.GVQList.ReadOnly = true;
            this.GVQList.RowHeadersVisible = false;
            this.GVQList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GVQList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVQList.ShowEditingIcon = false;
            this.GVQList.Size = new System.Drawing.Size(225, 311);
            this.GVQList.TabIndex = 10;
            this.GVQList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrSelected);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Dentist";
            this.dataGridViewTextBoxColumn1.HeaderText = "نام پزشک";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "QCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "تعداد نوبت";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // DTGVReservedTimeList
            // 
            this.DTGVReservedTimeList.AllowUserToAddRows = false;
            this.DTGVReservedTimeList.AllowUserToDeleteRows = false;
            this.DTGVReservedTimeList.AllowUserToResizeRows = false;
            this.DTGVReservedTimeList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTGVReservedTimeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTGVReservedTimeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVReservedTimeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QueueNo,
            this.VisitTime,
            this.pid,
            this.PatientFirstName,
            this.PatientLastName,
            this.description,
            this.Column6,
            this.Column12,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Status,
            this.sendsms});
            this.DTGVReservedTimeList.Location = new System.Drawing.Point(0, 291);
            this.DTGVReservedTimeList.Name = "DTGVReservedTimeList";
            this.DTGVReservedTimeList.RowHeadersVisible = false;
            this.DTGVReservedTimeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DTGVReservedTimeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGVReservedTimeList.ShowEditingIcon = false;
            this.DTGVReservedTimeList.Size = new System.Drawing.Size(940, 290);
            this.DTGVReservedTimeList.TabIndex = 9;
            this.DTGVReservedTimeList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleTimeContextMenu);
            // 
            // QueueNo
            // 
            this.QueueNo.DataPropertyName = "id";
            this.QueueNo.HeaderText = "ردیف";
            this.QueueNo.Name = "QueueNo";
            this.QueueNo.ReadOnly = true;
            this.QueueNo.Width = 40;
            // 
            // VisitTime
            // 
            this.VisitTime.DataPropertyName = "time";
            this.VisitTime.HeaderText = "ساعت";
            this.VisitTime.Name = "VisitTime";
            this.VisitTime.Width = 50;
            // 
            // pid
            // 
            this.pid.DataPropertyName = "PatientID";
            this.pid.HeaderText = "# پرونده";
            this.pid.Name = "pid";
            this.pid.Width = 70;
            // 
            // PatientFirstName
            // 
            this.PatientFirstName.DataPropertyName = "FNamesick";
            this.PatientFirstName.HeaderText = "نام";
            this.PatientFirstName.Name = "PatientFirstName";
            this.PatientFirstName.ReadOnly = true;
            this.PatientFirstName.Width = 80;
            // 
            // PatientLastName
            // 
            this.PatientLastName.DataPropertyName = "LNamesick";
            this.PatientLastName.HeaderText = "نام خانوادگی";
            this.PatientLastName.Name = "PatientLastName";
            this.PatientLastName.ReadOnly = true;
            this.PatientLastName.Width = 90;
            // 
            // description
            // 
            this.description.DataPropertyName = "ServiceName";
            this.description.HeaderText = "توضیحات";
            this.description.Name = "description";
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.description.Width = 180;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tel";
            this.Column6.HeaderText = "تلفن ثابت";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 85;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TelQuick";
            this.Column12.HeaderText = "تلفن همراه";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 85;
            // 
            // Column7
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "9";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 40;
            // 
            // Column9
            // 
            this.Column9.HeaderText = ";";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 40;
            // 
            // Column10
            // 
            this.Column10.HeaderText = ":";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 40;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "وضعیت";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 70;
            // 
            // sendsms
            // 
            this.sendsms.DataPropertyName = "SendMessage";
            this.sendsms.HeaderText = "ارسال sms";
            this.sendsms.Name = "sendsms";
            this.sendsms.ReadOnly = true;
            this.sendsms.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sendsms.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.doctorNameComboBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.BTNSaveTime);
            this.groupBox1.Controls.Add(this.persianDateTimeBox1);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.NUDYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CMBBXServiceName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.CMBBXMonthNames);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.CMBBXDay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(478, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNSearchPatient);
            this.groupBox2.Controls.Add(this.TXTBXFileID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.LBLLastName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(43, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات بیمار :";
            this.groupBox2.Visible = false;
            // 
            // BTNSearchPatient
            // 
            this.BTNSearchPatient.Image = global::DermaDent.Properties.Resources._145;
            this.BTNSearchPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNSearchPatient.Location = new System.Drawing.Point(6, 20);
            this.BTNSearchPatient.Name = "BTNSearchPatient";
            this.BTNSearchPatient.Size = new System.Drawing.Size(32, 32);
            this.BTNSearchPatient.TabIndex = 3;
            this.BTNSearchPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSearchPatient.UseVisualStyleBackColor = true;
            this.BTNSearchPatient.Click += new System.EventHandler(this.BTNSearchPatient_Click);
            // 
            // TXTBXFileID
            // 
            this.TXTBXFileID.Location = new System.Drawing.Point(57, 26);
            this.TXTBXFileID.Name = "TXTBXFileID";
            this.TXTBXFileID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXFileID.Size = new System.Drawing.Size(94, 21);
            this.TXTBXFileID.TabIndex = 2;
            this.TXTBXFileID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckPatientInfo);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "شماره پرونده :";
            // 
            // LBLLastName
            // 
            this.LBLLastName.AutoSize = true;
            this.LBLLastName.Location = new System.Drawing.Point(37, 64);
            this.LBLLastName.Name = "LBLLastName";
            this.LBLLastName.Size = new System.Drawing.Size(0, 13);
            this.LBLLastName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "نام / نام خانوادگی :";
            // 
            // doctorNameComboBox1
            // 
            this.doctorNameComboBox1.DataSource = ((object)(resources.GetObject("doctorNameComboBox1.DataSource")));
            this.doctorNameComboBox1.FormattingEnabled = true;
  
            this.doctorNameComboBox1.Location = new System.Drawing.Point(42, 121);
            this.doctorNameComboBox1.Name = "doctorNameComboBox1";
            this.doctorNameComboBox1.Size = new System.Drawing.Size(180, 21);
            this.doctorNameComboBox1.TabIndex = 10;
            this.doctorNameComboBox1.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(84, 45);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(51, 21);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.Text = "1500";
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.Visible = false;
            // 
            // BTNSaveTime
            // 
            this.BTNSaveTime.Image = global::DermaDent.Properties.Resources.Save;
            this.BTNSaveTime.Location = new System.Drawing.Point(40, 38);
            this.BTNSaveTime.Name = "BTNSaveTime";
            this.BTNSaveTime.Size = new System.Drawing.Size(32, 32);
            this.BTNSaveTime.TabIndex = 8;
            this.BTNSaveTime.UseVisualStyleBackColor = true;
            this.BTNSaveTime.Visible = false;
            this.BTNSaveTime.Click += new System.EventHandler(this.BTNSaveTime_Click);
            // 
            // persianDateTimeBox1
            // 
            this.persianDateTimeBox1.BadFormat = false;
            this.persianDateTimeBox1.Day = 31;
            this.persianDateTimeBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianDateTimeBox1.Location = new System.Drawing.Point(40, 13);
            this.persianDateTimeBox1.Mask = "0000/00/00";
            this.persianDateTimeBox1.Month = 1;
            this.persianDateTimeBox1.Name = "persianDateTimeBox1";
            this.persianDateTimeBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.persianDateTimeBox1.Size = new System.Drawing.Size(95, 22);
            this.persianDateTimeBox1.TabIndex = 4;
            this.persianDateTimeBox1.Text = "13970131";
            this.persianDateTimeBox1.Year = 1397;
            this.persianDateTimeBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.persianDateTimeBox1_KeyPress);
            // 
            // comboBox5
            // 
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "شیفت صبح",
            "شیفت عصر"});
            this.comboBox5.Location = new System.Drawing.Point(42, 159);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(180, 21);
            this.comboBox5.TabIndex = 7;
            this.comboBox5.Text = "شیفت صبح";
            this.comboBox5.Visible = false;
            // 
            // NUDYear
            // 
            this.NUDYear.Location = new System.Drawing.Point(428, 15);
            this.NUDYear.Maximum = new decimal(new int[] {
            1410,
            0,
            0,
            0});
            this.NUDYear.Minimum = new decimal(new int[] {
            1390,
            0,
            0,
            0});
            this.NUDYear.Name = "NUDYear";
            this.NUDYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NUDYear.Size = new System.Drawing.Size(65, 21);
            this.NUDYear.TabIndex = 0;
            this.NUDYear.Tag = "سال شمسی";
            this.NUDYear.Value = new decimal(new int[] {
            1397,
            0,
            0,
            0});
            this.NUDYear.ValueChanged += new System.EventHandler(this.NUDYear_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "سال";
            // 
            // CMBBXServiceName
            // 
            this.CMBBXServiceName.FormattingEnabled = true;
            this.CMBBXServiceName.Location = new System.Drawing.Point(42, 83);
            this.CMBBXServiceName.Name = "CMBBXServiceName";
            this.CMBBXServiceName.Size = new System.Drawing.Size(180, 21);
            this.CMBBXServiceName.TabIndex = 7;
            this.CMBBXServiceName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ماه";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(261, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "شیفت";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "روز";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(233, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(85, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "پزشک معالج";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // CMBBXMonthNames
            // 
            this.CMBBXMonthNames.FormattingEnabled = true;
            this.CMBBXMonthNames.Items.AddRange(new object[] {
            "فروردین",
            "اردیبهشت",
            "خرداد",
            "تیر",
            "مرداد",
            "شهریور",
            "مهر",
            "آبان",
            "آذر",
            "دی",
            "بهمن",
            "اسفند"});
            this.CMBBXMonthNames.Location = new System.Drawing.Point(291, 15);
            this.CMBBXMonthNames.Name = "CMBBXMonthNames";
            this.CMBBXMonthNames.Size = new System.Drawing.Size(76, 21);
            this.CMBBXMonthNames.TabIndex = 2;
            this.CMBBXMonthNames.Text = "فروردین";
            this.CMBBXMonthNames.SelectedIndexChanged += new System.EventHandler(this.CMBBXMonthNames_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(260, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "تخصص";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // CMBBXDay
            // 
            this.CMBBXDay.FormattingEnabled = true;
            this.CMBBXDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.CMBBXDay.Location = new System.Drawing.Point(193, 15);
            this.CMBBXDay.Name = "CMBBXDay";
            this.CMBBXDay.Size = new System.Drawing.Size(48, 21);
            this.CMBBXDay.TabIndex = 2;
            this.CMBBXDay.Text = "01";
            this.CMBBXDay.SelectedIndexChanged += new System.EventHandler(this.CMBBXDay_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ساعت :";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "تاریخ :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBLWorkingUser});
            this.statusStrip1.Location = new System.Drawing.Point(3, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1170, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LBLWorkingUser
            // 
            this.LBLWorkingUser.Name = "LBLWorkingUser";
            this.LBLWorkingUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLWorkingUser.Size = new System.Drawing.Size(74, 17);
            this.LBLWorkingUser.Text = "کاربر پذیرش: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(873, 589);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "توضیحات :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 666);
            this.tabControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.BTNSearchTimeAllocatedPatient);
            this.panel1.Controls.Add(this.BTNDefineTimes);
            this.panel1.Controls.Add(this.BTNClose);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.BTNAllocatedTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 53);
            this.panel1.TabIndex = 3;
            // 
            // FRMAllocatTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMAllocatTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "     رزرو وقت";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVQList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVReservedTimeList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDYear)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNSearchTimeAllocatedPatient;
        private System.Windows.Forms.Button BTNDefineTimes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTNAllocatedTime;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CMBBXMonthNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDYear;
        private System.Windows.Forms.TabControl tabControl1;
        private PersianDateTimeBox persianDateTimeBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBBXDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripStatusLabel LBLWorkingUser;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox CMBBXServiceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNSaveTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView DTGVReservedTimeList;
        private System.Windows.Forms.DataGridView GVQList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private DermaDent.FarsiDatePicker farsiCalendar1;
        private DoctorNameComboBox doctorNameComboBox1;
        private System.Windows.Forms.Button BTNNextMonth;
        private System.Windows.Forms.Button BTNPreviousMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTBXFileID;
        private IconnedButton BTNSearchPatient;
        private System.Windows.Forms.Label LBLLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueueNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn sendsms;
    }
}