namespace WinFormsAppTrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            label2.Text = trackBar2.Value.ToString();
            pictureBox1.Size = new Size(trackBar1.Value, trackBar2.Value);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}