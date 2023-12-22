namespace WinFormsAppRadioButton
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
            radioButtonOgrenci = new RadioButton();
            radioButtonPersonel = new RadioButton();
            radioButtonDiger = new RadioButton();
            button1 = new Button();
            radioButtonErkek = new RadioButton();
            radioButtonKadin = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonOgrenci
            // 
            radioButtonOgrenci.AutoSize = true;
            radioButtonOgrenci.Location = new Point(33, 35);
            radioButtonOgrenci.Name = "radioButtonOgrenci";
            radioButtonOgrenci.Size = new Size(82, 24);
            radioButtonOgrenci.TabIndex = 0;
            radioButtonOgrenci.TabStop = true;
            radioButtonOgrenci.Text = "Öğrenci";
            radioButtonOgrenci.UseVisualStyleBackColor = true;
            // 
            // radioButtonPersonel
            // 
            radioButtonPersonel.AutoSize = true;
            radioButtonPersonel.Location = new Point(33, 84);
            radioButtonPersonel.Name = "radioButtonPersonel";
            radioButtonPersonel.Size = new Size(85, 24);
            radioButtonPersonel.TabIndex = 1;
            radioButtonPersonel.TabStop = true;
            radioButtonPersonel.Text = "Personel";
            radioButtonPersonel.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiger
            // 
            radioButtonDiger.AutoSize = true;
            radioButtonDiger.Location = new Point(33, 130);
            radioButtonDiger.Name = "radioButtonDiger";
            radioButtonDiger.Size = new Size(67, 24);
            radioButtonDiger.TabIndex = 2;
            radioButtonDiger.TabStop = true;
            radioButtonDiger.Text = "Diğer";
            radioButtonDiger.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(295, 261);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButtonErkek
            // 
            radioButtonErkek.AutoSize = true;
            radioButtonErkek.Location = new Point(53, 30);
            radioButtonErkek.Name = "radioButtonErkek";
            radioButtonErkek.Size = new Size(65, 24);
            radioButtonErkek.TabIndex = 4;
            radioButtonErkek.TabStop = true;
            radioButtonErkek.Text = "Erkek";
            radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // radioButtonKadin
            // 
            radioButtonKadin.AutoSize = true;
            radioButtonKadin.Location = new Point(53, 79);
            radioButtonKadin.Name = "radioButtonKadin";
            radioButtonKadin.Size = new Size(68, 24);
            radioButtonKadin.TabIndex = 4;
            radioButtonKadin.TabStop = true;
            radioButtonKadin.Text = "Kadın";
            radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonKadin);
            groupBox1.Controls.Add(radioButtonErkek);
            groupBox1.Location = new Point(434, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonDiger);
            groupBox2.Controls.Add(radioButtonPersonel);
            groupBox2.Controls.Add(radioButtonOgrenci);
            groupBox2.Location = new Point(157, 36);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(232, 194);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Göreviniz";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButtonOgrenci;
        private RadioButton radioButtonPersonel;
        private RadioButton radioButtonDiger;
        private Button button1;
        private RadioButton radioButtonErkek;
        private RadioButton radioButtonKadin;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}