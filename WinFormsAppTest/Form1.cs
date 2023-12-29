using System.Diagnostics;

namespace WinFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(75, 78);
            button1.Name = "button1";
            button1.Size = new Size(182, 58);
            button1.TabIndex = 0;
            button1.Text = "Show Natification ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(319, 220);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}