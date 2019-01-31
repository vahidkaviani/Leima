namespace DermaDent
{
    partial class FRMCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMCashier));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLDateTime = new System.Windows.Forms.Label();
            this.LBLFamily = new System.Windows.Forms.Label();
            this.LBLName = new System.Windows.Forms.Label();
            this.LBLFileId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTGVUUserPayment = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TXTBXPaidValue = new System.Windows.Forms.MaskedTextBox();
            this.BTNRegisterPaiment = new DermaDent.IconnedButton();
            this.TXTBXRemain = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LBLPaidInPersian = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTBXPatientID = new System.Windows.Forms.TextBox();
            this.LSTVUPatient = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileIdNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconnedButton2 = new DermaDent.IconnedButton();
            this.BTNICExit = new DermaDent.IconnedButton();
            this.currentDateTimePersian1 = new DermaDent.CurrentDateTimePersian();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TTMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTMenuItemDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.پرداختقسطToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحیهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVUUserPayment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.LBLDateTime);
            this.groupBox1.Controls.Add(this.LBLFamily);
            this.groupBox1.Controls.Add(this.LBLName);
            this.groupBox1.Controls.Add(this.LBLFileId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(524, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(401, 85);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات پرونده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(91, 53);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "تاریخ:";
            // 
            // LBLDateTime
            // 
            this.LBLDateTime.AutoSize = true;
            this.LBLDateTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLDateTime.Location = new System.Drawing.Point(10, 53);
            this.LBLDateTime.Name = "LBLDateTime";
            this.LBLDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLDateTime.Size = new System.Drawing.Size(74, 16);
            this.LBLDateTime.TabIndex = 6;
            this.LBLDateTime.Text = "1396/02/26";
            // 
            // LBLFamily
            // 
            this.LBLFamily.AutoSize = true;
            this.LBLFamily.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLFamily.Location = new System.Drawing.Point(224, 56);
            this.LBLFamily.Name = "LBLFamily";
            this.LBLFamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLFamily.Size = new System.Drawing.Size(13, 16);
            this.LBLFamily.TabIndex = 6;
            this.LBLFamily.Text = "-";
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLName.Location = new System.Drawing.Point(224, 34);
            this.LBLName.Name = "LBLName";
            this.LBLName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLName.Size = new System.Drawing.Size(13, 16);
            this.LBLName.TabIndex = 6;
            this.LBLName.Text = "-";
            // 
            // LBLFileId
            // 
            this.LBLFileId.AutoSize = true;
            this.LBLFileId.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLFileId.Location = new System.Drawing.Point(13, 26);
            this.LBLFileId.Name = "LBLFileId";
            this.LBLFileId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLFileId.Size = new System.Drawing.Size(15, 16);
            this.LBLFileId.TabIndex = 6;
            this.LBLFileId.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(91, 26);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ش.پرونده:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(312, 31);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "نام:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(312, 53);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام خانوادگی:";
            // 
            // DTGVUUserPayment
            // 
            this.DTGVUUserPayment.AllowUserToAddRows = false;
            this.DTGVUUserPayment.AllowUserToDeleteRows = false;
            this.DTGVUUserPayment.AllowUserToResizeRows = false;
            this.DTGVUUserPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVUUserPayment.Location = new System.Drawing.Point(12, 40);
            this.DTGVUUserPayment.Name = "DTGVUUserPayment";
            this.DTGVUUserPayment.ReadOnly = true;
            this.DTGVUUserPayment.RowHeadersVisible = false;
            this.DTGVUUserPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGVUUserPayment.ShowEditingIcon = false;
            this.DTGVUUserPayment.Size = new System.Drawing.Size(506, 407);
            this.DTGVUUserPayment.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.TXTBXPaidValue);
            this.groupBox2.Controls.Add(this.BTNRegisterPaiment);
            this.groupBox2.Controls.Add(this.TXTBXRemain);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.LBLPaidInPersian);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(525, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(401, 277);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات پرونده";
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(206, 131);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(105, 20);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "واریز به حساب";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(206, 106);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(105, 20);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "نقدی";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(90, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 20);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "چک";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(206, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "کارت بانکی";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 52);
            this.textBox1.TabIndex = 11;
            // 
            // TXTBXPaidValue
            // 
            this.TXTBXPaidValue.AsciiOnly = true;
            this.TXTBXPaidValue.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTBXPaidValue.Location = new System.Drawing.Point(174, 187);
            this.TXTBXPaidValue.Name = "TXTBXPaidValue";
            this.TXTBXPaidValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXPaidValue.Size = new System.Drawing.Size(136, 31);
            this.TXTBXPaidValue.TabIndex = 10;
            this.TXTBXPaidValue.TextChanged += new System.EventHandler(this.TXTBXPaidValue_TextChanged);
            this.TXTBXPaidValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // BTNRegisterPaiment
            // 
            this.BTNRegisterPaiment.Image = global::DermaDent.Properties.Resources.Yes;
            this.BTNRegisterPaiment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNRegisterPaiment.Location = new System.Drawing.Point(13, 184);
            this.BTNRegisterPaiment.Name = "BTNRegisterPaiment";
            this.BTNRegisterPaiment.Size = new System.Drawing.Size(113, 31);
            this.BTNRegisterPaiment.TabIndex = 9;
            this.BTNRegisterPaiment.Text = "ثبت پرداخت ";
            this.BTNRegisterPaiment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRegisterPaiment.UseVisualStyleBackColor = true;
            this.BTNRegisterPaiment.Click += new System.EventHandler(this.BTNRegisterPaiment_Click);
            // 
            // TXTBXRemain
            // 
            this.TXTBXRemain.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TXTBXRemain.Location = new System.Drawing.Point(147, 30);
            this.TXTBXRemain.Name = "TXTBXRemain";
            this.TXTBXRemain.ReadOnly = true;
            this.TXTBXRemain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXRemain.Size = new System.Drawing.Size(113, 33);
            this.TXTBXRemain.TabIndex = 7;
            this.TXTBXRemain.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(281, 37);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "مانده قابل پرداخت :";
            // 
            // LBLPaidInPersian
            // 
            this.LBLPaidInPersian.AutoSize = true;
            this.LBLPaidInPersian.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLPaidInPersian.ForeColor = System.Drawing.Color.Red;
            this.LBLPaidInPersian.Location = new System.Drawing.Point(28, 158);
            this.LBLPaidInPersian.Name = "LBLPaidInPersian";
            this.LBLPaidInPersian.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLPaidInPersian.Size = new System.Drawing.Size(0, 16);
            this.LBLPaidInPersian.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(308, 218);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "توضیحات :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(308, 190);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "مبلغ پرداختی :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(112, 37);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "ریال";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(139, 193);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "ریال";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(317, 74);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "نوع پرداخت :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(1024, 36);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "نام / شماره پرونده";
            // 
            // TXTBXPatientID
            // 
            this.TXTBXPatientID.Location = new System.Drawing.Point(930, 36);
            this.TXTBXPatientID.Name = "TXTBXPatientID";
            this.TXTBXPatientID.Size = new System.Drawing.Size(88, 21);
            this.TXTBXPatientID.TabIndex = 16;
            this.TXTBXPatientID.TextChanged += new System.EventHandler(this.TXTBXPatientID_TextChanged);
            this.TXTBXPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXPatientID_KeyPress);
            // 
            // LSTVUPatient
            // 
            this.LSTVUPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.FileIdNo});
            this.LSTVUPatient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LSTVUPatient.FullRowSelect = true;
            this.LSTVUPatient.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LSTVUPatient.Location = new System.Drawing.Point(930, 62);
            this.LSTVUPatient.MultiSelect = false;
            this.LSTVUPatient.Name = "LSTVUPatient";
            this.LSTVUPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSTVUPatient.RightToLeftLayout = true;
            this.LSTVUPatient.Size = new System.Drawing.Size(199, 423);
            this.LSTVUPatient.TabIndex = 17;
            this.LSTVUPatient.UseCompatibleStateImageBehavior = false;
            this.LSTVUPatient.View = System.Windows.Forms.View.Details;
            this.LSTVUPatient.SelectedIndexChanged += new System.EventHandler(this.LSTVUPatient_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "نام و نام خانوادگی";
            this.columnHeader8.Width = 120;
            // 
            // FileIdNo
            // 
            this.FileIdNo.Name = "FileIdNo";
            this.FileIdNo.Text = "ش.پ";
            this.FileIdNo.Width = 75;
            // 
            // iconnedButton2
            // 
            this.iconnedButton2.Image = global::DermaDent.Properties.Resources.icons8_send_to_printer_24;
            this.iconnedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconnedButton2.Location = new System.Drawing.Point(210, 453);
            this.iconnedButton2.Name = "iconnedButton2";
            this.iconnedButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iconnedButton2.Size = new System.Drawing.Size(98, 32);
            this.iconnedButton2.TabIndex = 13;
            this.iconnedButton2.Text = "پرینت رسید";
            this.iconnedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconnedButton2.UseVisualStyleBackColor = true;
            // 
            // BTNICExit
            // 
            this.BTNICExit.Image = global::DermaDent.Properties.Resources.Exit;
            this.BTNICExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNICExit.Location = new System.Drawing.Point(12, 453);
            this.BTNICExit.Name = "BTNICExit";
            this.BTNICExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTNICExit.Size = new System.Drawing.Size(90, 32);
            this.BTNICExit.TabIndex = 13;
            this.BTNICExit.Text = "خروج";
            this.BTNICExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNICExit.UseVisualStyleBackColor = true;
            this.BTNICExit.Click += new System.EventHandler(this.BTNICExit_Click);
            // 
            // currentDateTimePersian1
            // 
            this.currentDateTimePersian1.ForeColor = System.Drawing.Color.DarkGreen;
            this.currentDateTimePersian1.Location = new System.Drawing.Point(524, 24);
            this.currentDateTimePersian1.Name = "currentDateTimePersian1";
            this.currentDateTimePersian1.Size = new System.Drawing.Size(89, 101);
            this.currentDateTimePersian1.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TTMenuItem
            // 
            this.TTMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTMenuItemDivision,
            this.پرداختقسطToolStripMenuItem,
            this.گزارشToolStripMenuItem,
            this.اصلاحیهToolStripMenuItem});
            this.TTMenuItem.Name = "TTMenuItem";
            this.TTMenuItem.Size = new System.Drawing.Size(85, 20);
            this.TTMenuItem.Text = "مدیریت هزینه";
            // 
            // TTMenuItemDivision
            // 
            this.TTMenuItemDivision.Name = "TTMenuItemDivision";
            this.TTMenuItemDivision.Size = new System.Drawing.Size(176, 22);
            this.TTMenuItemDivision.Text = "تقسیط هزینه بیماران";
            this.TTMenuItemDivision.Click += new System.EventHandler(this.BTNDevideUserPrePayment);
            // 
            // پرداختقسطToolStripMenuItem
            // 
            this.پرداختقسطToolStripMenuItem.Name = "پرداختقسطToolStripMenuItem";
            this.پرداختقسطToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.پرداختقسطToolStripMenuItem.Text = "پرداخت قسط";
            // 
            // گزارشToolStripMenuItem
            // 
            this.گزارشToolStripMenuItem.Name = "گزارشToolStripMenuItem";
            this.گزارشToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.گزارشToolStripMenuItem.Text = "گزارش";
            // 
            // اصلاحیهToolStripMenuItem
            // 
            this.اصلاحیهToolStripMenuItem.Name = "اصلاحیهToolStripMenuItem";
            this.اصلاحیهToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.اصلاحیهToolStripMenuItem.Text = "اصلاحیه";
            // 
            // FRMCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 490);
            this.Controls.Add(this.LSTVUPatient);
            this.Controls.Add(this.TXTBXPatientID);
            this.Controls.Add(this.iconnedButton2);
            this.Controls.Add(this.BTNICExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DTGVUUserPayment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentDateTimePersian1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMCashier";
            this.Text = "FRMCashier";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVUUserPayment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLDateTime;
        private System.Windows.Forms.Label LBLFamily;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.Label LBLFileId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DTGVUUserPayment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTBXRemain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private IconnedButton BTNRegisterPaiment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLPaidInPersian;
        private CurrentDateTimePersian currentDateTimePersian1;
        private System.Windows.Forms.MaskedTextBox TXTBXPaidValue;
        private System.Windows.Forms.Label label6;
        private IconnedButton BTNICExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private IconnedButton iconnedButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTBXPatientID;
        private System.Windows.Forms.ListView LSTVUPatient;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader FileIdNo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TTMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTMenuItemDivision;
        private System.Windows.Forms.ToolStripMenuItem پرداختقسطToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اصلاحیهToolStripMenuItem;
    }
}