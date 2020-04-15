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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text=="Anmar" && TxtPass.Text=="4724")
            {
                MessageBox.Show("Login Successful");
            }
            else if (TxtUser.Text != "Anmar")
            {
                MessageBox.Show("Incorrect username");

            }
            else
            {
                MessageBox.Show("Incorrect pass");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
