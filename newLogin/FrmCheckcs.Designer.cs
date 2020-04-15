namespace newLogin
{
    partial class FrmCheckcs
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBackCheck = new System.Windows.Forms.Button();
            this.chkDounat = new System.Windows.Forms.CheckBox();
            this.Chkcoffe = new System.Windows.Forms.CheckBox();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(47, 57);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 48);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnBackCheck
            // 
            this.BtnBackCheck.Location = new System.Drawing.Point(552, 290);
            this.BtnBackCheck.Name = "BtnBackCheck";
            this.BtnBackCheck.Size = new System.Drawing.Size(75, 37);
            this.BtnBackCheck.TabIndex = 4;
            this.BtnBackCheck.Text = "Back";
            this.BtnBackCheck.UseVisualStyleBackColor = true;
            // 
            // chkDounat
            // 
            this.chkDounat.AutoSize = true;
            this.chkDounat.Location = new System.Drawing.Point(47, 197);
            this.chkDounat.Name = "chkDounat";
            this.chkDounat.Size = new System.Drawing.Size(79, 24);
            this.chkDounat.TabIndex = 5;
            this.chkDounat.Text = "Dount";
            this.chkDounat.UseVisualStyleBackColor = true;
            // 
            // Chkcoffe
            // 
            this.Chkcoffe.AutoSize = true;
            this.Chkcoffe.Location = new System.Drawing.Point(47, 136);
            this.Chkcoffe.Name = "Chkcoffe";
            this.Chkcoffe.Size = new System.Drawing.Size(83, 24);
            this.Chkcoffe.TabIndex = 6;
            this.Chkcoffe.Text = "Coffee";
            this.Chkcoffe.UseVisualStyleBackColor = true;
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Location = new System.Drawing.Point(47, 275);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(92, 24);
            this.chkBrownie.TabIndex = 7;
            this.chkBrownie.Text = "Brownie";
            this.chkBrownie.UseVisualStyleBackColor = true;
            // 
            // FrmCheckcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkBrownie);
            this.Controls.Add(this.Chkcoffe);
            this.Controls.Add(this.chkDounat);
            this.Controls.Add(this.BtnBackCheck);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheckcs";
            this.Text = "FrmCheckcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBackCheck;
        private System.Windows.Forms.CheckBox chkDounat;
        private System.Windows.Forms.CheckBox Chkcoffe;
        private System.Windows.Forms.CheckBox chkBrownie;
    }
}