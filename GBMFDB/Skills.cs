using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBMFDB
{
    public partial class Skills : Form
    {
        public Skills()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes saved successfully!");

            new Menu().Show();
            this.Hide();
        }

        private void boxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void radbtnActive_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radbtnTerm_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
