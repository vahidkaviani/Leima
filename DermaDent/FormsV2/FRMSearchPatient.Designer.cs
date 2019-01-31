namespace DermaDent.FormsV2
{
    partial class FRMSearchPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVPatientList = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNameSick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LNameSick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNameDentist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoreInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXTBXLastName = new System.Windows.Forms.TextBox();
            this.TXTBXFirstName = new System.Windows.Forms.TextBox();
            this.TXTBXFileID = new System.Windows.Forms.TextBox();
            this.TXTBXNationID = new System.Windows.Forms.TextBox();
            this.BTNCancell = new DermaDent.IconnedButton();
            this.BTNSelect = new DermaDent.IconnedButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "شماره پرونده :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "شماره ملی :";
            // 
            // DGVPatientList
            // 
            this.DGVPatientList.AllowUserToAddRows = false;
            this.DGVPatientList.AllowUserToDeleteRows = false;
            this.DGVPatientList.AllowUserToResizeRows = false;
            this.DGVPatientList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatientList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.FNameSick,
            this.LNameSick,
            this.Tel,
            this.FNameDentist,
            this.Age,
            this.Gender,
            this.MoreInfo});
            this.DGVPatientList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVPatientList.Location = new System.Drawing.Point(0, 71);
            this.DGVPatientList.Name = "DGVPatientList";
            this.DGVPatientList.ReadOnly = true;
            this.DGVPatientList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVPatientList.RowHeadersVisible = false;
            this.DGVPatientList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DGVPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPatientList.ShowEditingIcon = false;
            this.DGVPatientList.Size = new System.Drawing.Size(659, 303);
            this.DGVPatientList.TabIndex = 10;
            this.DGVPatientList.DoubleClick += new System.EventHandler(this.SelectPatient);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "IDSick";
            this.PatientID.HeaderText = "پرونده";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientID.Width = 60;
            // 
            // FNameSick
            // 
            this.FNameSick.DataPropertyName = "FNameSick";
            this.FNameSick.HeaderText = "نام";
            this.FNameSick.Name = "FNameSick";
            this.FNameSick.ReadOnly = true;
            this.FNameSick.Width = 80;
            // 
            // LNameSick
            // 
            this.LNameSick.DataPropertyName = "LNameSick";
            this.LNameSick.HeaderText = "نام خانوادگی";
            this.LNameSick.Name = "LNameSick";
            this.LNameSick.ReadOnly = true;
            this.LNameSick.Width = 90;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "Tel";
            this.Tel.HeaderText = "تلفن";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 80;
            // 
            // FNameDentist
            // 
            this.FNameDentist.DataPropertyName = "TelQuick";
            this.FNameDentist.HeaderText = "همراه";
            this.FNameDentist.Name = "FNameDentist";
            this.FNameDentist.ReadOnly = true;
            this.FNameDentist.Width = 80;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Birthday";
            this.Age.HeaderText = "تاریخ تولد";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 72;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "sex";
            this.Gender.HeaderText = "جنسیت";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 50;
            // 
            // MoreInfo
            // 
            this.MoreInfo.HeaderText = "ملاحضات";
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.ReadOnly = true;
            this.MoreInfo.Width = 125;
            // 
            // TXTBXLastName
            // 
            this.TXTBXLastName.Location = new System.Drawing.Point(91, 6);
            this.TXTBXLastName.Name = "TXTBXLastName";
            this.TXTBXLastName.Size = new System.Drawing.Size(100, 21);
            this.TXTBXLastName.TabIndex = 11;
            this.TXTBXLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatePatientList);
            // 
            // TXTBXFirstName
            // 
            this.TXTBXFirstName.Location = new System.Drawing.Point(90, 33);
            this.TXTBXFirstName.Name = "TXTBXFirstName";
            this.TXTBXFirstName.Size = new System.Drawing.Size(100, 21);
            this.TXTBXFirstName.TabIndex = 11;
            this.TXTBXFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatePatientList);
            // 
            // TXTBXFileID
            // 
            this.TXTBXFileID.Location = new System.Drawing.Point(309, 6);
            this.TXTBXFileID.Name = "TXTBXFileID";
            this.TXTBXFileID.Size = new System.Drawing.Size(100, 21);
            this.TXTBXFileID.TabIndex = 11;
            this.TXTBXFileID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatePatientList);
            // 
            // TXTBXNationID
            // 
            this.TXTBXNationID.Location = new System.Drawing.Point(309, 33);
            this.TXTBXNationID.Name = "TXTBXNationID";
            this.TXTBXNationID.Size = new System.Drawing.Size(100, 21);
            this.TXTBXNationID.TabIndex = 11;
            this.TXTBXNationID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdatePatientList);
            // 
            // BTNCancell
            // 
            this.BTNCancell.Image = global::DermaDent.Properties.Resources.icons8_close_window_241;
            this.BTNCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNCancell.Location = new System.Drawing.Point(557, 37);
            this.BTNCancell.Name = "BTNCancell";
            this.BTNCancell.Size = new System.Drawing.Size(85, 32);
            this.BTNCancell.TabIndex = 12;
            this.BTNCancell.Text = "لغو";
            this.BTNCancell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCancell.UseVisualStyleBackColor = true;
            this.BTNCancell.Click += new System.EventHandler(this.BTNCancell_Click);
            // 
            // BTNSelect
            // 
            this.BTNSelect.Image = global::DermaDent.Properties.Resources.Yes;
            this.BTNSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNSelect.Location = new System.Drawing.Point(557, 2);
            this.BTNSelect.Name = "BTNSelect";
            this.BTNSelect.Size = new System.Drawing.Size(85, 32);
            this.BTNSelect.TabIndex = 12;
            this.BTNSelect.Text = "انتخاب";
            this.BTNSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSelect.UseVisualStyleBackColor = true;
            this.BTNSelect.Click += new System.EventHandler(this.BTNSelect_Click);
            // 
            // FRMSearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 374);
            this.Controls.Add(this.BTNCancell);
            this.Controls.Add(this.BTNSelect);
            this.Controls.Add(this.TXTBXFirstName);
            this.Controls.Add(this.TXTBXNationID);
            this.Controls.Add(this.TXTBXFileID);
            this.Controls.Add(this.TXTBXLastName);
            this.Controls.Add(this.DGVPatientList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRMSearchPatient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "جست و جوی اطلاعات بیماران";
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVPatientList;
        private System.Windows.Forms.TextBox TXTBXLastName;
        private System.Windows.Forms.TextBox TXTBXFirstName;
        private System.Windows.Forms.TextBox TXTBXFileID;
        private System.Windows.Forms.TextBox TXTBXNationID;
        private IconnedButton BTNSelect;
        private IconnedButton BTNCancell;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNameSick;
        private System.Windows.Forms.DataGridViewTextBoxColumn LNameSick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNameDentist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoreInfo;
    }
}