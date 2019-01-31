namespace marlie.TumbnailDotnet
{
    partial class ImageDialog
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
            this.BTNNext = new System.Windows.Forms.Button();
            this.BTNPrevious = new System.Windows.Forms.Button();
            this.imageViewerFull = new marlie.TumbnailDotnet.ImageViewer();
            this.SuspendLayout();
            // 
            // BTNNext
            // 
            this.BTNNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTNNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNNext.Location = new System.Drawing.Point(441, 585);
            this.BTNNext.Name = "BTNNext";
            this.BTNNext.Size = new System.Drawing.Size(42, 24);
            this.BTNNext.TabIndex = 1;
            this.BTNNext.Text = ">";
            this.BTNNext.UseVisualStyleBackColor = true;
            this.BTNNext.Click += new System.EventHandler(this.BTNNext_Click);
            // 
            // BTNPrevious
            // 
            this.BTNPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTNPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNPrevious.Location = new System.Drawing.Point(371, 585);
            this.BTNPrevious.Name = "BTNPrevious";
            this.BTNPrevious.Size = new System.Drawing.Size(42, 24);
            this.BTNPrevious.TabIndex = 1;
            this.BTNPrevious.Text = "<";
            this.BTNPrevious.UseVisualStyleBackColor = true;
            this.BTNPrevious.Click += new System.EventHandler(this.BTNPrevious_Click);
            // 
            // imageViewerFull
            // 
            this.imageViewerFull.AutoSize = true;
            this.imageViewerFull.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageViewerFull.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.imageViewerFull.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageViewerFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewerFull.Image = null;
            this.imageViewerFull.ImageLocation = null;
            this.imageViewerFull.IsActive = false;
            this.imageViewerFull.IsThumbnail = false;
            this.imageViewerFull.Location = new System.Drawing.Point(0, 0);
            this.imageViewerFull.Margin = new System.Windows.Forms.Padding(3, 3, 3, 256);
            this.imageViewerFull.Name = "imageViewerFull";
            this.imageViewerFull.Padding = new System.Windows.Forms.Padding(0, 0, 0, 512);
            this.imageViewerFull.Size = new System.Drawing.Size(850, 610);
            this.imageViewerFull.TabIndex = 0;
            this.imageViewerFull.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageViewerFull_KeyDown);
            this.imageViewerFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManagePics);
            this.imageViewerFull.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.imageViewerFull_PreviewKeyDown);
            // 
            // ImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 610);
            this.Controls.Add(this.BTNPrevious);
            this.Controls.Add(this.BTNNext);
            this.Controls.Add(this.imageViewerFull);
            this.Name = "ImageDialog";
            this.ShowIcon = false;
            this.Text = "Image Viewer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ManagePics);
            this.Resize += new System.EventHandler(this.ImageDialog_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageViewer imageViewerFull;
        private System.Windows.Forms.Button BTNNext;
        private System.Windows.Forms.Button BTNPrevious;
    }
}