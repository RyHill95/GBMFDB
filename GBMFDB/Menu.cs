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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        //Button will take to the Employees Form -Ryan
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            new Employees().Show();
            this.Hide();
        }

        //Button will take to the Tools Form -Ryan
        private void btnTools_Click(object sender, EventArgs e)
        {
            new Tools().Show();
            this.Hide();
        }

        //Button will take to the Skills Form -Ryan
        private void btnSkills_Click(object sender, EventArgs e)
        {
            new Skills().Show();
            this.Hide();
        }

        //Button will take to the Equipment Depot Form -Ryan
        private void btnDepot_Click(object sender, EventArgs e)
        {
            new EquipmentDepot().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();

        }
    }
}
