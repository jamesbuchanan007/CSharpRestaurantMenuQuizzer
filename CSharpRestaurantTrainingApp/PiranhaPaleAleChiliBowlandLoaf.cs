﻿using System;
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
    public partial class frmPiranhaPaleAleChiliBowlandLoaf : Form
    {
        public frmPiranhaPaleAleChiliBowlandLoaf()
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmHome().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmTuscanTomatoBisque().Show();
        }

        private void btnNextItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmChickenTortillaSoup().Show();
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
