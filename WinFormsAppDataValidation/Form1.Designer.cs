namespace WinFormsAppDataValidation
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
            textBoxAd = new TextBox();
            labelAd = new Label();
            textBoxSoyad = new TextBox();
            labelSoyad = new Label();
            textBoxDogumYeri = new TextBox();
            labelDogumYeri = new Label();
            buttonKaydet = new Button();
            SuspendLayout();
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(294, 116);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(261, 27);
            textBoxAd.TabIndex = 0;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Location = new Point(144, 119);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(28, 20);
            labelAd.TabIndex = 1;
            labelAd.Text = "Ad";
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(294, 167);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(261, 27);
            textBoxSoyad.TabIndex = 0;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Location = new Point(144, 170);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(50, 20);
            labelSoyad.TabIndex = 1;
            labelSoyad.Text = "Soyad";
            // 
            // textBoxDogumYeri
            // 
            textBoxDogumYeri.Location = new Point(294, 221);
            textBoxDogumYeri.Name = "textBoxDogumYeri";
            textBoxDogumYeri.Size = new Size(261, 27);
            textBoxDogumYeri.TabIndex = 0;
            // 
            // labelDogumYeri
            // 
            labelDogumYeri.AutoSize = true;
            labelDogumYeri.Location = new Point(144, 224);
            labelDogumYeri.Name = "labelDogumYeri";
            labelDogumYeri.Size = new Size(87, 20);
            labelDogumYeri.TabIndex = 1;
            labelDogumYeri.Text = "Doğum Yeri";
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(366, 317);
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
            Controls.Add(labelDogumYeri);
            Controls.Add(labelSoyad);
            Controls.Add(labelAd);
            Controls.Add(textBoxDogumYeri);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAd;
        private Label labelAd;
        private TextBox textBoxSoyad;
        private Label labelSoyad;
        private TextBox textBoxDogumYeri;
        private Label labelDogumYeri;
        private Button buttonKaydet;
    }
}