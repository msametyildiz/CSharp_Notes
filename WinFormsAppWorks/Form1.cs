using System.Diagnostics;

namespace WinFormsAppWorks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Hello World!!!", "Visual Programming", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Debug.Print("You Clicked OK");
            }
            else if (result == DialogResult.No)
            {
                Debug.Print("You Clicked NO");
            }
            else if (result == DialogResult.Cancel)
            {
                Debug.Print("You Clicked Cancel");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                button3.Font = fontDialog1.Font;
                label1.Font = fontDialog1.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
            BackColor = colorDialog1.Color;
        }
    }
}