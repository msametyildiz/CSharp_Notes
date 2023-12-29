using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacingGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Label[] labels = { label1, label2, label3, label4, label5 };
            ComboBox[] comboBoxes = { comboBox1, comboBox2, comboBox3, comboBox4, comboBox5 };

            int numericValue = (int)numericUpDown1.Value;

            // Tüm label ve comboBox kontrolerini gizle
            foreach (Label label in labels)
            {
                label.Visible = false;
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Visible = false;
            }

            // Görünür yapılacak label ve comboBox'ı belirle
            if (numericValue >= 1 && numericValue <= 5)
            {
                labels[numericValue - 1].Visible = true;
                comboBoxes[numericValue - 1].Visible = true;
            }

        }


    }
}
