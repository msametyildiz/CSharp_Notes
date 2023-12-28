namespace WinFormsAppDataSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> itemList;

        private void Form1_Load(object sender, EventArgs e)
        {
            itemList = listBox1.Items.Cast<string>().ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(itemList.Where(i => i.ToLower().Contains(textBox1.Text.ToLower())).ToArray());
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count != -1)
            {
                string engellenecek = "";
                engellenecek = listBox1.SelectedItem.ToString();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox2.Items.Add(engellenecek);

            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count != -1)
            {
                string engelle = listBox2.SelectedItem.ToString();
                listBox2.Items.Remove(engelle);
                listBox1.Items.Add(engelle);
            }
        }
    }
}