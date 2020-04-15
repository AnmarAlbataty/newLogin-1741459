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
        string username = "Anmar";
        string mypassword = "4724";
        
        int attempt = 1;
        int maxattempts = 3;

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
            
            while (attempt <= maxattempts)
            {
                if (TxtUser.Text != username)
                    


                { // username is incorrect
                    MessageBox.Show("invalid username," + (maxattempts - attempt) +
                        "attempts remaining");
                    TxtUser.Clear();

                    attempt++;
                    return;

                }
                else
                {  // username is correct
                    // so check password
                    if (TxtPass.Text != "4724")
                    {
                        attempt++;
                        // incorrect password attempt++;
                        MessageBox.Show("incorrect password" + (maxattempts - attempt) +
                            "attempts remaining");
                        TxtPass.Clear();

                        return;
                    }

                    else


                    {
                        // both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login Successfull");
                        BtnLogin.Text =
                            "Logout";
                       
                        // this.width = 1600;
                        break; // come out of while loop
                    }// end if
                } // end if
            } // end while
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio frm = new FrmRadio();
            frm.ShowDialog();

        }

        private void Btncheck_Click(object sender, EventArgs e)
        {
            FrmCheckcs frm = new FrmCheckcs();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            FrmCombo frm = new FrmCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            FrmRandom frm = new FrmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCompo_Click(object sender, EventArgs e)
        {
            rmRandomCombo frm = new rmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPic1_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
            frm.ShowDialog();
        }

        private void BtnArray_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }
    }
}
