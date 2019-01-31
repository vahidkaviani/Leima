namespace DermaDent.FormsV2
{
    partial class FRMRepayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMRepayment));
            this.DTGPaymentProgram = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaiableValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekDayMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTBXTotalPrice = new System.Windows.Forms.TextBox();
            this.TXTBXPrePay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTBXNextPayCount = new System.Windows.Forms.TextBox();
            this.TXTBXNextPayValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LBLPrePayPercent = new System.Windows.Forms.Label();
            this.LBLFinPay = new System.Windows.Forms.Label();
            this.LBLFirstName = new System.Windows.Forms.Label();
            this.LBLLastName = new System.Windows.Forms.Label();
            this.LBLFileID = new System.Windows.Forms.Label();
            this.BTNCancell = new DermaDent.IconnedButton();
            this.iconnedButton2 = new DermaDent.IconnedButton();
            this.TXTBXCalculate = new DermaDent.IconnedButton();
            this.persianDateTimeBox1 = new DermaDent.PersianDateTimeBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGPaymentProgram)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTGPaymentProgram
            // 
            this.DTGPaymentProgram.AllowUserToAddRows = false;
            this.DTGPaymentProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGPaymentProgram.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.PaiableValue,
            this.PaymentTime,
            this.WeekDayMonth,
            this.Description});
            this.DTGPaymentProgram.Location = new System.Drawing.Point(-5, 186);
            this.DTGPaymentProgram.MultiSelect = false;
            this.DTGPaymentProgram.Name = "DTGPaymentProgram";
            this.DTGPaymentProgram.RowHeadersVisible = false;
            this.DTGPaymentProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGPaymentProgram.Size = new System.Drawing.Size(526, 337);
            this.DTGPaymentProgram.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "شماره";
            this.No.Name = "No";
            this.No.Width = 50;
            // 
            // PaiableValue
            // 
            this.PaiableValue.HeaderText = "مبلغ قسط";
            this.PaiableValue.Name = "PaiableValue";
            // 
            // PaymentTime
            // 
            this.PaymentTime.HeaderText = "تاریخ سررسید";
            this.PaymentTime.Name = "PaymentTime";
            // 
            // WeekDayMonth
            // 
            this.WeekDayMonth.HeaderText = "روز/ماه";
            this.WeekDayMonth.Name = "WeekDayMonth";
            // 
            // Description
            // 
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "هزینه کل :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "پیش پرداخت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "تاریخ تقسیط :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "امروز :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "1397/04/31";
            // 
            // TXTBXTotalPrice
            // 
            this.TXTBXTotalPrice.Location = new System.Drawing.Point(376, 73);
            this.TXTBXTotalPrice.Name = "TXTBXTotalPrice";
            this.TXTBXTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXTotalPrice.Size = new System.Drawing.Size(72, 21);
            this.TXTBXTotalPrice.TabIndex = 0;
            this.TXTBXTotalPrice.Text = "0";
            // 
            // TXTBXPrePay
            // 
            this.TXTBXPrePay.Location = new System.Drawing.Point(376, 101);
            this.TXTBXPrePay.Name = "TXTBXPrePay";
            this.TXTBXPrePay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXPrePay.Size = new System.Drawing.Size(72, 21);
            this.TXTBXPrePay.TabIndex = 1;
            this.TXTBXPrePay.Text = "0";
            this.TXTBXPrePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXPrePay_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.LBLLastName);
            this.panel1.Controls.Add(this.LBLFileID);
            this.panel1.Controls.Add(this.LBLFirstName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BTNCancell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 65);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "نام خانوادگی :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "شماره پرونده :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "نام :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "تعداد قسط :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "پرداخت ماهانه :";
            // 
            // TXTBXNextPayCount
            // 
            this.TXTBXNextPayCount.Location = new System.Drawing.Point(376, 129);
            this.TXTBXNextPayCount.Name = "TXTBXNextPayCount";
            this.TXTBXNextPayCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXNextPayCount.Size = new System.Drawing.Size(72, 21);
            this.TXTBXNextPayCount.TabIndex = 2;
            this.TXTBXNextPayCount.Text = "0";
            this.TXTBXNextPayCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXNextPayCount_KeyPress);
            // 
            // TXTBXNextPayValue
            // 
            this.TXTBXNextPayValue.Location = new System.Drawing.Point(376, 157);
            this.TXTBXNextPayValue.Name = "TXTBXNextPayValue";
            this.TXTBXNextPayValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TXTBXNextPayValue.Size = new System.Drawing.Size(72, 21);
            this.TXTBXNextPayValue.TabIndex = 3;
            this.TXTBXNextPayValue.Text = "0";
            this.TXTBXNextPayValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXNextPayValue_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "ریال";
            // 
            // LBLPrePayPercent
            // 
            this.LBLPrePayPercent.AutoSize = true;
            this.LBLPrePayPercent.Location = new System.Drawing.Point(334, 106);
            this.LBLPrePayPercent.Name = "LBLPrePayPercent";
            this.LBLPrePayPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBLPrePayPercent.Size = new System.Drawing.Size(24, 13);
            this.LBLPrePayPercent.TabIndex = 8;
            this.LBLPrePayPercent.Text = "0%";
            // 
            // LBLFinPay
            // 
            this.LBLFinPay.AutoSize = true;
            this.LBLFinPay.Location = new System.Drawing.Point(258, 160);
            this.LBLFinPay.Name = "LBLFinPay";
            this.LBLFinPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLFinPay.Size = new System.Drawing.Size(0, 13);
            this.LBLFinPay.TabIndex = 8;
            // 
            // LBLFirstName
            // 
            this.LBLFirstName.AutoSize = true;
            this.LBLFirstName.Location = new System.Drawing.Point(397, 10);
            this.LBLFirstName.Name = "LBLFirstName";
            this.LBLFirstName.Size = new System.Drawing.Size(0, 13);
            this.LBLFirstName.TabIndex = 1;
            // 
            // LBLLastName
            // 
            this.LBLLastName.AutoSize = true;
            this.LBLLastName.Location = new System.Drawing.Point(397, 37);
            this.LBLLastName.Name = "LBLLastName";
            this.LBLLastName.Size = new System.Drawing.Size(0, 13);
            this.LBLLastName.TabIndex = 1;
            // 
            // LBLFileID
            // 
            this.LBLFileID.AutoSize = true;
            this.LBLFileID.Location = new System.Drawing.Point(215, 10);
            this.LBLFileID.Name = "LBLFileID";
            this.LBLFileID.Size = new System.Drawing.Size(0, 13);
            this.LBLFileID.TabIndex = 1;
            // 
            // BTNCancell
            // 
            this.BTNCancell.Image = global::DermaDent.Properties.Resources.Exit;
            this.BTNCancell.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNCancell.Location = new System.Drawing.Point(9, 10);
            this.BTNCancell.Name = "BTNCancell";
            this.BTNCancell.Size = new System.Drawing.Size(76, 32);
            this.BTNCancell.TabIndex = 7;
            this.BTNCancell.Text = "خروج";
            this.BTNCancell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCancell.UseVisualStyleBackColor = true;
            this.BTNCancell.Click += new System.EventHandler(this.BTNCancell_Click);
            // 
            // iconnedButton2
            // 
            this.iconnedButton2.Image = global::DermaDent.Properties.Resources.checklist_icon;
            this.iconnedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconnedButton2.Location = new System.Drawing.Point(9, 530);
            this.iconnedButton2.Name = "iconnedButton2";
            this.iconnedButton2.Size = new System.Drawing.Size(97, 32);
            this.iconnedButton2.TabIndex = 6;
            this.iconnedButton2.Text = "ثبت نهایی";
            this.iconnedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconnedButton2.UseVisualStyleBackColor = true;
            this.iconnedButton2.Click += new System.EventHandler(this.iconnedButton2_Click);
            // 
            // TXTBXCalculate
            // 
            this.TXTBXCalculate.Image = global::DermaDent.Properties.Resources.Apps_preferences_system_time_icon;
            this.TXTBXCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TXTBXCalculate.Location = new System.Drawing.Point(365, 529);
            this.TXTBXCalculate.Name = "TXTBXCalculate";
            this.TXTBXCalculate.Size = new System.Drawing.Size(122, 32);
            this.TXTBXCalculate.TabIndex = 5;
            this.TXTBXCalculate.Text = "محاسبه اقساط";
            this.TXTBXCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TXTBXCalculate.UseVisualStyleBackColor = true;
            this.TXTBXCalculate.Click += new System.EventHandler(this.TXTBXCalculate_Click);
            // 
            // persianDateTimeBox1
            // 
            this.persianDateTimeBox1.BadFormat = false;
            this.persianDateTimeBox1.Day = 0;
            this.persianDateTimeBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.persianDateTimeBox1.Location = new System.Drawing.Point(9, 94);
            this.persianDateTimeBox1.Mask = "0000/00/00";
            this.persianDateTimeBox1.Month = 0;
            this.persianDateTimeBox1.Name = "persianDateTimeBox1";
            this.persianDateTimeBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.persianDateTimeBox1.Size = new System.Drawing.Size(100, 25);
            this.persianDateTimeBox1.TabIndex = 4;
            this.persianDateTimeBox1.Year = 0;
            // 
            // FRMRepayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 573);
            this.Controls.Add(this.LBLFinPay);
            this.Controls.Add(this.LBLPrePayPercent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconnedButton2);
            this.Controls.Add(this.TXTBXCalculate);
            this.Controls.Add(this.TXTBXNextPayValue);
            this.Controls.Add(this.TXTBXNextPayCount);
            this.Controls.Add(this.TXTBXPrePay);
            this.Controls.Add(this.TXTBXTotalPrice);
            this.Controls.Add(this.persianDateTimeBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTGPaymentProgram);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMRepayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "دفترچه تقسیط";
            ((System.ComponentModel.ISupportInitialize)(this.DTGPaymentProgram)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGPaymentProgram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private PersianDateTimeBox persianDateTimeBox1;
        private System.Windows.Forms.TextBox TXTBXTotalPrice;
        private System.Windows.Forms.TextBox TXTBXPrePay;
        private IconnedButton TXTBXCalculate;
        private IconnedButton iconnedButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTBXNextPayCount;
        private System.Windows.Forms.TextBox TXTBXNextPayValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LBLPrePayPercent;
        private System.Windows.Forms.Label LBLFinPay;
        private IconnedButton BTNCancell;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaiableValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekDayMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label LBLLastName;
        private System.Windows.Forms.Label LBLFirstName;
        private System.Windows.Forms.Label LBLFileID;
    }
}