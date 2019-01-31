namespace DermaDent
{
    partial class CMPRefer
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMNAllCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorNameComboBox1 = new DermaDent.DoctorNameComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(244, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row,
            this.CLMPatientName,
            this.CLMNAllCorrect});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(280, 160);
            this.dataGridView1.TabIndex = 2;
            // 
            // row
            // 
            this.row.HeaderText = "ردیف";
            this.row.Name = "row";
            this.row.Width = 35;
            // 
            // CLMPatientName
            // 
            this.CLMPatientName.HeaderText = "نام بیمار";
            this.CLMPatientName.Name = "CLMPatientName";
            this.CLMPatientName.Width = 180;
            // 
            // CLMNAllCorrect
            // 
            this.CLMNAllCorrect.HeaderText = "ok";
            this.CLMNAllCorrect.Name = "CLMNAllCorrect";
            this.CLMNAllCorrect.Width = 30;
            // 
            // doctorNameComboBox1
            // 
            this.doctorNameComboBox1.FormattingEnabled = true;
            this.doctorNameComboBox1.Location = new System.Drawing.Point(13, 6);
            this.doctorNameComboBox1.Name = "doctorNameComboBox1";
            this.doctorNameComboBox1.Size = new System.Drawing.Size(225, 21);
            this.doctorNameComboBox1.TabIndex = 3;
            // 
            // CMPRefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doctorNameComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CMPRefer";
            this.Size = new System.Drawing.Size(280, 195);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn row;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMNAllCorrect;
        private DoctorNameComboBox doctorNameComboBox1;
    }
}
