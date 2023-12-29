namespace HorseRacingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int solauzak1, solauzak2, solauzak3;
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            solauzak1 = pictureBox1.Left;
            solauzak2 = pictureBox3.Left;
            solauzak3 = pictureBox2.Left;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label2.Text);
            derece++;
            label2.Text = derece.ToString();
            int genislik1 = pictureBox1.Width;
            int genislik2 = pictureBox3.Width;
            int genislik3 = pictureBox2.Width;
            int bitisuzakligi = panel5.Left;
            pictureBox1.Left = pictureBox1.Left + rand.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rand.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rand.Next(5, 15);

            if (pictureBox1.Left > pictureBox3.Left && pictureBox1.Left > pictureBox2.Left)
            {
                label1.Text = "1 Numaralý At Yarýþý Önde Götürüyor.";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                label1.Text = "2 Numaralý At Yarýþý Önde Götürüyor.";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label1.Text = "3 Numaralý At Yarýþý Önde Götürüyor.";
            }
            if (pictureBox1.Left + genislik1 >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label1.Text = "1 NUMARALI AT YARIÞI KAZANDI";
            }
            if (pictureBox3.Left + genislik2 >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label1.Text = "2 NUMARALI AT YARIÞI KAZANDI";
            }
            if (pictureBox2.Left + genislik3 >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label1.Text = "3 NUMARALI AT YARIÞI KAZANDI";
            }
        }
    }
}