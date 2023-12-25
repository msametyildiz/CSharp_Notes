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
            ArrayList arr = new ArrayList() { "sude", "ece", "s�la", "berk","asl�","beliz","zehra" };
            listBox1.Items.AddRange(arr.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Sorted = true; // s�ralama yapmaktad�r
            //listBox2.Items.AddRange(listBox1.Items.Cast<string>().ToArray());
            List<string> generic = new List<string>();
            generic = listBox1.Items.Cast<string>().ToList();
            listBox2.Items.AddRange(generic.OrderByDescending(x => x.ToString()).ToArray()); // tersten yazd�rma alfabetik 
        }
    }
}