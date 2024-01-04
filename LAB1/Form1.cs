namespace LAB1
{
    public partial class Form1 : Form
    {
        private bool ikinciDefaTiklandi = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ikinciDefaTiklandi)
            {
                if (progressBar1.Value < 60)
                {
                    timer1.Stop();
                    MessageBox.Show("Congratulations", "INFO");
                }
            }

            timer1.Start();
            ikinciDefaTiklandi = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2 > progressBar1.Maximum ? progressBar1.Maximum : progressBar1.Value + 2;
            label2.Text = progressBar1.Value.ToString();

            Random random = new Random();
            button1.Location = new Point(random.Next(0, Size.Width), random.Next(0, Size.Height));

            if (progressBar1.Value >= 60)
            {
                timer1.Stop();
                MessageBox.Show("!! Game is Over !!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
        }
    }
}
