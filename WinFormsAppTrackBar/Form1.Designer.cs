namespace WinFormsAppTrackBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            trackBar1 = new TrackBar();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            trackBar2 = new TrackBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 20;
            trackBar1.Location = new Point(172, 66);
            trackBar1.Maximum = 1000;
            trackBar1.Minimum = 80;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(350, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 80;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(624, 76);
            label1.MinimumSize = new Size(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(30, 30);
            label1.TabIndex = 2;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 20;
            trackBar2.Location = new Point(172, 143);
            trackBar2.Maximum = 1000;
            trackBar2.Minimum = 80;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(350, 56);
            trackBar2.TabIndex = 0;
            trackBar2.Value = 80;
            trackBar2.Scroll += trackBar1_Scroll;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(624, 153);
            label2.MinimumSize = new Size(30, 30);
            label2.Name = "label2";
            label2.Size = new Size(30, 30);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 66);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Width";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 143);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Height";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 610);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private PictureBox pictureBox1;
        private Label label1;
        private TrackBar trackBar2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}