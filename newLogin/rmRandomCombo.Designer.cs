namespace newLogin
{
    partial class rmRandomCombo
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
            this.CmbRandom1 = new System.Windows.Forms.ComboBox();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.RdoGrater500 = new System.Windows.Forms.RadioButton();
            this.RdoLess500 = new System.Windows.Forms.RadioButton();
            this.BtnGenrate1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RdoGrater50 = new System.Windows.Forms.RadioButton();
            this.RdoLess50 = new System.Windows.Forms.RadioButton();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.BtnGenrate2 = new System.Windows.Forms.Button();
            this.Btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmbRandom1
            // 
            this.CmbRandom1.FormattingEnabled = true;
            this.CmbRandom1.Location = new System.Drawing.Point(6, 76);
            this.CmbRandom1.Name = "CmbRandom1";
            this.CmbRandom1.Size = new System.Drawing.Size(121, 28);
            this.CmbRandom1.TabIndex = 0;
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(25, 48);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(121, 28);
            this.CmbRandom2.TabIndex = 1;
            this.CmbRandom2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset1);
            this.groupBox1.Controls.Add(this.RdoGrater500);
            this.groupBox1.Controls.Add(this.RdoLess500);
            this.groupBox1.Controls.Add(this.BtnGenrate1);
            this.groupBox1.Controls.Add(this.CmbRandom1);
            this.groupBox1.Location = new System.Drawing.Point(62, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(72, 187);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(75, 34);
            this.BtnReset1.TabIndex = 4;
            this.BtnReset1.Text = "reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // RdoGrater500
            // 
            this.RdoGrater500.AutoSize = true;
            this.RdoGrater500.Location = new System.Drawing.Point(109, 149);
            this.RdoGrater500.Name = "RdoGrater500";
            this.RdoGrater500.Size = new System.Drawing.Size(156, 24);
            this.RdoGrater500.TabIndex = 3;
            this.RdoGrater500.TabStop = true;
            this.RdoGrater500.Text = "Greater than 500";
            this.RdoGrater500.UseVisualStyleBackColor = true;
            // 
            // RdoLess500
            // 
            this.RdoLess500.AutoSize = true;
            this.RdoLess500.Location = new System.Drawing.Point(109, 119);
            this.RdoLess500.Name = "RdoLess500";
            this.RdoLess500.Size = new System.Drawing.Size(135, 24);
            this.RdoLess500.TabIndex = 2;
            this.RdoLess500.TabStop = true;
            this.RdoLess500.Text = "Less than 500";
            this.RdoLess500.UseVisualStyleBackColor = true;
            this.RdoLess500.CheckedChanged += new System.EventHandler(this.RdoLess500_CheckedChanged);
            // 
            // BtnGenrate1
            // 
            this.BtnGenrate1.Location = new System.Drawing.Point(189, 76);
            this.BtnGenrate1.Name = "BtnGenrate1";
            this.BtnGenrate1.Size = new System.Drawing.Size(97, 37);
            this.BtnGenrate1.TabIndex = 1;
            this.BtnGenrate1.Text = "Generate";
            this.BtnGenrate1.UseVisualStyleBackColor = true;
            this.BtnGenrate1.Click += new System.EventHandler(this.BtnGenrate1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.RdoGrater50);
            this.groupBox2.Controls.Add(this.RdoLess50);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.BtnGenrate2);
            this.groupBox2.Controls.Add(this.CmbRandom2);
            this.groupBox2.Location = new System.Drawing.Point(391, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 199);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "count";
            // 
            // RdoGrater50
            // 
            this.RdoGrater50.AutoSize = true;
            this.RdoGrater50.Location = new System.Drawing.Point(104, 112);
            this.RdoGrater50.Name = "RdoGrater50";
            this.RdoGrater50.Size = new System.Drawing.Size(147, 24);
            this.RdoGrater50.TabIndex = 6;
            this.RdoGrater50.TabStop = true;
            this.RdoGrater50.Text = "Greater than 50";
            this.RdoGrater50.UseVisualStyleBackColor = true;
            // 
            // RdoLess50
            // 
            this.RdoLess50.AutoSize = true;
            this.RdoLess50.Location = new System.Drawing.Point(104, 82);
            this.RdoLess50.Name = "RdoLess50";
            this.RdoLess50.Size = new System.Drawing.Size(126, 24);
            this.RdoLess50.TabIndex = 5;
            this.RdoLess50.TabStop = true;
            this.RdoLess50.Text = "Less than 50";
            this.RdoLess50.UseVisualStyleBackColor = true;
            // 
            // BtnReset2
            // 
            this.BtnReset2.Location = new System.Drawing.Point(120, 153);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(75, 46);
            this.BtnReset2.TabIndex = 4;
            this.BtnReset2.Text = "reset";
            this.BtnReset2.UseVisualStyleBackColor = true;
            // 
            // BtnGenrate2
            // 
            this.BtnGenrate2.Location = new System.Drawing.Point(185, 38);
            this.BtnGenrate2.Name = "BtnGenrate2";
            this.BtnGenrate2.Size = new System.Drawing.Size(87, 38);
            this.BtnGenrate2.TabIndex = 2;
            this.BtnGenrate2.Text = "Generate";
            this.BtnGenrate2.UseVisualStyleBackColor = true;
            this.BtnGenrate2.Click += new System.EventHandler(this.BtnGenrate2_Click);
            // 
            // Btnback
            // 
            this.Btnback.Location = new System.Drawing.Point(483, 382);
            this.Btnback.Name = "Btnback";
            this.Btnback.Size = new System.Drawing.Size(75, 35);
            this.Btnback.TabIndex = 4;
            this.Btnback.Text = "back";
            this.Btnback.UseVisualStyleBackColor = true;
            // 
            // rmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnback);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "rmRandomCombo";
            this.Text = "rmRandomCombo";
            this.Load += new System.EventHandler(this.rmRandomCombo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbRandom1;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.RadioButton RdoGrater500;
        private System.Windows.Forms.RadioButton RdoLess500;
        private System.Windows.Forms.Button BtnGenrate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RdoGrater50;
        private System.Windows.Forms.RadioButton RdoLess50;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.Button BtnGenrate2;
        private System.Windows.Forms.Button Btnback;
    }
}