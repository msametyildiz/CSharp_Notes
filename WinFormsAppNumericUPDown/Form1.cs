namespace WinFormsAppNumericUPDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = numericUpDown2.Value.ToString();
        }
    }
}