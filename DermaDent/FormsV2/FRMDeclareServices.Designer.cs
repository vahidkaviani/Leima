namespace DermaDent.FormsV2
{
    partial class FRMDeclareServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDeclareServices));
            this.DTGServices = new System.Windows.Forms.DataGridView();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEnglish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDBTNEdit = new System.Windows.Forms.RadioButton();
            this.RDBRNNew = new System.Windows.Forms.RadioButton();
            this.TXTBXEditCode = new System.Windows.Forms.TextBox();
            this.LBLEditCode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNICRegister = new DermaDent.IconnedButton();
            this.CMBBXServiceInsuranceType = new DermaDent.InsuranceServicesType();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTBXNewCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGServices)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGServices
            // 
            this.DTGServices.AllowUserToDeleteRows = false;
            this.DTGServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.Info,
            this.NameEnglish});
            this.DTGServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DTGServices.Location = new System.Drawing.Point(0, 140);
            this.DTGServices.MultiSelect = false;
            this.DTGServices.Name = "DTGServices";
            this.DTGServices.ReadOnly = true;
            this.DTGServices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DTGServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DTGServices.RowHeadersVisible = false;
            this.DTGServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGServices.Size = new System.Drawing.Size(1008, 522);
            this.DTGServices.TabIndex = 0;
            this.DTGServices.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ManageContextMenu);
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "IDService";
            this.ServiceID.HeaderText = "کد خدمت";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Width = 60;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "NameService";
            this.ServiceName.HeaderText = "نام خدمت";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.Width = 250;
            // 
            // Info
            // 
            this.Info.HeaderText = "توضیحات";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 400;
            // 
            // NameEnglish
            // 
            this.NameEnglish.DataPropertyName = "nameservice_latin";
            this.NameEnglish.HeaderText = "نام لاتین خدمت";
            this.NameEnglish.Name = "NameEnglish";
            this.NameEnglish.ReadOnly = true;
            this.NameEnglish.Width = 150;
            // 
            // RDBTNEdit
            // 
            this.RDBTNEdit.AutoSize = true;
            this.RDBTNEdit.Location = new System.Drawing.Point(945, 18);
            this.RDBTNEdit.Name = "RDBTNEdit";
            this.RDBTNEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RDBTNEdit.Size = new System.Drawing.Size(52, 17);
            this.RDBTNEdit.TabIndex = 1;
            this.RDBTNEdit.TabStop = true;
            this.RDBTNEdit.Text = "اصلاح";
            this.RDBTNEdit.UseVisualStyleBackColor = true;
            this.RDBTNEdit.CheckedChanged += new System.EventHandler(this.ChangeNewSwitch);
            // 
            // RDBRNNew
            // 
            this.RDBRNNew.AutoSize = true;
            this.RDBRNNew.Checked = true;
            this.RDBRNNew.Location = new System.Drawing.Point(950, 10);
            this.RDBRNNew.Name = "RDBRNNew";
            this.RDBRNNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RDBRNNew.Size = new System.Drawing.Size(47, 17);
            this.RDBRNNew.TabIndex = 1;
            this.RDBRNNew.TabStop = true;
            this.RDBRNNew.Text = "جدید";
            this.RDBRNNew.UseVisualStyleBackColor = true;
            this.RDBRNNew.CheckedChanged += new System.EventHandler(this.ChangeNewSwitch);
            // 
            // TXTBXEditCode
            // 
            this.TXTBXEditCode.Location = new System.Drawing.Point(819, 17);
            this.TXTBXEditCode.Name = "TXTBXEditCode";
            this.TXTBXEditCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTBXEditCode.Size = new System.Drawing.Size(70, 21);
            this.TXTBXEditCode.TabIndex = 3;
            this.TXTBXEditCode.Visible = false;
            // 
            // LBLEditCode
            // 
            this.LBLEditCode.AutoSize = true;
            this.LBLEditCode.Location = new System.Drawing.Point(895, 20);
            this.LBLEditCode.Name = "LBLEditCode";
            this.LBLEditCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLEditCode.Size = new System.Drawing.Size(25, 13);
            this.LBLEditCode.TabIndex = 2;
            this.LBLEditCode.Text = "کد :";
            this.LBLEditCode.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNICRegister);
            this.groupBox2.Controls.Add(this.CMBBXServiceInsuranceType);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TXTBXNewCode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RDBRNNew);
            this.groupBox2.Location = new System.Drawing.Point(0, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1008, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // BTNICRegister
            // 
            this.BTNICRegister.Image = global::DermaDent.Properties.Resources.checklist_icon;
            this.BTNICRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNICRegister.Location = new System.Drawing.Point(6, 47);
            this.BTNICRegister.Name = "BTNICRegister";
            this.BTNICRegister.Size = new System.Drawing.Size(100, 52);
            this.BTNICRegister.TabIndex = 6;
            this.BTNICRegister.Text = "ثبت خدمت";
            this.BTNICRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNICRegister.UseVisualStyleBackColor = true;
            this.BTNICRegister.Click += new System.EventHandler(this.BTNICRegister_Click);
            // 
            // CMBBXServiceInsuranceType
            // 
            this.CMBBXServiceInsuranceType.FormattingEnabled = true;
            this.CMBBXServiceInsuranceType.Items.AddRange(new object[] {
            "1,نوع خدمت ويزيت مي باشد",
            "2,نوع خدمت ، خدمت سرپائي مي باشد",
            "3,خدمات راديولوژي",
            "4,خدمات سونوگرافي",
            "5,خدمات سي تي اسكن",
            "6,خدمات ام آر آي",
            "7,خدمات پزشكي هسته اي",
            "8,خدمات راديوتراپي",
            "9,خدمات اديومتري",
            "10,خدمات گفتاردرماني",
            "11,خدمات آنژيو گرافي",
            "12,خدمات مكمل براقدامات تشخيصي",
            "1,نوع خدمت ويزيت مي باشد",
            "2,نوع خدمت ، خدمت سرپائي مي باشد",
            "3,خدمات راديولوژي",
            "4,خدمات سونوگرافي",
            "5,خدمات سي تي اسكن",
            "6,خدمات ام آر آي",
            "7,خدمات پزشكي هسته اي",
            "8,خدمات راديوتراپي",
            "9,خدمات اديومتري",
            "10,خدمات گفتاردرماني",
            "11,خدمات آنژيو گرافي",
            "12,خدمات مكمل براقدامات تشخيصي"});
            this.CMBBXServiceInsuranceType.Location = new System.Drawing.Point(449, 20);
            this.CMBBXServiceInsuranceType.Name = "CMBBXServiceInsuranceType";
            this.CMBBXServiceInsuranceType.Size = new System.Drawing.Size(203, 21);
            this.CMBBXServiceInsuranceType.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(112, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(112, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(777, 21);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(777, 21);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(895, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "توضیحات :";
            // 
            // TXTBXNewCode
            // 
            this.TXTBXNewCode.Location = new System.Drawing.Point(819, 20);
            this.TXTBXNewCode.Name = "TXTBXNewCode";
            this.TXTBXNewCode.Size = new System.Drawing.Size(70, 21);
            this.TXTBXNewCode.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(658, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "نوع خدمت جهت ارسال به بیمه :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(895, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "نام خدمت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "گروه خدمت :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "کد :";
            // 
            // FRMDeclareServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.TXTBXEditCode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LBLEditCode);
            this.Controls.Add(this.DTGServices);
            this.Controls.Add(this.RDBTNEdit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMDeclareServices";
            this.RightToLeftLayout = true;
            this.Text = "تعریف خدمات درمانی";
            ((System.ComponentModel.ISupportInitialize)(this.DTGServices)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGServices;
        private System.Windows.Forms.RadioButton RDBTNEdit;
        private System.Windows.Forms.RadioButton RDBRNNew;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTBXEditCode;
        private System.Windows.Forms.Label LBLEditCode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TXTBXNewCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private InsuranceServicesType CMBBXServiceInsuranceType;
        private IconnedButton BTNICRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEnglish;
    }
}