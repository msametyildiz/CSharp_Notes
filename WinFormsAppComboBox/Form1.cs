namespace WinFormsAppComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Ankara";
            comboBox1.SelectedIndex = 5;
            comboBox1.Text = "Select a City";
            //dateTimePicker1.Value = Convert.ToDateTime("14 09 2001 01:32:45 PM");
            dateTimePicker1.Value = DateTime.Now.AddDays(-10);
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textName.Text);
            textName.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = comboBox1.Items.IndexOf(textName.Text);
            if (index == -1)
            {
                MessageBox.Show("Not Found !", "Info");
                return;
            }
            else
            {
                comboBox1.Items.RemoveAt(index);
                textName.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2 > progressBar1.Maximum ? progressBar1.Maximum : progressBar1.Value + 2;
        }
    }
}