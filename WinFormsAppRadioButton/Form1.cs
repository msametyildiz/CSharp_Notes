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
                MessageBox.Show("��rencisiniz");
            }
            else if (radioButtonPersonel.Checked)
            {
                MessageBox.Show("Personelsiniz");
            }
            else
            {
                MessageBox.Show("Hi�siniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonKadin.Checked = true;  // formun y�klenmesinde kadin se�imi se�ili geliyor
                
            radioButtonOgrenci.Checked = true;
        }
    }
}