namespace repeatForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            if (textBoxAd.Text != "")
            {
                mesaj += textBoxAd.Text+" ";
                if (textBoxSoyad.Text != "")
                {
                    mesaj += textBoxSoyad.Text + " ";
                    if (textBoxDogumYeri.Text != "")
                    {
                        MessageBox.Show("Sayýn "+mesaj+"\nÝþlem Baþarýlý", "Önemli",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Doðum Yeri alaný boþ olamaz.");
                        textBoxDogumYeri.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Soyad alaný boþ olamaz.");
                    textBoxSoyad.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ad alaný boþ olamaz.");
                textBoxAd.Focus();
                return;
            }
        }

        private void textBoxDogumYeri_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxAd_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelDogumYeri_Click(object sender, EventArgs e)
        {
        }

        private void labelSoyad_Click(object sender, EventArgs e)
        {
        }

        private void labelAd_Click(object sender, EventArgs e)
        {
        }
    }
}