namespace repeatForm
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
            labelAd = new Label();
            labelSoyad = new Label();
            labelDogumYeri = new Label();
            textBoxAd = new TextBox();
            textBoxSoyad = new TextBox();
            textBoxDogumYeri = new TextBox();
            buttonKaydet = new Button();
            SuspendLayout();
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Location = new Point(222, 146);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(28, 20);
            labelAd.TabIndex = 0;
            labelAd.Text = "Ad";
            labelAd.Click += labelAd_Click;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Location = new Point(222, 194);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(50, 20);
            labelSoyad.TabIndex = 0;
            labelSoyad.Text = "Soyad";
            labelSoyad.Click += labelSoyad_Click;
            // 
            // labelDogumYeri
            // 
            labelDogumYeri.AutoSize = true;
            labelDogumYeri.Location = new Point(222, 245);
            labelDogumYeri.Name = "labelDogumYeri";
            labelDogumYeri.Size = new Size(87, 20);
            labelDogumYeri.TabIndex = 0;
            labelDogumYeri.Text = "Doğum Yeri";
            labelDogumYeri.Click += labelDogumYeri_Click;
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(317, 139);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(241, 27);
            textBoxAd.TabIndex = 1;
            textBoxAd.TextChanged += textBoxAd_TextChanged;
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(317, 187);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(241, 27);
            textBoxSoyad.TabIndex = 1;
            textBoxSoyad.TextChanged += textBoxSoyad_TextChanged;
            // 
            // textBoxDogumYeri
            // 
            textBoxDogumYeri.Location = new Point(317, 238);
            textBoxDogumYeri.Name = "textBoxDogumYeri";
            textBoxDogumYeri.Size = new Size(241, 27);
            textBoxDogumYeri.TabIndex = 1;
            textBoxDogumYeri.TextChanged += textBoxDogumYeri_TextChanged;
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(371, 309);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(94, 29);
            buttonKaydet.TabIndex = 2;
            buttonKaydet.Text = "KAYDET";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKaydet);
            Controls.Add(textBoxDogumYeri);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(labelDogumYeri);
            Controls.Add(labelSoyad);
            Controls.Add(labelAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAd;
        private Label labelSoyad;
        private Label labelDogumYeri;
        private TextBox textBoxAd;
        private TextBox textBoxSoyad;
        private TextBox textBoxDogumYeri;
        private Button buttonKaydet;
    }
}