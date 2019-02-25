namespace DermaDent.FormsV2
{
    partial class FRMSMSTemplate
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
            this.TXBXTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXBXOutPutNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNSaveChanges = new System.Windows.Forms.Button();
            this.LBLSampleText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXBXUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXBXPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXBXTemplate
            // 
            this.TXBXTemplate.Location = new System.Drawing.Point(12, 129);
            this.TXBXTemplate.Multiline = true;
            this.TXBXTemplate.Name = "TXBXTemplate";
            this.TXBXTemplate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXBXTemplate.Size = new System.Drawing.Size(237, 102);
            this.TXBXTemplate.TabIndex = 0;
            this.TXBXTemplate.TextChanged += new System.EventHandler(this.ReviewTemplate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 166);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "قالب پیام";
            // 
            // TXBXOutPutNo
            // 
            this.TXBXOutPutNo.Location = new System.Drawing.Point(12, 39);
            this.TXBXOutPutNo.Name = "TXBXOutPutNo";
            this.TXBXOutPutNo.Size = new System.Drawing.Size(237, 21);
            this.TXBXOutPutNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 42);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ارسال از شماره";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "نمونه پیام";
            // 
            // BTNSaveChanges
            // 
            this.BTNSaveChanges.Location = new System.Drawing.Point(174, 367);
            this.BTNSaveChanges.Name = "BTNSaveChanges";
            this.BTNSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.BTNSaveChanges.TabIndex = 4;
            this.BTNSaveChanges.Text = "ذخیره";
            this.BTNSaveChanges.UseVisualStyleBackColor = true;
            this.BTNSaveChanges.Click += new System.EventHandler(this.BTNSaveChanges_Click);
            // 
            // LBLSampleText
            // 
            this.LBLSampleText.Location = new System.Drawing.Point(12, 237);
            this.LBLSampleText.Multiline = true;
            this.LBLSampleText.Name = "LBLSampleText";
            this.LBLSampleText.ReadOnly = true;
            this.LBLSampleText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LBLSampleText.Size = new System.Drawing.Size(237, 124);
            this.LBLSampleText.TabIndex = 0;
            this.LBLSampleText.TextChanged += new System.EventHandler(this.ReviewTemplate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 69);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "نام کاربری";
            // 
            // TXBXUserName
            // 
            this.TXBXUserName.Location = new System.Drawing.Point(12, 66);
            this.TXBXUserName.Name = "TXBXUserName";
            this.TXBXUserName.Size = new System.Drawing.Size(237, 21);
            this.TXBXUserName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 96);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "کلمه عبور";
            // 
            // TXBXPassword
            // 
            this.TXBXPassword.Location = new System.Drawing.Point(12, 93);
            this.TXBXPassword.Name = "TXBXPassword";
            this.TXBXPassword.Size = new System.Drawing.Size(237, 21);
            this.TXBXPassword.TabIndex = 2;
            this.TXBXPassword.UseSystemPasswordChar = true;
            // 
            // FRMSMSTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 401);
            this.Controls.Add(this.BTNSaveChanges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXBXPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXBXUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXBXOutPutNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLSampleText);
            this.Controls.Add(this.TXBXTemplate);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FRMSMSTemplate";
            this.Text = "تنظیمات متن پیامک";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBXTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXBXOutPutNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNSaveChanges;
        private System.Windows.Forms.TextBox LBLSampleText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXBXUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXBXPassword;
    }
}