namespace newLogin
{
    partial class FrmRandom
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnNumber = new System.Windows.Forms.Button();
            this.BtnBackRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(164, 62);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(423, 55);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate Random Color";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnNumber
            // 
            this.BtnNumber.Location = new System.Drawing.Point(74, 309);
            this.BtnNumber.Name = "BtnNumber";
            this.BtnNumber.Size = new System.Drawing.Size(284, 76);
            this.BtnNumber.TabIndex = 1;
            this.BtnNumber.Text = "Random Number";
            this.BtnNumber.UseVisualStyleBackColor = true;
            this.BtnNumber.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // BtnBackRandom
            // 
            this.BtnBackRandom.Location = new System.Drawing.Point(603, 327);
            this.BtnBackRandom.Name = "BtnBackRandom";
            this.BtnBackRandom.Size = new System.Drawing.Size(110, 58);
            this.BtnBackRandom.TabIndex = 2;
            this.BtnBackRandom.Text = "Back";
            this.BtnBackRandom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "r-g-b";
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBackRandom);
            this.Controls.Add(this.BtnNumber);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "FrmRandom";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnNumber;
        private System.Windows.Forms.Button BtnBackRandom;
        private System.Windows.Forms.Label label1;
    }
}