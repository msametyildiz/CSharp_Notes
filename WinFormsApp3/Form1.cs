namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text += "Click";
            label1.Text = textBox1.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // label1.Text += "Deðiþti";
            label1.Text = textBox1.Text;// metin yazarken karakter karakter labelý deðiþtiriyor

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //label1.Text += "girildi";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //label1.Text += "çýkýldý";
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            //label1.Text += "DoubleClick";
        }
    }
}