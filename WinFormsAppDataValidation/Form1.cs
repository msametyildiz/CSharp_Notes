namespace WinFormsAppDataValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            textBoxAd.Focus();
            string hata = "";
            if (textBoxAd.Text == "")
            {
                hata = " Ad, ";
            }
            if(textBoxSoyad.Text == "")
            {
                hata += "Soyad, ";
            }
            if(textBoxDogumYeri.Text == "")
            {
                hata += "Doðum Yeri, ";
            }
            if(hata != "")
            {
                hata = hata.Trim();
                MessageBox.Show(hata+" alanlarý boþ býrakýlamaz .");
            }
            else
            {
                MessageBox.Show("Ýþlem Tamam");
            }
        }
    }
}