namespace WinFormsAppComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Object[] obj = new object[] { "ali", "ziya", 1, 1.2 };
            //comboBox1.Items.AddRange(obj);
            //comboBox1.Items.Insert(1, "Çanakkale");
            //int num = comboBox1.Items.Count;
            //MessageBox.Show(num.ToString());
            object obj = comboBox1.SelectedItem;
            string name = comboBox1.SelectedItem.ToString();
            MessageBox.Show(obj.ToString());

        }
    }
}