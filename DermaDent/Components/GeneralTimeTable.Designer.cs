namespace DermaDent
{
    partial class GeneralTimeTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.LSTVUDoctorTimes = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MSKDTXTBXEndTime = new System.Windows.Forms.MaskedTextBox();
            this.MSKDTXTBXStartTime = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.BTNRegisterPresentTime = new System.Windows.Forms.Button();
            this.CHKBXLSTWeekDay = new System.Windows.Forms.CheckedListBox();
            this.CMBBXDoctorNameAndID = new System.Windows.Forms.ComboBox();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.LSTVUDoctorTimes);
            this.groupBox9.Controls.Add(this.MSKDTXTBXEndTime);
            this.groupBox9.Controls.Add(this.MSKDTXTBXStartTime);
            this.groupBox9.Controls.Add(this.label26);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.BTNRegisterPresentTime);
            this.groupBox9.Controls.Add(this.CHKBXLSTWeekDay);
            this.groupBox9.Controls.Add(this.CMBBXDoctorNameAndID);
            this.groupBox9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(514, 308);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Doctor Time";
            // 
            // LSTVUDoctorTimes
            // 
            this.LSTVUDoctorTimes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.LSTVUDoctorTimes.FullRowSelect = true;
            this.LSTVUDoctorTimes.Location = new System.Drawing.Point(212, 36);
            this.LSTVUDoctorTimes.Name = "LSTVUDoctorTimes";
            this.LSTVUDoctorTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSTVUDoctorTimes.RightToLeftLayout = true;
            this.LSTVUDoctorTimes.Size = new System.Drawing.Size(290, 260);
            this.LSTVUDoctorTimes.TabIndex = 6;
            this.LSTVUDoctorTimes.UseCompatibleStateImageBehavior = false;
            this.LSTVUDoctorTimes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "#";
            this.columnHeader6.Width = 20;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "fname";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "lname";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "day";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "start";
            this.columnHeader10.Width = 42;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "End";
            this.columnHeader11.Width = 42;
            // 
            // MSKDTXTBXEndTime
            // 
            this.MSKDTXTBXEndTime.Enabled = false;
            this.MSKDTXTBXEndTime.Location = new System.Drawing.Point(103, 244);
            this.MSKDTXTBXEndTime.Mask = "00:00";
            this.MSKDTXTBXEndTime.Name = "MSKDTXTBXEndTime";
            this.MSKDTXTBXEndTime.Size = new System.Drawing.Size(44, 21);
            this.MSKDTXTBXEndTime.TabIndex = 4;
            this.MSKDTXTBXEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // MSKDTXTBXStartTime
            // 
            this.MSKDTXTBXStartTime.Enabled = false;
            this.MSKDTXTBXStartTime.Location = new System.Drawing.Point(103, 215);
            this.MSKDTXTBXStartTime.Mask = "00:00";
            this.MSKDTXTBXStartTime.Name = "MSKDTXTBXStartTime";
            this.MSKDTXTBXStartTime.Size = new System.Drawing.Size(44, 21);
            this.MSKDTXTBXStartTime.TabIndex = 3;
            this.MSKDTXTBXStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Enabled = false;
            this.label26.Location = new System.Drawing.Point(153, 247);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(54, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "تا ساعت :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Location = new System.Drawing.Point(153, 218);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "از ساعت :";
            // 
            // BTNRegisterPresentTime
            // 
            this.BTNRegisterPresentTime.Enabled = false;
            this.BTNRegisterPresentTime.Location = new System.Drawing.Point(72, 273);
            this.BTNRegisterPresentTime.Name = "BTNRegisterPresentTime";
            this.BTNRegisterPresentTime.Size = new System.Drawing.Size(75, 23);
            this.BTNRegisterPresentTime.TabIndex = 5;
            this.BTNRegisterPresentTime.Text = "ثبت";
            this.BTNRegisterPresentTime.UseVisualStyleBackColor = true;
            // 
            // CHKBXLSTWeekDay
            // 
            this.CHKBXLSTWeekDay.Enabled = false;
            this.CHKBXLSTWeekDay.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CHKBXLSTWeekDay.FormattingEnabled = true;
            this.CHKBXLSTWeekDay.Items.AddRange(new object[] {
            "شناور",
            "شنبه",
            "یکشنبه",
            "دوشنبه",
            "سشنبه",
            "چهارشنبه",
            "پنجشنبه",
            "جمعه"});
            this.CHKBXLSTWeekDay.Location = new System.Drawing.Point(83, 70);
            this.CHKBXLSTWeekDay.Name = "CHKBXLSTWeekDay";
            this.CHKBXLSTWeekDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CHKBXLSTWeekDay.Size = new System.Drawing.Size(116, 132);
            this.CHKBXLSTWeekDay.TabIndex = 2;
            // 
            // CMBBXDoctorNameAndID
            // 
            this.CMBBXDoctorNameAndID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.CMBBXDoctorNameAndID.FormattingEnabled = true;
            this.CMBBXDoctorNameAndID.Location = new System.Drawing.Point(50, 36);
            this.CMBBXDoctorNameAndID.Name = "CMBBXDoctorNameAndID";
            this.CMBBXDoctorNameAndID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CMBBXDoctorNameAndID.Size = new System.Drawing.Size(147, 21);
            this.CMBBXDoctorNameAndID.TabIndex = 1;
            // 
            // GeneralTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox9);
            this.Name = "GeneralTimeTable";
            this.Size = new System.Drawing.Size(519, 315);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListView LSTVUDoctorTimes;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.MaskedTextBox MSKDTXTBXEndTime;
        private System.Windows.Forms.MaskedTextBox MSKDTXTBXStartTime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button BTNRegisterPresentTime;
        private System.Windows.Forms.CheckedListBox CHKBXLSTWeekDay;
        private System.Windows.Forms.ComboBox CMBBXDoctorNameAndID;
    }
}
