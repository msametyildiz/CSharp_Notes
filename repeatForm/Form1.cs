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
                        MessageBox.Show("Say�n "+mesaj+"\n��lem Ba�ar�l�", "�nemli",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Do�um Yeri alan� bo� olamaz.");
                        textBoxDogumYeri.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Soyad alan� bo� olamaz.");
                    textBoxSoyad.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ad alan� bo� olamaz.");
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