using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpRestaurantTrainingApp
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnShareableAppetizers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAvocadoEggrolls().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnPremiumWingsSaucesRubs_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmOriginalChickenWings().Show();
        }

        private void btnSnacksSmallBitesandDips_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHoneySrirachaBrusselsSprouts().Show();
        }

        private void btnSoups_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmBroccoliCheddar().Show();
        }

        private void btnSmallSalads_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmHouseSalad().Show();
        }

        private void btnStarterSalads_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmRoastedPortobelloandAsparagus().Show();
        }

    }
}
