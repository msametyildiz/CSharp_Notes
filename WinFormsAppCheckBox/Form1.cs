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
                MessageBox.Show("��lem Tamam", "��LEM"); 
            }
            else
            {
                MessageBox.Show("��lem Ba�ar�s�z.\n Onay Vermen Gerekir.", "��LEM");
            }
        }
    }
}