using System;

namespace LAB2
{
    public partial class Form1 : Form
    {
        private List<Button> buttonList = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Seçili olan radio butonunu bul

            List<RadioButton> radioList = new List<RadioButton>(){radioButton1, radioButton2, radioButton3, radioButton4, radioButton5};
            RadioButton selectedRadioButton = radioList.FirstOrDefault(radio => radio.Checked);

            if (selectedRadioButton != null)
            {
                string result = "";
                if (selectedRadioButton == radioButton1) { result = "1"; }
                if (selectedRadioButton == radioButton2) { result = "2"; }
                if (selectedRadioButton == radioButton3) { result = "3"; }
                if (selectedRadioButton == radioButton4) { result = "4"; }
                if (selectedRadioButton == radioButton5) { result = "5"; }

                foreach (Control control in this.Controls)
                {
                    if (control is Button button && button.Text == result)
                    {
                        // Seçili radio butonun karþýlýk geldiði Button'ýn rengini deðiþtir
                        button.BackColor = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
                    }
                }
            }
        }

    }
}