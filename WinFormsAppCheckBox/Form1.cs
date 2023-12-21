namespace WinFormsAppCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxOnay.Checked)
            {
                MessageBox.Show("Ýþlem Tamam", "ÝÞLEM"); 
            }
            else
            {
                MessageBox.Show("Ýþlem Baþarýsýz.\n Onay Vermen Gerekir.", "ÝÞLEM");
            }
        }
    }
}