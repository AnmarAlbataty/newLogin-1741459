using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newLogin
{
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdoRed1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed1.Checked == true)
            
                RdoRed1.ForeColor = Color.FromArgb(255, 0, 0);
                else
                
                    RdoRed1.ForeColor = Color.FromArgb(0, 0, 0); 
                
            
        }

        private void RdoGreen1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen1.Checked == true)

                RdoGreen1.ForeColor = Color.FromArgb(0, 255, 0);
            else

                RdoGreen1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBlue1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue1.Checked == true)

                RdoBlue1.ForeColor = Color.FromArgb(0, 0, 255);
            else

                RdoBlue1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow1.Checked == true)

                RdoYellow1.ForeColor = Color.FromArgb(255, 255, 0);
            else

                RdoYellow1.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnReaset_Click(object sender, EventArgs e)
        {
            RdoRed1.ForeColor = Color.FromArgb(0, 0, 0);
            RdoGreen1.ForeColor = Color.FromArgb(0, 0, 0);
            RdoBlue1.ForeColor = Color.FromArgb(0, 0, 0);
                 RdoYellow1.ForeColor = Color.FromArgb(0, 0, 0);

            RdoRed1.Checked = false;
            RdoBlue1.Checked = false;
            RdoGreen1.Checked = false;
            RdoYellow1.Checked = false;
        }

        private void FrmRadio_Load(object sender, EventArgs e)
        {

        }
    }
}
