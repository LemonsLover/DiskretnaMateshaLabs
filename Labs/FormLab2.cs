using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormLab2 : Form
    {
        Set setA;
        Set setB;

        public FormLab2()
        {
            InitializeComponent();

            textBoxA.TextChanged += textBox_TextChanged;
            textBoxB.TextChanged += textBox_TextChanged;
        }

        private void FormLab2_Load(object sender, EventArgs e)
        {
            textBoxA.Text = "2,4,5,6,7,8,9";
            textBoxB.Text = "1,2,3";

            dataGridViewSetsRelations.RowHeadersWidth = 60;
        }

        private void Culculate(string set1, string set2)
        {
            clearDataGridViewSetsRelations();
            try
            {
                this.setA = new Set(set1);
                this.setB = new Set(set2);

                foreach (var elem in setB.Value)
                    dataGridViewSetsRelations.Columns.Add(elem.ToString(), elem.ToString());

                for (int i = 0; i < setA.Value.Count; i++)
                {
                    dataGridViewSetsRelations.Rows.Add();
                    dataGridViewSetsRelations.Rows[i].HeaderCell.Value = setA.Value[i].ToString();
                }

                for (int i = 0; i < setA.Value.Count; i++)
                    for (int j = 0; j < setB.Value.Count; j++)
                    {
                        if (setA.Value[i] < setB.Value[j] * 3)
                            dataGridViewSetsRelations[j, i].Value = 1;
                        else
                            dataGridViewSetsRelations[j, i].Value = 0;
                    }
            }
            catch
            {
                clearDataGridViewSetsRelations();
            }

        }

        private void clearDataGridViewSetsRelations()
        {
            dataGridViewSetsRelations.Rows.Clear();
            dataGridViewSetsRelations.Columns.Clear();   
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Culculate(textBoxA.Text, textBoxB.Text);
        }

        private void FormLab2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
