namespace DermaDent.FormsV2
{
    partial class FRMManageDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMManageDocuments));
            this.BTNBrowse = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.SaveToFileAddress = new System.Windows.Forms.TextBox();
            this.OwnerGroupbox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LBLIDCode = new System.Windows.Forms.Label();
            this.LBLPatientName = new System.Windows.Forms.Label();
            this.LSTVUPatientDocumentList = new System.Windows.Forms.ListView();
            this.FileNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TXTBXDocNationalCode = new System.Windows.Forms.TextBox();
            this.TXTBXDOCFileID = new System.Windows.Forms.TextBox();
            this.DocumentList = new System.Windows.Forms.DataGridView();
            this.IDsick2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastNameSick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meliCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectSaveToFile = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconnedButton3 = new DermaDent.IconnedButton();
            this.iconnedButton2 = new DermaDent.IconnedButton();
            this.iconnedButton5 = new DermaDent.IconnedButton();
            this.iconnedButton1 = new DermaDent.IconnedButton();
            this.PatientImageBrowserPanel = new marlie.TumbnailDotnet.ThumbnailFlowLayoutPanel();
            this.OwnerGroupbox.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNBrowse
            // 
            this.BTNBrowse.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BTNBrowse.Location = new System.Drawing.Point(88, 36);
            this.BTNBrowse.Name = "BTNBrowse";
            this.BTNBrowse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTNBrowse.Size = new System.Drawing.Size(70, 23);
            this.BTNBrowse.TabIndex = 17;
            this.BTNBrowse.Text = "انتخاب...";
            this.BTNBrowse.UseVisualStyleBackColor = true;
            this.BTNBrowse.Click += new System.EventHandler(this.BTNBrowse_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label23.Location = new System.Drawing.Point(508, 40);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(92, 14);
            this.label23.TabIndex = 16;
            this.label23.Text = "محل ذخیره فایل:";
            // 
            // SaveToFileAddress
            // 
            this.SaveToFileAddress.Location = new System.Drawing.Point(165, 38);
            this.SaveToFileAddress.Name = "SaveToFileAddress";
            this.SaveToFileAddress.ReadOnly = true;
            this.SaveToFileAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveToFileAddress.Size = new System.Drawing.Size(337, 21);
            this.SaveToFileAddress.TabIndex = 15;
            // 
            // OwnerGroupbox
            // 
            this.OwnerGroupbox.Controls.Add(this.label12);
            this.OwnerGroupbox.Controls.Add(this.label14);
            this.OwnerGroupbox.Controls.Add(this.LBLIDCode);
            this.OwnerGroupbox.Controls.Add(this.LBLPatientName);
            this.OwnerGroupbox.Location = new System.Drawing.Point(427, 140);
            this.OwnerGroupbox.Name = "OwnerGroupbox";
            this.OwnerGroupbox.Size = new System.Drawing.Size(319, 82);
            this.OwnerGroupbox.TabIndex = 14;
            this.OwnerGroupbox.TabStop = false;
            this.OwnerGroupbox.Text = "Owner";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "نام/نام خانوادگی بیمار :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "شماره پرونده :";
            // 
            // LBLIDCode
            // 
            this.LBLIDCode.AutoSize = true;
            this.LBLIDCode.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLIDCode.Location = new System.Drawing.Point(40, 43);
            this.LBLIDCode.Name = "LBLIDCode";
            this.LBLIDCode.Size = new System.Drawing.Size(21, 26);
            this.LBLIDCode.TabIndex = 3;
            this.LBLIDCode.Text = "...";
            // 
            // LBLPatientName
            // 
            this.LBLPatientName.AutoSize = true;
            this.LBLPatientName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLPatientName.Location = new System.Drawing.Point(40, 20);
            this.LBLPatientName.Name = "LBLPatientName";
            this.LBLPatientName.Size = new System.Drawing.Size(21, 26);
            this.LBLPatientName.TabIndex = 3;
            this.LBLPatientName.Text = "...";
            // 
            // LSTVUPatientDocumentList
            // 
            this.LSTVUPatientDocumentList.AllowDrop = true;
            this.LSTVUPatientDocumentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNo,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LSTVUPatientDocumentList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LSTVUPatientDocumentList.FullRowSelect = true;
            this.LSTVUPatientDocumentList.Location = new System.Drawing.Point(427, 228);
            this.LSTVUPatientDocumentList.Name = "LSTVUPatientDocumentList";
            this.LSTVUPatientDocumentList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSTVUPatientDocumentList.RightToLeftLayout = true;
            this.LSTVUPatientDocumentList.Size = new System.Drawing.Size(319, 367);
            this.LSTVUPatientDocumentList.TabIndex = 13;
            this.LSTVUPatientDocumentList.UseCompatibleStateImageBehavior = false;
            this.LSTVUPatientDocumentList.View = System.Windows.Forms.View.Details;
            // 
            // FileNo
            // 
            this.FileNo.Text = "ش";
            this.FileNo.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "نام فایل";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "تاریخ ثبت";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "توضیحات";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 250;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.TXTBXDocNationalCode);
            this.groupBox6.Controls.Add(this.TXTBXDOCFileID);
            this.groupBox6.Location = new System.Drawing.Point(4, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(417, 46);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "جست و جو";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Dentist";
            this.label15.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(132, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "کد ملی";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "نام یا شماره پرونده";
            // 
            // TXTBXDocNationalCode
            // 
            this.TXTBXDocNationalCode.Location = new System.Drawing.Point(36, 19);
            this.TXTBXDocNationalCode.Name = "TXTBXDocNationalCode";
            this.TXTBXDocNationalCode.Size = new System.Drawing.Size(90, 21);
            this.TXTBXDocNationalCode.TabIndex = 1;
            this.TXTBXDocNationalCode.Visible = false;
            // 
            // TXTBXDOCFileID
            // 
            this.TXTBXDOCFileID.Location = new System.Drawing.Point(224, 19);
            this.TXTBXDOCFileID.Name = "TXTBXDOCFileID";
            this.TXTBXDOCFileID.Size = new System.Drawing.Size(90, 21);
            this.TXTBXDOCFileID.TabIndex = 0;
            this.TXTBXDOCFileID.TextChanged += new System.EventHandler(this.SearchByTextDoc);
            this.TXTBXDOCFileID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXTBXDOCFileID_KeyDown);
            // 
            // DocumentList
            // 
            this.DocumentList.AllowUserToAddRows = false;
            this.DocumentList.AllowUserToDeleteRows = false;
            this.DocumentList.AllowUserToOrderColumns = true;
            this.DocumentList.AllowUserToResizeRows = false;
            this.DocumentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocumentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDsick2,
            this.PatientFirstName,
            this.LastNameSick,
            this.meliCode2});
            this.DocumentList.Location = new System.Drawing.Point(4, 201);
            this.DocumentList.MultiSelect = false;
            this.DocumentList.Name = "DocumentList";
            this.DocumentList.ReadOnly = true;
            this.DocumentList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DocumentList.RowHeadersVisible = false;
            this.DocumentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocumentList.ShowEditingIcon = false;
            this.DocumentList.Size = new System.Drawing.Size(417, 394);
            this.DocumentList.TabIndex = 11;
            this.DocumentList.SelectionChanged += new System.EventHandler(this.DocumentList_SelectionChanged);
            // 
            // IDsick2
            // 
            this.IDsick2.DataPropertyName = "IDsick";
            this.IDsick2.HeaderText = "ش.پرونده";
            this.IDsick2.Name = "IDsick2";
            this.IDsick2.ReadOnly = true;
            // 
            // PatientFirstName
            // 
            this.PatientFirstName.DataPropertyName = "FnameSick";
            this.PatientFirstName.HeaderText = "نام بیمار";
            this.PatientFirstName.Name = "PatientFirstName";
            this.PatientFirstName.ReadOnly = true;
            // 
            // LastNameSick
            // 
            this.LastNameSick.DataPropertyName = "LnameSick";
            this.LastNameSick.HeaderText = "نام خانوادگی بیمار";
            this.LastNameSick.Name = "LastNameSick";
            this.LastNameSick.ReadOnly = true;
            // 
            // meliCode2
            // 
            this.meliCode2.DataPropertyName = "meliCode";
            this.meliCode2.HeaderText = "کد ملی";
            this.meliCode2.Name = "meliCode2";
            this.meliCode2.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.iconnedButton3);
            this.panel1.Controls.Add(this.iconnedButton2);
            this.panel1.Controls.Add(this.BTNBrowse);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.iconnedButton5);
            this.panel1.Controls.Add(this.SaveToFileAddress);
            this.panel1.Controls.Add(this.iconnedButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 86);
            this.panel1.TabIndex = 19;
            // 
            // iconnedButton3
            // 
            this.iconnedButton3.Image = global::DermaDent.Properties.Resources.WireSurgeryBlack;
            this.iconnedButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconnedButton3.Location = new System.Drawing.Point(702, 9);
            this.iconnedButton3.Name = "iconnedButton3";
            this.iconnedButton3.Size = new System.Drawing.Size(120, 65);
            this.iconnedButton3.TabIndex = 0;
            this.iconnedButton3.Text = "تصاویر جراحی";
            this.iconnedButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconnedButton3.UseVisualStyleBackColor = true;
            // 
            // iconnedButton2
            // 
            this.iconnedButton2.Image = global::DermaDent.Properties.Resources.CosmeticRestoration;
            this.iconnedButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconnedButton2.Location = new System.Drawing.Point(866, 9);
            this.iconnedButton2.Name = "iconnedButton2";
            this.iconnedButton2.Size = new System.Drawing.Size(120, 65);
            this.iconnedButton2.TabIndex = 0;
            this.iconnedButton2.Text = "تصاویر ترمیم و زیبایی";
            this.iconnedButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconnedButton2.UseVisualStyleBackColor = true;
            // 
            // iconnedButton5
            // 
            this.iconnedButton5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconnedButton5.Image = global::DermaDent.Properties.Resources.RadioTrapy;
            this.iconnedButton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconnedButton5.Location = new System.Drawing.Point(1030, 9);
            this.iconnedButton5.Name = "iconnedButton5";
            this.iconnedButton5.Size = new System.Drawing.Size(120, 65);
            this.iconnedButton5.TabIndex = 0;
            this.iconnedButton5.Text = "تصاویر رادیوگرافی";
            this.iconnedButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconnedButton5.UseVisualStyleBackColor = true;
            // 
            // iconnedButton1
            // 
            this.iconnedButton1.Image = global::DermaDent.Properties.Resources.Ortho96;
            this.iconnedButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconnedButton1.Location = new System.Drawing.Point(1194, 9);
            this.iconnedButton1.Name = "iconnedButton1";
            this.iconnedButton1.Size = new System.Drawing.Size(120, 65);
            this.iconnedButton1.TabIndex = 0;
            this.iconnedButton1.Text = "تصاویر ارتودنسی";
            this.iconnedButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconnedButton1.UseVisualStyleBackColor = true;
            // 
            // PatientImageBrowserPanel
            // 
            this.PatientImageBrowserPanel.AutoScroll = true;
            this.PatientImageBrowserPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PatientImageBrowserPanel.Location = new System.Drawing.Point(752, 149);
            this.PatientImageBrowserPanel.Name = "PatientImageBrowserPanel";
            this.PatientImageBrowserPanel.Size = new System.Drawing.Size(575, 446);
            this.PatientImageBrowserPanel.TabIndex = 18;
            // 
            // FRMManageDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatientImageBrowserPanel);
            this.Controls.Add(this.OwnerGroupbox);
            this.Controls.Add(this.LSTVUPatientDocumentList);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.DocumentList);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRMManageDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت تصاویر و مدارک";
            this.OwnerGroupbox.ResumeLayout(false);
            this.OwnerGroupbox.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private marlie.TumbnailDotnet.ThumbnailFlowLayoutPanel PatientImageBrowserPanel;
        private System.Windows.Forms.Button BTNBrowse;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox SaveToFileAddress;
        private System.Windows.Forms.GroupBox OwnerGroupbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LBLIDCode;
        private System.Windows.Forms.Label LBLPatientName;
        private System.Windows.Forms.ListView LSTVUPatientDocumentList;
        private System.Windows.Forms.ColumnHeader FileNo;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXTBXDocNationalCode;
        private System.Windows.Forms.TextBox TXTBXDOCFileID;
        private System.Windows.Forms.DataGridView DocumentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDsick2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastNameSick;
        private System.Windows.Forms.DataGridViewTextBoxColumn meliCode2;
        private System.Windows.Forms.SaveFileDialog SelectSaveToFile;
        private System.Windows.Forms.Panel panel1;
        private IconnedButton iconnedButton1;
        private IconnedButton iconnedButton3;
        private IconnedButton iconnedButton2;
        private IconnedButton iconnedButton5;
    }
}