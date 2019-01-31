namespace DermaDent
{
    partial class timeFilter
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
            this.persianDateTimeBox1 = new DermaDent.PersianDateTimeBox();
            this.persianDateTimeBox2 = new DermaDent.PersianDateTimeBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GRPBXTime = new System.Windows.Forms.GroupBox();
            this.RDIBTNTime = new System.Windows.Forms.RadioButton();
            this.RDIBTNToday = new System.Windows.Forms.RadioButton();
            this.GRPBXTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // persianDateTimeBox1
            // 
            this.persianDateTimeBox1.BadFormat = false;
            this.persianDateTimeBox1.Day = 0;
            this.persianDateTimeBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.persianDateTimeBox1.Location = new System.Drawing.Point(133, 16);
            this.persianDateTimeBox1.Mask = "0000/00/00";
            this.persianDateTimeBox1.Month = 0;
            this.persianDateTimeBox1.Name = "persianDateTimeBox1";
            this.persianDateTimeBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.persianDateTimeBox1.Size = new System.Drawing.Size(100, 25);
            this.persianDateTimeBox1.TabIndex = 0;
            this.persianDateTimeBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.persianDateTimeBox1.Year = 0;
            // 
            // persianDateTimeBox2
            // 
            this.persianDateTimeBox2.BadFormat = false;
            this.persianDateTimeBox2.Day = 0;
            this.persianDateTimeBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.persianDateTimeBox2.Location = new System.Drawing.Point(133, 67);
            this.persianDateTimeBox2.Mask = "0000/00/00";
            this.persianDateTimeBox2.Month = 0;
            this.persianDateTimeBox2.Name = "persianDateTimeBox2";
            this.persianDateTimeBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.persianDateTimeBox2.Size = new System.Drawing.Size(100, 25);
            this.persianDateTimeBox2.TabIndex = 1;
            this.persianDateTimeBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.persianDateTimeBox2.Year = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "از  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "الی :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(10, 20);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(38, 21);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(10, 71);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(38, 21);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ساعت :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "الی ساعت  :";
            // 
            // GRPBXTime
            // 
            this.GRPBXTime.Controls.Add(this.maskedTextBox1);
            this.GRPBXTime.Controls.Add(this.maskedTextBox2);
            this.GRPBXTime.Controls.Add(this.persianDateTimeBox1);
            this.GRPBXTime.Controls.Add(this.persianDateTimeBox2);
            this.GRPBXTime.Controls.Add(this.label4);
            this.GRPBXTime.Controls.Add(this.label1);
            this.GRPBXTime.Controls.Add(this.label2);
            this.GRPBXTime.Controls.Add(this.label3);
            this.GRPBXTime.Enabled = false;
            this.GRPBXTime.Location = new System.Drawing.Point(13, 3);
            this.GRPBXTime.Name = "GRPBXTime";
            this.GRPBXTime.Size = new System.Drawing.Size(301, 100);
            this.GRPBXTime.TabIndex = 4;
            this.GRPBXTime.TabStop = false;
            this.GRPBXTime.Text = "زمان";
            // 
            // RDIBTNTime
            // 
            this.RDIBTNTime.AutoSize = true;
            this.RDIBTNTime.Location = new System.Drawing.Point(338, 19);
            this.RDIBTNTime.Name = "RDIBTNTime";
            this.RDIBTNTime.Size = new System.Drawing.Size(70, 17);
            this.RDIBTNTime.TabIndex = 5;
            this.RDIBTNTime.Text = "بازه زمانی";
            this.RDIBTNTime.UseVisualStyleBackColor = true;
            this.RDIBTNTime.CheckedChanged += new System.EventHandler(this.RDIBTNTime_CheckedChanged);
            // 
            // RDIBTNToday
            // 
            this.RDIBTNToday.AutoSize = true;
            this.RDIBTNToday.Checked = true;
            this.RDIBTNToday.Location = new System.Drawing.Point(360, 54);
            this.RDIBTNToday.Name = "RDIBTNToday";
            this.RDIBTNToday.Size = new System.Drawing.Size(48, 17);
            this.RDIBTNToday.TabIndex = 6;
            this.RDIBTNToday.TabStop = true;
            this.RDIBTNToday.Text = "امروز";
            this.RDIBTNToday.UseVisualStyleBackColor = true;
            // 
            // timeFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RDIBTNToday);
            this.Controls.Add(this.RDIBTNTime);
            this.Controls.Add(this.GRPBXTime);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "timeFilter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(435, 126);
            this.GRPBXTime.ResumeLayout(false);
            this.GRPBXTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersianDateTimeBox persianDateTimeBox1;
        private PersianDateTimeBox persianDateTimeBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GRPBXTime;
        private System.Windows.Forms.RadioButton RDIBTNTime;
        private System.Windows.Forms.RadioButton RDIBTNToday;
    }
}
