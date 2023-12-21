namespace WinFormsAppLogin
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
            labelKullanici = new Label();
            labelSifre = new Label();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            buttonGiris = new Button();
            buttonTemizle = new Button();
            SuspendLayout();
            // 
            // labelKullanici
            // 
            labelKullanici.AutoSize = true;
            labelKullanici.Location = new Point(186, 115);
            labelKullanici.Name = "labelKullanici";
            labelKullanici.Size = new Size(92, 20);
            labelKullanici.TabIndex = 0;
            labelKullanici.Text = "Kullanıcı Adı";
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.Location = new Point(186, 169);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(39, 20);
            labelSifre.TabIndex = 1;
            labelSifre.Text = "Şifre";
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(324, 115);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(220, 27);
            textBoxKullaniciAdi.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(324, 169);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(220, 27);
            textBoxSifre.TabIndex = 3;
            // 
            // buttonGiris
            // 
            buttonGiris.Location = new Point(324, 245);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(94, 29);
            buttonGiris.TabIndex = 4;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = true;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(450, 245);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(94, 29);
            buttonTemizle.TabIndex = 5;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTemizle);
            Controls.Add(buttonGiris);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(labelSifre);
            Controls.Add(labelKullanici);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKullanici;
        private Label labelSifre;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Button buttonGiris;
        private Button buttonTemizle;
    }
}