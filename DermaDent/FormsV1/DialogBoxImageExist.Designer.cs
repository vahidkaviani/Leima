namespace DermaDent
{
    partial class DialogBoxImageExist
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTNReplace = new System.Windows.Forms.Button();
            this.BTNSkip = new System.Windows.Forms.Button();
            this.BTNKeepBoth = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageViewer2 = new marlie.TumbnailDotnet.ImageViewer();
            this.imageViewer1 = new marlie.TumbnailDotnet.ImageViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "تصویری با نام \"فلا\" از قبل در پرونده بیمار موجود می باشد";
            // 
            // BTNReplace
            // 
            this.BTNReplace.Location = new System.Drawing.Point(56, 51);
            this.BTNReplace.Name = "BTNReplace";
            this.BTNReplace.Size = new System.Drawing.Size(95, 23);
            this.BTNReplace.TabIndex = 2;
            this.BTNReplace.Text = "جایگزین";
            this.BTNReplace.UseVisualStyleBackColor = true;
            this.BTNReplace.Click += new System.EventHandler(this.BTNReplace_Click);
            // 
            // BTNSkip
            // 
            this.BTNSkip.Location = new System.Drawing.Point(56, 85);
            this.BTNSkip.Name = "BTNSkip";
            this.BTNSkip.Size = new System.Drawing.Size(95, 23);
            this.BTNSkip.TabIndex = 2;
            this.BTNSkip.Text = "بگذر";
            this.BTNSkip.UseVisualStyleBackColor = true;
            this.BTNSkip.Click += new System.EventHandler(this.BTNSkip_Click);
            // 
            // BTNKeepBoth
            // 
            this.BTNKeepBoth.Location = new System.Drawing.Point(56, 119);
            this.BTNKeepBoth.Name = "BTNKeepBoth";
            this.BTNKeepBoth.Size = new System.Drawing.Size(95, 23);
            this.BTNKeepBoth.TabIndex = 2;
            this.BTNKeepBoth.Text = "حفظ هر دو فایل با تغییر نام";
            this.BTNKeepBoth.UseVisualStyleBackColor = true;
            this.BTNKeepBoth.Click += new System.EventHandler(this.BTNKeepBoth_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(56, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "برای بقیه عکس ها همین کار رو بکن";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "فایل قبلی ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "فایل جدید ->";
            // 
            // imageViewer2
            // 
            this.imageViewer2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.imageViewer2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageViewer2.Image = null;
            this.imageViewer2.ImageLocation = null;
            this.imageViewer2.IsActive = false;
            this.imageViewer2.IsThumbnail = false;
            this.imageViewer2.Location = new System.Drawing.Point(358, 99);
            this.imageViewer2.Name = "imageViewer2";
            this.imageViewer2.Size = new System.Drawing.Size(92, 92);
            this.imageViewer2.TabIndex = 0;
            // 
            // imageViewer1
            // 
            this.imageViewer1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.imageViewer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageViewer1.Image = null;
            this.imageViewer1.ImageLocation = null;
            this.imageViewer1.IsActive = false;
            this.imageViewer1.IsThumbnail = false;
            this.imageViewer1.Location = new System.Drawing.Point(358, 3);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.Size = new System.Drawing.Size(92, 92);
            this.imageViewer1.TabIndex = 0;
            // 
            // DialogBoxImageExist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 195);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BTNKeepBoth);
            this.Controls.Add(this.BTNSkip);
            this.Controls.Add(this.BTNReplace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageViewer2);
            this.Controls.Add(this.imageViewer1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogBoxImageExist";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "           !!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private marlie.TumbnailDotnet.ImageViewer imageViewer1;
        private marlie.TumbnailDotnet.ImageViewer imageViewer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNReplace;
        private System.Windows.Forms.Button BTNSkip;
        private System.Windows.Forms.Button BTNKeepBoth;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}