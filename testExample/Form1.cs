using System.Collections;

namespace testExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList() { "sude", "ece", "sýla", "berk" };
            listBox1.Items.AddRange(arr.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items.Cast<string>().ToArray());
        }
    }
}