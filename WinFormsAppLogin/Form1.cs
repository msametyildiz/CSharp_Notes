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
            string kullaniciAdi = textBoxKullaniciAdi.Text.Trim();// ba��nda ve sonundaki bo�luklar� siler
            string sifre = textBoxSifre.Text.Trim();

            if (kullaniciAdi == "samet" && sifre == "123")
            {
                MessageBox.Show("��lem Ba�ar�l�.", "��LEM");
            }
            else
            {
                MessageBox.Show("Girilen bilgiler Yanl��t�r", "D�KKAT");
                textBoxKullaniciAdi.Text = "";
                textBoxSifre.Text = "";
                textBoxKullaniciAdi.Focus(); // i�lem olduktan sonra yazma metni kullanici ad�n�n orada olacak
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