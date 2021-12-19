using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Labs.Forms
{
    public partial class DialogInputForLab5Form : Form
    {
        public DialogInputForLab5Form()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FormLab5.weight = (int)numericUpDownWeight.Value;

            this.Close();
        }
    }
}
