namespace WinFormsAppRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonOgrenci.Checked)
            {
                MessageBox.Show("Öðrencisiniz");
            }
            else if (radioButtonPersonel.Checked)
            {
                MessageBox.Show("Personelsiniz");
            }
            else
            {
                MessageBox.Show("Hiçsiniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonKadin.Checked = true;  // formun yüklenmesinde kadin seçimi seçili geliyor
                
            radioButtonOgrenci.Checked = true;
        }
    }
}