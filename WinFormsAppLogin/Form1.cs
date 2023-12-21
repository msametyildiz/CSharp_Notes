namespace WinFormsAppLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text.Trim();// baþýnda ve sonundaki boþluklarý siler
            string sifre = textBoxSifre.Text.Trim();

            if (kullaniciAdi == "samet" && sifre == "123")
            {
                MessageBox.Show("Ýþlem Baþarýlý.", "ÝÞLEM");
            }
            else
            {
                MessageBox.Show("Girilen bilgiler Yanlýþtýr", "DÝKKAT");
                textBoxKullaniciAdi.Text = "";
                textBoxSifre.Text = "";
                textBoxKullaniciAdi.Focus(); // iþlem olduktan sonra yazma metni kullanici adýnýn orada olacak
            }

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = "";
            textBoxSifre.Text = "";
            textBoxKullaniciAdi.Focus();
        }
    }
}