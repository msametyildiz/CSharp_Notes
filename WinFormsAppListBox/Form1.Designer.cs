namespace WinFormsAppListBox
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
            listBox1 = new ListBox();
            button1 = new Button();
            listBox2 = new ListBox();
            button2 = new Button();
            listBox3 = new ListBox();
            button3 = new Button();
            iller = new ListBox();
            button4 = new Button();
            searchButton = new Button();
            listBox4 = new ListBox();
            buttonAktar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Ankara", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ankara" });
            listBox1.Location = new Point(22, 25);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(204, 264);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(22, 295);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Items.AddRange(new object[] { "Samet", "Ahmet", "Veli", "Ayşe", "Nur", "Sude", "Orhan" });
            listBox2.Location = new Point(232, 25);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(119, 124);
            listBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(232, 155);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(232, 203);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(119, 104);
            listBox3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(232, 316);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // iller
            // 
            iller.FormattingEnabled = true;
            iller.ItemHeight = 20;
            iller.Items.AddRange(new object[] { "Ankara", "Adana", "Mersin", "Adıyaman", "Sinop", "Düzce", "Bolu", "Karabük", "Adıyaman" });
            iller.Location = new Point(389, 25);
            iller.Name = "iller";
            iller.SelectionMode = SelectionMode.MultiExtended;
            iller.Size = new Size(142, 264);
            iller.TabIndex = 6;
            iller.SelectedIndexChanged += iller_SelectedIndexChanged;
            iller.DoubleClick += iller_DoubleClick;
            // 
            // button4
            // 
            button4.Location = new Point(457, 304);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(389, 304);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(62, 29);
            searchButton.TabIndex = 8;
            searchButton.Text = "search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(544, 25);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(132, 264);
            listBox4.TabIndex = 9;
            // 
            // buttonAktar
            // 
            buttonAktar.Location = new Point(559, 304);
            buttonAktar.Name = "buttonAktar";
            buttonAktar.Size = new Size(94, 29);
            buttonAktar.TabIndex = 10;
            buttonAktar.Text = "Aktar";
            buttonAktar.UseVisualStyleBackColor = true;
            buttonAktar.Click += buttonAktar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(424, 350);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 11;
            label1.Text = "soldaki listeden sağdakine aktarma";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 393);
            Controls.Add(label1);
            Controls.Add(buttonAktar);
            Controls.Add(listBox4);
            Controls.Add(searchButton);
            Controls.Add(button4);
            Controls.Add(iller);
            Controls.Add(button3);
            Controls.Add(listBox3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
        private ListBox listBox3;
        private Button button3;
        private ListBox iller;
        private Button button4;
        private Button searchButton;
        private ListBox listBox4;
        private Button buttonAktar;
        private Label label1;
    }
}