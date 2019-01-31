namespace DermaDent
{
    partial class CurrentDateTimePersian
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
            this.components = new System.ComponentModel.Container();
            this.LBLDate = new System.Windows.Forms.Label();
            this.LBLTime = new System.Windows.Forms.Label();
            this.LBLDayOfWeek = new System.Windows.Forms.Label();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLDate
            // 
            this.LBLDate.AutoSize = true;
            this.LBLDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LBLDate.Location = new System.Drawing.Point(6, 43);
            this.LBLDate.Name = "LBLDate";
            this.LBLDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLDate.Size = new System.Drawing.Size(63, 13);
            this.LBLDate.TabIndex = 0;
            this.LBLDate.Text = "1396/03/31";
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LBLTime.Location = new System.Drawing.Point(21, 69);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLTime.Size = new System.Drawing.Size(35, 13);
            this.LBLTime.TabIndex = 0;
            this.LBLTime.Text = "18:35";
            // 
            // LBLDayOfWeek
            // 
            this.LBLDayOfWeek.AutoSize = true;
            this.LBLDayOfWeek.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.LBLDayOfWeek.Location = new System.Drawing.Point(11, 17);
            this.LBLDayOfWeek.Name = "LBLDayOfWeek";
            this.LBLDayOfWeek.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLDayOfWeek.Size = new System.Drawing.Size(52, 13);
            this.LBLDayOfWeek.TabIndex = 1;
            this.LBLDayOfWeek.Text = "چهارشنبه";
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 60000;
            this.Updater.Tick += new System.EventHandler(this.Updater_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLTime);
            this.groupBox1.Controls.Add(this.LBLDate);
            this.groupBox1.Controls.Add(this.LBLDayOfWeek);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(81, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "زمان :";
            // 
            // CurrentDateTimePersian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CurrentDateTimePersian";
            this.Size = new System.Drawing.Size(91, 93);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LBLDate;
        private System.Windows.Forms.Label LBLTime;
        private System.Windows.Forms.Label LBLDayOfWeek;
        private System.Windows.Forms.Timer Updater;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
