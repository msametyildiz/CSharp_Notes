using System.Diagnostics;
using System.Net.Security;

namespace WinFormsAppTabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.google.com/search?q=" + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabPage ntabPage = new TabPage();
            ntabPage.Text = textBox2.Text;
            ntabPage.BackColor = label2.BackColor;
            tabControl1.Controls.Add(ntabPage);
            Label lbl = new Label();
            lbl.Text = "Hello World";
            Random rnd = new Random();
            lbl.Location = new Point(rnd.Next(0,tabControl1.Width-lbl.Width), rnd.Next(0, tabControl1.Height-lbl.Height));
            ntabPage.Controls.Add(lbl);


        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult color = colorDialog1.ShowDialog(this);
            if (color == DialogResult.OK)
            {
                label2.BackColor = colorDialog1.Color;
                label2.Visible = true;
            }


        }
    }
}