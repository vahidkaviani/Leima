namespace DermaDent
{
    partial class FRMBotManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBotManager));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTNGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.persianDateTimeBox2 = new DermaDent.PersianDateTimeBox();
            this.persianDateTimeBox1 = new DermaDent.PersianDateTimeBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "119549458";
            // 
            // BTNGenerate
            // 
            this.BTNGenerate.Location = new System.Drawing.Point(224, 5);
            this.BTNGenerate.Name = "BTNGenerate";
            this.BTNGenerate.Size = new System.Drawing.Size(75, 23);
            this.BTNGenerate.TabIndex = 1;
            this.BTNGenerate.Text = "Generate";
            this.BTNGenerate.UseVisualStyleBackColor = true;
            this.BTNGenerate.Click += new System.EventHandler(this.BTNGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 1018);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Send To";
            // 
            // persianDateTimeBox2
            // 
            this.persianDateTimeBox2.BadFormat = false;
            this.persianDateTimeBox2.Day = 1;
            this.persianDateTimeBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.persianDateTimeBox2.Location = new System.Drawing.Point(503, 0);
            this.persianDateTimeBox2.Mask = "0000/00/00";
            this.persianDateTimeBox2.Month = 1;
            this.persianDateTimeBox2.Name = "persianDateTimeBox2";
            this.persianDateTimeBox2.Size = new System.Drawing.Size(100, 25);
            this.persianDateTimeBox2.TabIndex = 2;
            this.persianDateTimeBox2.Text = "13980101";
            this.persianDateTimeBox2.Year = 1398;
            // 
            // persianDateTimeBox1
            // 
            this.persianDateTimeBox1.BadFormat = false;
            this.persianDateTimeBox1.Day = 1;
            this.persianDateTimeBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.persianDateTimeBox1.Location = new System.Drawing.Point(368, 0);
            this.persianDateTimeBox1.Mask = "0000/00/00";
            this.persianDateTimeBox1.Month = 1;
            this.persianDateTimeBox1.Name = "persianDateTimeBox1";
            this.persianDateTimeBox1.Size = new System.Drawing.Size(100, 25);
            this.persianDateTimeBox1.TabIndex = 2;
            this.persianDateTimeBox1.Text = "13950101";
            this.persianDateTimeBox1.Year = 1395;
            // 
            // FRMBotManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 1042);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.persianDateTimeBox2);
            this.Controls.Add(this.persianDateTimeBox1);
            this.Controls.Add(this.BTNGenerate);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMBotManager";
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTNGenerate;
        private PersianDateTimeBox persianDateTimeBox1;
        private PersianDateTimeBox persianDateTimeBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}