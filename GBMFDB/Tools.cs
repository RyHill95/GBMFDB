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
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }

        private void btnSaveTools_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tools checked out successfully!");
            
            new Menu().Show();
            this.Hide();
        }

        private void btnExitTools_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
