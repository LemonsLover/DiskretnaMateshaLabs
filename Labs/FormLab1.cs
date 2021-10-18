using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Lab1.Properties;
using Lab1.Enums;

namespace Lab1
{
    public enum Action
    {
        Обєднання,
        Переріз,
        Різницю,
        СиметричнаРізниця,
    }

    public partial class FormLab1 : Form
    {
        Set set1;
        Set set2;
        Label activeLabel;

        public FormLab1()
        {
            InitializeComponent();
            textBoxVarNameInput.LostFocus += textBoxVarNameInput_LostFocus;
        }

        private void FormLab1_Load(object sender, EventArgs e)
        {
            comboBoxAct.Items.Add(Action.Обєднання);
            comboBoxAct.Items.Add(Action.Переріз);
            comboBoxAct.Items.Add(Action.Різницю);
            comboBoxAct.Items.Add(Action.СиметричнаРізниця);
            comboBoxAct.SelectedIndex = 1;
            textBoxInput1.Text = "1,2,3,4,5,6";
            textBoxInput2.Text = "4,5.5,6,7,8,9";
        }

        private List<float> Culculate(Action action, string setA, string setB)
        {
            try
            {
                this.set1 = new Set(setA);
                this.set2 = new Set(setB);
                switch (action)
                {
                    case Action.Обєднання:
                        pictureBox.Image = Resources.union;
                        return this.set1.Union(this.set2).Value;
                    case Action.Переріз:
                        pictureBox.Image = Resources.intersection;
                        return this.set1.Intersect(this.set2).Value;
                    case Action.Різницю:
                        pictureBox.Image = Resources.difference;
                        return this.set1.Defferance(this.set2).Value;
                    case Action.СиметричнаРізниця:
                        pictureBox.Image = Resources.symetricDifference;
                        return this.set1.SymmetricDifference(this.set2).Value; ;
                    default: return null;
                }
            }
            catch
            {
                return null;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            var resultText = string.Join(',', Culculate((Action)comboBoxAct.SelectedItem, textBoxInput1.Text, textBoxInput2.Text) ?? new List<float>());
            textBoxResult.Text = string.IsNullOrEmpty(resultText) ? "" : resultText;
        }

        private void labelInput_DoubleClick(object sender, EventArgs e)
        {
            activeLabel = sender as Label; 
            textBoxVarNameInput.Visible = true;
            textBoxVarNameInput.Location = activeLabel.Location;
            textBoxVarNameInput.Text = activeLabel.Text;
        }

        private void textBoxVarNameInput_LostFocus(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.Visible = false;
            activeLabel = null;
        }

        private void textBoxVarNameInput_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            activeLabel.Text = string.IsNullOrEmpty(textBox.Text) ? activeLabel.Text : textBox.Text;
            textBox.Size = activeLabel.Size;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void FormLab1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
