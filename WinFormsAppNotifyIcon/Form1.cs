namespace WinFormsAppNotifyIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000, "Warning", "You are under threat of hacking!!", ToolTipIcon.Warning);
        }
    }
}