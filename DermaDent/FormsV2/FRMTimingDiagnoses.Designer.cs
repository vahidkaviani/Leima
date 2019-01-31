namespace DermaDent.FormsV2
{
    partial class FRMTimingDiagnoses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMTimingDiagnoses));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBXDiagnosesName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ICOAdd = new DermaDent.IconnedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Info});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(447, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HandleMousClick);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "کد";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 35;
            // 
            // Info
            // 
            this.Info.DataPropertyName = "NameDiagnosis";
            this.Info.HeaderText = "عنوان";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 350;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد :";
            // 
            // TXTBXDiagnosesName
            // 
            this.TXTBXDiagnosesName.Location = new System.Drawing.Point(23, 54);
            this.TXTBXDiagnosesName.Name = "TXTBXDiagnosesName";
            this.TXTBXDiagnosesName.Size = new System.Drawing.Size(353, 21);
            this.TXTBXDiagnosesName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "توضیحات :";
            // 
            // ICOAdd
            // 
            this.ICOAdd.Image = global::DermaDent.Properties.Resources.Yes;
            this.ICOAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ICOAdd.Location = new System.Drawing.Point(12, 89);
            this.ICOAdd.Name = "ICOAdd";
            this.ICOAdd.Size = new System.Drawing.Size(86, 32);
            this.ICOAdd.TabIndex = 3;
            this.ICOAdd.Text = "افزودن";
            this.ICOAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICOAdd.UseVisualStyleBackColor = true;
            this.ICOAdd.Click += new System.EventHandler(this.ICOAdd_Click);
            // 
            // FRMTimingDiagnoses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 407);
            this.Controls.Add(this.ICOAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBXDiagnosesName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMTimingDiagnoses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "عناوین وقت دهی";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBXDiagnosesName;
        private System.Windows.Forms.Label label2;
        private IconnedButton ICOAdd;
    }
}