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
    public partial class frmCaliforniaChickenClub : Form
    {
        public frmCaliforniaChickenClub()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
                textBox1.Visible = false;
            else textBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == true)
                textBox2.Visible = false;
            else textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Visible == true)
                textBox3.Visible = false;
            else textBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Visible == true)
                textBox4.Visible = false;
            else textBox4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Visible == true)
                textBox5.Visible = false;
            else textBox5.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmHome().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmBBQPulledPork().Show();
        }

        private void btnNextItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMahiMahiTacos().Show();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
