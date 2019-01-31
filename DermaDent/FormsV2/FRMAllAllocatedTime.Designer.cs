namespace DermaDent
{
    partial class FRMAllAllocatedTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAllAllocatedTime));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TXTBXID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.persianDateTimeBox2 = new DermaDent.PersianDateTimeBox();
            this.persianDateTimeBox1 = new DermaDent.PersianDateTimeBox();
            this.BTNICClose = new DermaDent.IconnedButton();
            this.BTNICExportToExcel = new DermaDent.IconnedButton();
            this.iconnedButton3 = new DermaDent.IconnedButton();
            this.iconnedButton2 = new DermaDent.IconnedButton();
            this.iconnedButton1 = new DermaDent.IconnedButton();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowId,
            this.Column6,
            this.Patient,
            this.Column4,
            this.Column5,
            this.Status,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(769, 350);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(718, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "از تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(591, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "لغایت :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(466, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "نتیجه :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(252, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "نام خانوادگی :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(252, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "نام :";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(339, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.TXTBXID);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.persianDateTimeBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.persianDateTimeBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 95);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(297, 69);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(163, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "نمایش شماره پرونده‌های صفر";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(330, 47);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(130, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "نمایش وقت های خالی";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(134, 21);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(146, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // TXTBXID
            // 
            this.TXTBXID.Location = new System.Drawing.Point(591, 67);
            this.TXTBXID.Name = "TXTBXID";
            this.TXTBXID.Size = new System.Drawing.Size(100, 21);
            this.TXTBXID.TabIndex = 9;
            this.TXTBXID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBXID_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(146, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(697, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "شماره پرونده :";
            // 
            // persianDateTimeBox2
            // 
            this.persianDateTimeBox2.BadFormat = false;
            this.persianDateTimeBox2.Day = 0;
            this.persianDateTimeBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianDateTimeBox2.Location = new System.Drawing.Point(513, 20);
            this.persianDateTimeBox2.Mask = "0000/00/00";
            this.persianDateTimeBox2.Month = 0;
            this.persianDateTimeBox2.Name = "persianDateTimeBox2";
            this.persianDateTimeBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.persianDateTimeBox2.Size = new System.Drawing.Size(72, 22);
            this.persianDateTimeBox2.TabIndex = 7;
            this.persianDateTimeBox2.Year = 0;
            // 
            // persianDateTimeBox1
            // 
            this.persianDateTimeBox1.BadFormat = false;
            this.persianDateTimeBox1.Day = 0;
            this.persianDateTimeBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianDateTimeBox1.Location = new System.Drawing.Point(640, 20);
            this.persianDateTimeBox1.Mask = "0000/00/00";
            this.persianDateTimeBox1.Month = 0;
            this.persianDateTimeBox1.Name = "persianDateTimeBox1";
            this.persianDateTimeBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.persianDateTimeBox1.Size = new System.Drawing.Size(72, 22);
            this.persianDateTimeBox1.TabIndex = 7;
            this.persianDateTimeBox1.Year = 0;
            // 
            // BTNICClose
            // 
            this.BTNICClose.Image = global::DermaDent.Properties.Resources.icons8_close_window_24;
            this.BTNICClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNICClose.Location = new System.Drawing.Point(12, 12);
            this.BTNICClose.Name = "BTNICClose";
            this.BTNICClose.Size = new System.Drawing.Size(79, 32);
            this.BTNICClose.TabIndex = 0;
            this.BTNICClose.Text = "خروج";
            this.BTNICClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNICClose.UseVisualStyleBackColor = true;
            this.BTNICClose.Click += new System.EventHandler(this.BTNICClose_Click);
            // 
            // BTNICExportToExcel
            // 
            this.BTNICExportToExcel.Image = global::DermaDent.Properties.Resources.icons8_microsoft_excel_24;
            this.BTNICExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNICExportToExcel.Location = new System.Drawing.Point(222, 12);
            this.BTNICExportToExcel.Name = "BTNICExportToExcel";
            this.BTNICExportToExcel.Size = new System.Drawing.Size(113, 32);
            this.BTNICExportToExcel.TabIndex = 0;
            this.BTNICExportToExcel.Text = "ارسال به اکسل";
            this.BTNICExportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNICExportToExcel.UseVisualStyleBackColor = true;
            this.BTNICExportToExcel.Click += new System.EventHandler(this.iconnedButton4_Click);
            // 
            // iconnedButton3
            // 
            this.iconnedButton3.Image = global::DermaDent.Properties.Resources.icons8_print_24;
            this.iconnedButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconnedButton3.Location = new System.Drawing.Point(409, 12);
            this.iconnedButton3.Name = "iconnedButton3";
            this.iconnedButton3.Size = new System.Drawing.Size(87, 32);
            this.iconnedButton3.TabIndex = 0;
            this.iconnedButton3.Text = "چاپ (2)";
            this.iconnedButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconnedButton3.UseVisualStyleBackColor = true;
            this.iconnedButton3.Visible = false;
            // 
            // iconnedButton2
            // 
            this.iconnedButton2.Image = global::DermaDent.Properties.Resources.icons8_send_to_printer_24;
            this.iconnedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconnedButton2.Location = new System.Drawing.Point(549, 12);
            this.iconnedButton2.Name = "iconnedButton2";
            this.iconnedButton2.Size = new System.Drawing.Size(72, 32);
            this.iconnedButton2.TabIndex = 0;
            this.iconnedButton2.Text = "چاپ";
            this.iconnedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconnedButton2.UseVisualStyleBackColor = true;
            this.iconnedButton2.Click += new System.EventHandler(this.iconnedButton2_Click);
            // 
            // iconnedButton1
            // 
            this.iconnedButton1.Image = global::DermaDent.Properties.Resources.icons8_check_file_24;
            this.iconnedButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconnedButton1.Location = new System.Drawing.Point(691, 12);
            this.iconnedButton1.Name = "iconnedButton1";
            this.iconnedButton1.Size = new System.Drawing.Size(72, 32);
            this.iconnedButton1.TabIndex = 0;
            this.iconnedButton1.Text = "تایید";
            this.iconnedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconnedButton1.UseVisualStyleBackColor = true;
            // 
            // RowId
            // 
            this.RowId.DataPropertyName = "id";
            this.RowId.HeaderText = "ردیف";
            this.RowId.Name = "RowId";
            this.RowId.ReadOnly = true;
            this.RowId.Width = 35;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Dentist";
            this.Column6.HeaderText = "نام پزشک معالج";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Patient
            // 
            this.Patient.DataPropertyName = "Patient";
            this.Patient.HeaderText = "بیمار";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            this.Patient.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tarikh";
            this.Column4.HeaderText = "تاریخ نوبت";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Time";
            this.Column5.HeaderText = "ساعت";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "نتیجه";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "کاربر";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.HeaderText = "9";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 40;
            // 
            // Column9
            // 
            this.Column9.HeaderText = ";";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 40;
            // 
            // Column10
            // 
            this.Column10.HeaderText = ":";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 40;
            // 
            // FRMAllAllocatedTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNICClose);
            this.Controls.Add(this.BTNICExportToExcel);
            this.Controls.Add(this.iconnedButton3);
            this.Controls.Add(this.iconnedButton2);
            this.Controls.Add(this.iconnedButton1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMAllAllocatedTime";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تاریخچه کل نوبت های یک بیمار";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private IconnedButton iconnedButton1;
        private IconnedButton iconnedButton2;
        private IconnedButton iconnedButton3;
        private IconnedButton BTNICExportToExcel;
        private IconnedButton BTNICClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private PersianDateTimeBox persianDateTimeBox1;
        private PersianDateTimeBox persianDateTimeBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox TXTBXID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}