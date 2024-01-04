namespace HorseRacingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label2 = new Label();
            label3 = new Label();
            user1 = new Label();
            user2 = new Label();
            user3 = new Label();
            user4 = new Label();
            user5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(1, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(1382, 27);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(1, 294);
            panel3.Name = "panel3";
            panel3.Size = new Size(1382, 27);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(1, 433);
            panel4.Name = "panel4";
            panel4.Size = new Size(1382, 27);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Location = new Point(31, 475);
            button1.Name = "button1";
            button1.Size = new Size(127, 54);
            button1.TabIndex = 1;
            button1.Text = "BAŞLA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(31, 344);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 27);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 475);
            label1.Name = "label1";
            label1.Size = new Size(871, 54);
            label1.TabIndex = 4;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(1370, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(13, 460);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1041, 475);
            label2.Name = "label2";
            label2.Size = new Size(72, 54);
            label2.TabIndex = 4;
            label2.Text = "0\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Teal;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1389, 24);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 5;
            label3.Text = "Oyuncular";
            // 
            // user1
            // 
            user1.BackColor = Color.Silver;
            user1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user1.ForeColor = Color.Black;
            user1.Location = new Point(1389, 67);
            user1.Name = "user1";
            user1.Size = new Size(106, 52);
            user1.TabIndex = 4;
            user1.TextAlign = ContentAlignment.MiddleCenter;
            user1.Visible = false;
            // 
            // user2
            // 
            user2.BackColor = Color.Silver;
            user2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user2.ForeColor = Color.Black;
            user2.Location = new Point(1389, 131);
            user2.Name = "user2";
            user2.Size = new Size(106, 52);
            user2.TabIndex = 4;
            user2.TextAlign = ContentAlignment.MiddleCenter;
            user2.Visible = false;
            // 
            // user3
            // 
            user3.BackColor = Color.Silver;
            user3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user3.ForeColor = Color.Black;
            user3.Location = new Point(1389, 193);
            user3.Name = "user3";
            user3.Size = new Size(106, 52);
            user3.TabIndex = 4;
            user3.TextAlign = ContentAlignment.MiddleCenter;
            user3.Visible = false;
            // 
            // user4
            // 
            user4.BackColor = Color.Silver;
            user4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user4.ForeColor = Color.Black;
            user4.Location = new Point(1388, 256);
            user4.Name = "user4";
            user4.Size = new Size(106, 52);
            user4.TabIndex = 4;
            user4.TextAlign = ContentAlignment.MiddleCenter;
            user4.Visible = false;
            // 
            // user5
            // 
            user5.BackColor = Color.Silver;
            user5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user5.ForeColor = Color.Black;
            user5.Location = new Point(1388, 320);
            user5.Name = "user5";
            user5.Size = new Size(106, 52);
            user5.TabIndex = 4;
            user5.TextAlign = ContentAlignment.MiddleCenter;
            user5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1507, 553);
            Controls.Add(label3);
            Controls.Add(user5);
            Controls.Add(user4);
            Controls.Add(user3);
            Controls.Add(user2);
            Controls.Add(user1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label1;
        private Panel panel5;
        private Label label2;
        private Label label3;
        private Label user1;
        private Label user2;
        private Label user3;
        private Label user4;
        private Label user5;
    }
}