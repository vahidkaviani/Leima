namespace DermaDent
{
    partial class FRMEditUserProfile
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
            this.BTNLoadInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNSaveChanges = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CHKBOXEditMode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.patientRegisterControl1 = new DermaDent.PatientRegisterControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNLoadInfo
            // 
            this.BTNLoadInfo.Location = new System.Drawing.Point(468, 9);
            this.BTNLoadInfo.Name = "BTNLoadInfo";
            this.BTNLoadInfo.Size = new System.Drawing.Size(100, 20);
            this.BTNLoadInfo.TabIndex = 1;
            this.BTNLoadInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(574, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "شماره پرونده بیمار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(31, 11);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(431, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "برای اصلاح اطلاعات پرونده بیما شماره پرونده مربوطه را وارد کرده و سپس دکمه Enter " +
    "را بزنید ";
            // 
            // BTNSaveChanges
            // 
            this.BTNSaveChanges.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BTNSaveChanges.Location = new System.Drawing.Point(530, 192);
            this.BTNSaveChanges.Name = "BTNSaveChanges";
            this.BTNSaveChanges.Size = new System.Drawing.Size(91, 26);
            this.BTNSaveChanges.TabIndex = 3;
            this.BTNSaveChanges.Text = "ثبت پرونده";
            this.BTNSaveChanges.UseVisualStyleBackColor = true;
            this.BTNSaveChanges.Click += new System.EventHandler(this.BTNSaveChanges_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(243, 199);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(281, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "توجه: برای اعمال تغییرات قبل از خروج دکمه ذخیره را بزنید!!!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(601, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // CHKBOXEditMode
            // 
            this.CHKBOXEditMode.AutoSize = true;
            this.CHKBOXEditMode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CHKBOXEditMode.Location = new System.Drawing.Point(667, 11);
            this.CHKBOXEditMode.Name = "CHKBOXEditMode";
            this.CHKBOXEditMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CHKBOXEditMode.Size = new System.Drawing.Size(53, 17);
            this.CHKBOXEditMode.TabIndex = 5;
            this.CHKBOXEditMode.Text = "اصلاح";
            this.CHKBOXEditMode.UseVisualStyleBackColor = true;
            this.CHKBOXEditMode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTNLoadInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(667, 30);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(111, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientRegisterControl1
            // 
            this.patientRegisterControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.patientRegisterControl1.Location = new System.Drawing.Point(1, 47);
            this.patientRegisterControl1.Name = "patientRegisterControl1";
            this.patientRegisterControl1.Size = new System.Drawing.Size(728, 148);
            this.patientRegisterControl1.TabIndex = 0;
            // 
            // FRMEditUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 223);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CHKBOXEditMode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNSaveChanges);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientRegisterControl1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FRMEditUserProfile";
            this.Text = "EditUserProfile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PatientRegisterControl patientRegisterControl1;
        private System.Windows.Forms.TextBox BTNLoadInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNSaveChanges;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CHKBOXEditMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}