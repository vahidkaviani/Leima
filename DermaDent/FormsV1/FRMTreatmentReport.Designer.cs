namespace DermaDent
{
    partial class FRMTreatmentReport
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
            this.LSTVUServiceList = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LSTVUTemp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dentist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLDateTime = new System.Windows.Forms.Label();
            this.LBLFamily = new System.Windows.Forms.Label();
            this.LBLName = new System.Windows.Forms.Label();
            this.LBLFileId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBLRepeatedService = new System.Windows.Forms.Label();
            this.BTNSwitchToCash = new System.Windows.Forms.Button();
            this.LSTVUPatient = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileIdNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTBXSumOfService = new System.Windows.Forms.TextBox();
            this.LBLPriceInText = new System.Windows.Forms.Label();
            this.profeciencyCombobox1 = new DermaDent.ProfeciencyCombobox();
            this.doctorNameComboBox = new DermaDent.DoctorNameComboBox();
            this.teethQuadrant1 = new DermaDent.TeethQuadrant(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LSTVUServiceList
            // 
            this.LSTVUServiceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.LSTVUServiceList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LSTVUServiceList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LSTVUServiceList.Location = new System.Drawing.Point(748, 170);
            this.LSTVUServiceList.MultiSelect = false;
            this.LSTVUServiceList.Name = "LSTVUServiceList";
            this.LSTVUServiceList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSTVUServiceList.RightToLeftLayout = true;
            this.LSTVUServiceList.Size = new System.Drawing.Size(232, 333);
            this.LSTVUServiceList.TabIndex = 0;
            this.LSTVUServiceList.UseCompatibleStateImageBehavior = false;
            this.LSTVUServiceList.View = System.Windows.Forms.View.Details;
            this.LSTVUServiceList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterOnService);
            this.LSTVUServiceList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LSTVUServiceList_MouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "خدمات";
            this.columnHeader2.Width = 228;
            // 
            // LSTVUTemp
            // 
            this.LSTVUTemp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader11,
            this.Dentist,
            this.columnHeader3,
            this.columnHeader4});
            this.LSTVUTemp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LSTVUTemp.FullRowSelect = true;
            this.LSTVUTemp.Location = new System.Drawing.Point(5, 134);
            this.LSTVUTemp.Name = "LSTVUTemp";
            this.LSTVUTemp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSTVUTemp.RightToLeftLayout = true;
            this.LSTVUTemp.Size = new System.Drawing.Size(737, 369);
            this.LSTVUTemp.TabIndex = 0;
            this.LSTVUTemp.UseCompatibleStateImageBehavior = false;
            this.LSTVUTemp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "نام خدمت";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ناحیه درمانی";
            this.columnHeader10.Width = 84;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "هزینه";
            this.columnHeader11.Width = 75;
            // 
            // Dentist
            // 
            this.Dentist.Text = "Dentist";
            this.Dentist.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "D#";
            this.columnHeader3.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "P";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.button1.Location = new System.Drawing.Point(86, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ثبت ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(395, 31);
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
            this.label3.Location = new System.Drawing.Point(395, 53);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "نام خانوادگی: ";
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
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(748, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(504, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات پرونده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(98, 53);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "تاریخ:";
            // 
            // LBLDateTime
            // 
            this.LBLDateTime.AutoSize = true;
            this.LBLDateTime.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLDateTime.Location = new System.Drawing.Point(10, 53);
            this.LBLDateTime.Name = "LBLDateTime";
            this.LBLDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLDateTime.Size = new System.Drawing.Size(78, 24);
            this.LBLDateTime.TabIndex = 6;
            this.LBLDateTime.Text = "1396/02/26";
            // 
            // LBLFamily
            // 
            this.LBLFamily.AutoSize = true;
            this.LBLFamily.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLFamily.Location = new System.Drawing.Point(301, 53);
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
            this.LBLName.Location = new System.Drawing.Point(301, 31);
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
            this.LBLFileId.Location = new System.Drawing.Point(10, 31);
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
            this.label4.Location = new System.Drawing.Point(98, 31);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ش.پرونده:";
            // 
            // LBLRepeatedService
            // 
            this.LBLRepeatedService.AutoSize = true;
            this.LBLRepeatedService.Font = new System.Drawing.Font("B Traffic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLRepeatedService.ForeColor = System.Drawing.Color.Red;
            this.LBLRepeatedService.Location = new System.Drawing.Point(554, 511);
            this.LBLRepeatedService.Name = "LBLRepeatedService";
            this.LBLRepeatedService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLRepeatedService.Size = new System.Drawing.Size(0, 29);
            this.LBLRepeatedService.TabIndex = 6;
            // 
            // BTNSwitchToCash
            // 
            this.BTNSwitchToCash.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BTNSwitchToCash.Location = new System.Drawing.Point(250, 537);
            this.BTNSwitchToCash.Name = "BTNSwitchToCash";
            this.BTNSwitchToCash.Size = new System.Drawing.Size(129, 23);
            this.BTNSwitchToCash.TabIndex = 11;
            this.BTNSwitchToCash.Text = "ثبت وانتقال به صندوق";
            this.BTNSwitchToCash.UseVisualStyleBackColor = true;
            this.BTNSwitchToCash.Click += new System.EventHandler(this.BTNSwitchToCash_Click);
            // 
            // LSTVUPatient
            // 
            this.LSTVUPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.FileIdNo});
            this.LSTVUPatient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LSTVUPatient.FullRowSelect = true;
            this.LSTVUPatient.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LSTVUPatient.Location = new System.Drawing.Point(997, 170);
            this.LSTVUPatient.MultiSelect = false;
            this.LSTVUPatient.Name = "LSTVUPatient";
            this.LSTVUPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LSTVUPatient.RightToLeftLayout = true;
            this.LSTVUPatient.Size = new System.Drawing.Size(265, 333);
            this.LSTVUPatient.TabIndex = 0;
            this.LSTVUPatient.UseCompatibleStateImageBehavior = false;
            this.LSTVUPatient.View = System.Windows.Forms.View.Details;
            this.LSTVUPatient.SelectedIndexChanged += new System.EventHandler(this.LSTVUPatient_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Name = global::DermaDent.Properties.Settings.Default.FNameSick;
            this.columnHeader7.Text = "نام";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "نام خانوادگی";
            this.columnHeader8.Width = 90;
            // 
            // FileIdNo
            // 
            this.FileIdNo.Name = "FileIdNo";
            this.FileIdNo.Text = "ش.پ";
            this.FileIdNo.Width = 80;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(997, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(1174, 106);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام یا شماره پرونده :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label6.Location = new System.Drawing.Point(980, 141);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "گروه تعرفه ای :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(684, 509);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "جمع کل :";
            // 
            // TXTBXSumOfService
            // 
            this.TXTBXSumOfService.Location = new System.Drawing.Point(5, 505);
            this.TXTBXSumOfService.Name = "TXTBXSumOfService";
            this.TXTBXSumOfService.ReadOnly = true;
            this.TXTBXSumOfService.Size = new System.Drawing.Size(156, 20);
            this.TXTBXSumOfService.TabIndex = 19;
            this.TXTBXSumOfService.TextChanged += new System.EventHandler(this.TXTBXSumOfService_TextChanged);
            // 
            // LBLPriceInText
            // 
            this.LBLPriceInText.AutoSize = true;
            this.LBLPriceInText.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LBLPriceInText.Location = new System.Drawing.Point(202, 506);
            this.LBLPriceInText.Name = "LBLPriceInText";
            this.LBLPriceInText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLPriceInText.Size = new System.Drawing.Size(29, 16);
            this.LBLPriceInText.TabIndex = 6;
            this.LBLPriceInText.Text = "ریال";
            // 
            // profeciencyCombobox1
            // 
            this.profeciencyCombobox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.profeciencyCombobox1.FormattingEnabled = true;
            this.profeciencyCombobox1.Items.AddRange(new object[] {
            "1,متخصص",
            "2,عمومي",
            "3,پروتز",
            "4,لابراتوار اريکه"});
            this.profeciencyCombobox1.Location = new System.Drawing.Point(748, 138);
            this.profeciencyCombobox1.Name = "profeciencyCombobox1";
            this.profeciencyCombobox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profeciencyCombobox1.Size = new System.Drawing.Size(232, 21);
            this.profeciencyCombobox1.TabIndex = 17;
            // 
            // doctorNameComboBox
            // 
            this.doctorNameComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.doctorNameComboBox.FormattingEnabled = true;
            this.doctorNameComboBox.Location = new System.Drawing.Point(748, 106);
            this.doctorNameComboBox.Name = "doctorNameComboBox";
            this.doctorNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doctorNameComboBox.Size = new System.Drawing.Size(232, 21);
            this.doctorNameComboBox.TabIndex = 16;
            this.doctorNameComboBox.Text = "انتخاب نام پزشک";
            // 
            // teethQuadrant1
            // 
            this.teethQuadrant1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.teethQuadrant1.Location = new System.Drawing.Point(15, 12);
            this.teethQuadrant1.Name = "teethQuadrant1";
            this.teethQuadrant1.Size = new System.Drawing.Size(445, 116);
            this.teethQuadrant1.TabIndex = 10;
            // 
            // FRMTreatmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 572);
            this.Controls.Add(this.TXTBXSumOfService);
            this.Controls.Add(this.LBLPriceInText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.profeciencyCombobox1);
            this.Controls.Add(this.doctorNameComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNSwitchToCash);
            this.Controls.Add(this.teethQuadrant1);
            this.Controls.Add(this.LBLRepeatedService);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LSTVUTemp);
            this.Controls.Add(this.LSTVUPatient);
            this.Controls.Add(this.LSTVUServiceList);
            this.Name = "FRMTreatmentReport";
            this.Text = "Register Treatment Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LSTVUServiceList;
        private System.Windows.Forms.ListView LSTVUTemp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLDateTime;
        private System.Windows.Forms.Label LBLFamily;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.Label LBLFileId;
        private System.Windows.Forms.Label LBLRepeatedService;
        private TeethQuadrant teethQuadrant1;
        private System.Windows.Forms.Button BTNSwitchToCash;
        private System.Windows.Forms.ListView LSTVUPatient;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader FileIdNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader Dentist;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private DoctorNameComboBox doctorNameComboBox;
        private ProfeciencyCombobox profeciencyCombobox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTBXSumOfService;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label LBLPriceInText;
    }
}