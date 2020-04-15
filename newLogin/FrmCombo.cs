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
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("sunday") ;
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("wdnesday");
            CmbDays.Items.Add("thursday");
            CmbDays.Items.Add("friday");
            CmbDays.Items.Add("saturday");
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("friday");
        }

        private void FrmCombo_Load(object sender, EventArgs e)
        {

        }

        private void BtnMethood1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnRemoveInd_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
           
        }

        private void BtnRemoveLastitem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count>= 1)
            // to know the number of items
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }
           
        }

        private void BtnRemove2ndItem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("cant remove last item");
            }
        }

        private void BtnMethood2_Click(object sender, EventArgs e)
        {

        }
    }
}
