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
            List<object> list = new List<object>();
            list.Add(comboBox1.Items.Cast<object>().ToArray());
            list.Add(comboBox2.Items.Cast<object>().ToArray());
            list.Add(comboBox3.Items.Cast<object>().ToArray());
            list.Add(comboBox4.Items.Cast<object>().ToArray());
            list.Add(comboBox5.Items.Cast<object>().ToArray());

            Form1 form1 = new Form1();
            
            form1.LogoutEvent += logoutHandle;
            form1.ShowDialog();
        }
        public void logoutHandle()
        {
            this.Visible = true;
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
            for (int i = 0; i < numericValue; i++)
            {
                labels[i].Visible = true;
                comboBoxes[i].Visible = true;
            }


        }


    }
}
