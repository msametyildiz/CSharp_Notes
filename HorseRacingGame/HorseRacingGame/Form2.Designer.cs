namespace HorseRacingGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDown1 = new NumericUpDown();
            label11 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(200, 71);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(103, 27);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Location = new Point(43, 71);
            label11.Name = "label11";
            label11.Size = new Size(136, 27);
            label11.TabIndex = 1;
            label11.Text = "Kullanıcı Sayısı";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 118);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı 1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 162);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı 2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 208);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Kullanıcı 3";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 254);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 2;
            label4.Text = "Kullanıcı 4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 298);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 2;
            label5.Text = "Kullanıcı 5";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(251, 363);
            button1.Name = "button1";
            button1.Size = new Size(122, 29);
            button1.TabIndex = 4;
            button1.Text = "Oyuna Başla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1. At", "2. At", "3. At" });
            comboBox1.Location = new Point(152, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1. At", "2. At", "3. At" });
            comboBox2.Location = new Point(152, 162);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            comboBox2.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1. At", "2. At", "3. At" });
            comboBox3.Location = new Point(152, 208);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 3;
            comboBox3.Visible = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "1. At", "2. At", "3. At" });
            comboBox4.Location = new Point(152, 254);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 3;
            comboBox4.Visible = false;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "1. At", "2. At", "3. At" });
            comboBox5.Location = new Point(152, 298);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(151, 28);
            comboBox5.TabIndex = 3;
            comboBox5.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 418);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(numericUpDown1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label11;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
    }
}