namespace newLogin
{
    partial class FrmImage
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
            this.BtnImage = new System.Windows.Forms.Button();
            this.PicTry1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(62, 62);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(75, 36);
            this.BtnImage.TabIndex = 0;
            this.BtnImage.Text = "Image";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // PicTry1
            // 
            this.PicTry1.Location = new System.Drawing.Point(29, 121);
            this.PicTry1.Name = "PicTry1";
            this.PicTry1.Size = new System.Drawing.Size(425, 347);
            this.PicTry1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry1.TabIndex = 1;
            this.PicTry1.TabStop = false;
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 586);
            this.Controls.Add(this.PicTry1);
            this.Controls.Add(this.BtnImage);
            this.Name = "FrmImage";
            this.Text = "FrmImage";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.PictureBox PicTry1;
    }
}