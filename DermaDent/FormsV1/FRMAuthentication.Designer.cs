namespace DermaDent
{
    partial class FRMAuthentication
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
            this.TXTBXUserName = new System.Windows.Forms.TextBox();
            this.TXTBXPassword = new System.Windows.Forms.TextBox();
            this.BTNLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTBXUserName
            // 
            this.TXTBXUserName.Location = new System.Drawing.Point(8, 51);
            this.TXTBXUserName.Name = "TXTBXUserName";
            this.TXTBXUserName.Size = new System.Drawing.Size(100, 21);
            this.TXTBXUserName.TabIndex = 0;
            this.TXTBXUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXUserName_KeyPress);
            // 
            // TXTBXPassword
            // 
            this.TXTBXPassword.Location = new System.Drawing.Point(8, 87);
            this.TXTBXPassword.Name = "TXTBXPassword";
            this.TXTBXPassword.Size = new System.Drawing.Size(100, 21);
            this.TXTBXPassword.TabIndex = 1;
            this.TXTBXPassword.UseSystemPasswordChar = true;
            this.TXTBXPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXPassword_KeyPress);
            // 
            // BTNLogin
            // 
            this.BTNLogin.Location = new System.Drawing.Point(33, 126);
            this.BTNLogin.Name = "BTNLogin";
            this.BTNLogin.Size = new System.Drawing.Size(75, 23);
            this.BTNLogin.TabIndex = 3;
            this.BTNLogin.Text = "ورود";
            this.BTNLogin.UseVisualStyleBackColor = true;
            this.BTNLogin.Click += new System.EventHandler(this.BTNLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(114, 54);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام کاربر :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(114, 87);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "کلمه عبور :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DermaDent.Properties.Resources.ezgif_4_4279502b0c;
            this.pictureBox1.Location = new System.Drawing.Point(192, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FRMAuthentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TXTBXPassword);
            this.Controls.Add(this.TXTBXUserName);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FRMAuthentication";
            this.Text = "Solident Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBXUserName;
        private System.Windows.Forms.TextBox TXTBXPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}