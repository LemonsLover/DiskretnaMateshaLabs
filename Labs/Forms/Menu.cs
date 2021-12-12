using Labs.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Labs
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLab1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLab1().Show();
        }

        private void buttonLab2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLab2().Show();
        }

        private void buttonLab3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLab3().Show();
        }

        private void buttonLab4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLab4().Show();
        }
    }
}
