namespace WinFormsAppContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            BackColor = color;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}