namespace DermaDent
{
    partial class FRMSearchTimeAllocated
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSearchTimeAllocated));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CHKBX = new System.Windows.Forms.CheckBox();
            this.TXTBXFirstName = new System.Windows.Forms.TextBox();
            this.TXTBXLastName = new System.Windows.Forms.TextBox();
            this.TXTBXID = new System.Windows.Forms.TextBox();
            this.TXTBXDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVPatientVisitingTimes = new System.Windows.Forms.DataGridView();
            this.iconnedButton2 = new DermaDent.IconnedButton();
            this.BTNICExit = new DermaDent.IconnedButton();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LNameSick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNameSick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarikh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsuranceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToothNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNameDentist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientVisitingTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CHKBX);
            this.panel1.Controls.Add(this.TXTBXFirstName);
            this.panel1.Controls.Add(this.TXTBXLastName);
            this.panel1.Controls.Add(this.TXTBXID);
            this.panel1.Controls.Add(this.TXTBXDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 31);
            this.panel1.TabIndex = 0;
            // 
            // CHKBX
            // 
            this.CHKBX.AutoSize = true;
            this.CHKBX.Location = new System.Drawing.Point(97, 7);
            this.CHKBX.Name = "CHKBX";
            this.CHKBX.Size = new System.Drawing.Size(54, 17);
            this.CHKBX.TabIndex = 3;
            this.CHKBX.Text = "تاریخ :";
            this.CHKBX.UseVisualStyleBackColor = true;
            this.CHKBX.CheckedChanged += new System.EventHandler(this.CHKBX_CheckedChanged);
            // 
            // TXTBXFirstName
            // 
            this.TXTBXFirstName.Location = new System.Drawing.Point(251, 5);
            this.TXTBXFirstName.Name = "TXTBXFirstName";
            this.TXTBXFirstName.Size = new System.Drawing.Size(80, 21);
            this.TXTBXFirstName.TabIndex = 2;
            this.TXTBXFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXID_KeyPress);
            // 
            // TXTBXLastName
            // 
            this.TXTBXLastName.Location = new System.Drawing.Point(367, 5);
            this.TXTBXLastName.Name = "TXTBXLastName";
            this.TXTBXLastName.Size = new System.Drawing.Size(80, 21);
            this.TXTBXLastName.TabIndex = 2;
            this.TXTBXLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXID_KeyPress);
            // 
            // TXTBXID
            // 
            this.TXTBXID.Location = new System.Drawing.Point(548, 5);
            this.TXTBXID.Name = "TXTBXID";
            this.TXTBXID.Size = new System.Drawing.Size(63, 21);
            this.TXTBXID.TabIndex = 2;
            this.TXTBXID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXID_KeyPress);
            // 
            // TXTBXDate
            // 
            this.TXTBXDate.Enabled = false;
            this.TXTBXDate.Location = new System.Drawing.Point(14, 5);
            this.TXTBXDate.Mask = "0000/00/00";
            this.TXTBXDate.Name = "TXTBXDate";
            this.TXTBXDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXDate.Size = new System.Drawing.Size(77, 21);
            this.TXTBXDate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "نام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام خانوادگی :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد :";
            // 
            // DGVPatientVisitingTimes
            // 
            this.DGVPatientVisitingTimes.AllowUserToAddRows = false;
            this.DGVPatientVisitingTimes.AllowUserToDeleteRows = false;
            this.DGVPatientVisitingTimes.AllowUserToResizeRows = false;
            this.DGVPatientVisitingTimes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVPatientVisitingTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatientVisitingTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.LNameSick,
            this.FNameSick,
            this.Tarikh,
            this.Time,
            this.Doctor,
            this.Insurance,
            this.InsuranceNo,
            this.ID,
            this.ToothNo,
            this.Tel,
            this.ServiceName,
            this.FNameDentist});
            this.DGVPatientVisitingTimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGVPatientVisitingTimes.Location = new System.Drawing.Point(0, 31);
            this.DGVPatientVisitingTimes.Name = "DGVPatientVisitingTimes";
            this.DGVPatientVisitingTimes.ReadOnly = true;
            this.DGVPatientVisitingTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVPatientVisitingTimes.RowHeadersVisible = false;
            this.DGVPatientVisitingTimes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DGVPatientVisitingTimes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPatientVisitingTimes.ShowEditingIcon = false;
            this.DGVPatientVisitingTimes.Size = new System.Drawing.Size(672, 282);
            this.DGVPatientVisitingTimes.TabIndex = 9;
            // 
            // iconnedButton2
            // 
            this.iconnedButton2.Image = global::DermaDent.Properties.Resources.Yes;
            this.iconnedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconnedButton2.Location = new System.Drawing.Point(547, 317);
            this.iconnedButton2.Name = "iconnedButton2";
            this.iconnedButton2.Size = new System.Drawing.Size(82, 32);
            this.iconnedButton2.TabIndex = 10;
            this.iconnedButton2.Text = "تایید";
            this.iconnedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconnedButton2.UseVisualStyleBackColor = true;
            // 
            // BTNICExit
            // 
            this.BTNICExit.Image = global::DermaDent.Properties.Resources.Exit;
            this.BTNICExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNICExit.Location = new System.Drawing.Point(28, 317);
            this.BTNICExit.Name = "BTNICExit";
            this.BTNICExit.Size = new System.Drawing.Size(82, 32);
            this.BTNICExit.TabIndex = 10;
            this.BTNICExit.Text = "خروج";
            this.BTNICExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNICExit.UseVisualStyleBackColor = true;
            this.BTNICExit.Click += new System.EventHandler(this.BTNICExit_Click);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "کد";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientID.Width = 60;
            // 
            // LNameSick
            // 
            this.LNameSick.DataPropertyName = "LNameSick";
            this.LNameSick.HeaderText = "نام خانوادگی";
            this.LNameSick.Name = "LNameSick";
            this.LNameSick.ReadOnly = true;
            // 
            // FNameSick
            // 
            this.FNameSick.DataPropertyName = "FNameSick";
            this.FNameSick.HeaderText = "نام";
            this.FNameSick.Name = "FNameSick";
            this.FNameSick.ReadOnly = true;
            this.FNameSick.Width = 80;
            // 
            // Tarikh
            // 
            this.Tarikh.DataPropertyName = "Tarikh";
            this.Tarikh.HeaderText = "تاریخ";
            this.Tarikh.Name = "Tarikh";
            this.Tarikh.ReadOnly = true;
            this.Tarikh.Width = 70;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "ساعت";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 55;
            // 
            // Doctor
            // 
            this.Doctor.DataPropertyName = "Dentist";
            this.Doctor.HeaderText = "نام پزشک ";
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            this.Doctor.Width = 110;
            // 
            // Insurance
            // 
            this.Insurance.DataPropertyName = "Insurance";
            this.Insurance.HeaderText = "بیمه";
            this.Insurance.Name = "Insurance";
            this.Insurance.ReadOnly = true;
            this.Insurance.Width = 70;
            // 
            // InsuranceNo
            // 
            this.InsuranceNo.DataPropertyName = "InsuranceNo";
            this.InsuranceNo.HeaderText = "شماره دفترچه";
            this.InsuranceNo.Name = "InsuranceNo";
            this.InsuranceNo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ToothNo
            // 
            this.ToothNo.DataPropertyName = "ToothNo";
            this.ToothNo.HeaderText = "ToothNo";
            this.ToothNo.Name = "ToothNo";
            this.ToothNo.ReadOnly = true;
            this.ToothNo.Visible = false;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Visible = false;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "ServiceName";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Visible = false;
            // 
            // FNameDentist
            // 
            this.FNameDentist.DataPropertyName = "FNameDentist";
            this.FNameDentist.HeaderText = "FNameDentist";
            this.FNameDentist.Name = "FNameDentist";
            this.FNameDentist.ReadOnly = true;
            this.FNameDentist.Visible = false;
            // 
            // FRMSearchTimeAllocated
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 352);
            this.Controls.Add(this.iconnedButton2);
            this.Controls.Add(this.BTNICExit);
            this.Controls.Add(this.DGVPatientVisitingTimes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMSearchTimeAllocated";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "جست و جوی بیماران نوبت دهی شده";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientVisitingTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXTBXID;
        private System.Windows.Forms.MaskedTextBox TXTBXDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBXFirstName;
        private System.Windows.Forms.TextBox TXTBXLastName;
        private System.Windows.Forms.DataGridView DGVPatientVisitingTimes;
        private IconnedButton BTNICExit;
        private IconnedButton iconnedButton2;
        private System.Windows.Forms.CheckBox CHKBX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LNameSick;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNameSick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarikh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsuranceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToothNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNameDentist;
    }
}