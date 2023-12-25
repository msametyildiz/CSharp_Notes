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
            listBox5 = new ListBox();
            AktarButton = new Button();
            listBox6 = new ListBox();
            button5 = new Button();
            button6 = new Button();
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
            listBox2.Location = new Point(22, 350);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(119, 124);
            listBox2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(147, 386);
            button2.Name = "button2";
            button2.Size = new Size(79, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(22, 503);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(119, 104);
            listBox3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(147, 537);
            button3.Name = "button3";
            button3.Size = new Size(79, 29);
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
            iller.Location = new Point(252, 25);
            iller.Name = "iller";
            iller.SelectionMode = SelectionMode.MultiExtended;
            iller.Size = new Size(142, 264);
            iller.TabIndex = 6;
            iller.SelectedIndexChanged += iller_SelectedIndexChanged;
            iller.DoubleClick += iller_DoubleClick;
            // 
            // button4
            // 
            button4.Location = new Point(321, 295);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 7;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(253, 295);
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
            listBox4.Location = new Point(412, 25);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(132, 264);
            listBox4.TabIndex = 9;
            // 
            // buttonAktar
            // 
            buttonAktar.Location = new Point(423, 295);
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
            label1.Location = new Point(288, 341);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 11;
            label1.Text = "soldaki listeden sağdakine aktarma";
            label1.Click += label1_Click;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 20;
            listBox5.Items.AddRange(new object[] { "ali", "veli", "zeynep", "sude", "ece", "kaan", "berk", "nisa" });
            listBox5.Location = new Point(566, 25);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(117, 264);
            listBox5.TabIndex = 12;
            // 
            // AktarButton
            // 
            AktarButton.Location = new Point(566, 305);
            AktarButton.Name = "AktarButton";
            AktarButton.Size = new Size(117, 29);
            AktarButton.TabIndex = 13;
            AktarButton.Text = "Diziye Aktar";
            AktarButton.UseVisualStyleBackColor = true;
            AktarButton.Click += AktarButton_Click;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 20;
            listBox6.Location = new Point(708, 25);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(117, 264);
            listBox6.TabIndex = 12;
            // 
            // button5
            // 
            button5.Location = new Point(713, 305);
            button5.Name = "button5";
            button5.Size = new Size(112, 29);
            button5.TabIndex = 14;
            button5.Text = "Diziden Aktar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(713, 350);
            button6.Name = "button6";
            button6.Size = new Size(112, 29);
            button6.TabIndex = 15;
            button6.Text = "Generic List";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 638);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(AktarButton);
            Controls.Add(listBox6);
            Controls.Add(listBox5);
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
        private ListBox listBox5;
        private Button AktarButton;
        private ListBox listBox6;
        private Button button5;
        private Button button6;
    }
}