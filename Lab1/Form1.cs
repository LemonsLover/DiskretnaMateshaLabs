using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Lab1.Properties;

namespace Lab1
{
    public enum Action
    {
        Обєднання,
        Переріз,
        Різницю,
        СиметричнаРізниця,
    }

    public partial class Form1 : Form
    {
        Set set1;
        Set set2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxAct.Items.Add(Action.Обєднання);
            comboBoxAct.Items.Add(Action.Переріз);
            comboBoxAct.Items.Add(Action.Різницю);
            comboBoxAct.Items.Add(Action.СиметричнаРізниця);
            comboBoxAct.SelectedIndex = 1;
            textBoxA.Text = "1,2,3,4,5,6";
            textBoxB.Text = "4,5.5,6,7,8,9";
        }

        private List<float> Culculate(Action action, string setA, string setB)
        {
            try
            {
                this.set1 = new Set(setA.Split(',').Select(float.Parse).ToList());
                this.set2 = new Set(setB.Split(',').Select(float.Parse).ToList());
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
            var resultText = string.Join(',', Culculate((Action)comboBoxAct.SelectedItem, textBoxA.Text, textBoxB.Text) ?? new List<float>());
            textBoxResult.Text = string.IsNullOrEmpty(resultText) ? "ERROR" : resultText;
        }
    }
}
