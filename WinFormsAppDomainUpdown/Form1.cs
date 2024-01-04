namespace WinFormsAppDomainUpdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = domainUpDown1.Items;
            collection.Add("January");
            collection.Add("February");
            collection.Add("March");
            collection.Add("April");
            collection.Add("May");
            domainUpDown1.Text = "Jun";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = numericUpDown2.Value.ToString() + " / " + domainUpDown1.Text + " / " + numericUpDown1.Value.ToString();
        }
    }
}