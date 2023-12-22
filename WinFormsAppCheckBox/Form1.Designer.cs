namespace WinFormsAppCheckBox
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
            checkBoxOnay = new CheckBox();
            buttonTamam = new Button();
            SuspendLayout();
            // 
            // checkBoxOnay
            // 
            checkBoxOnay.AutoSize = true;
            checkBoxOnay.Location = new Point(166, 257);
            checkBoxOnay.Name = "checkBoxOnay";
            checkBoxOnay.Size = new Size(195, 24);
            checkBoxOnay.TabIndex = 0;
            checkBoxOnay.Text = "Okudum ve onaylıyorum.";
            checkBoxOnay.UseVisualStyleBackColor = true;
            // 
            // buttonTamam
            // 
            buttonTamam.Location = new Point(235, 305);
            buttonTamam.Name = "buttonTamam";
            buttonTamam.Size = new Size(94, 29);
            buttonTamam.TabIndex = 1;
            buttonTamam.Text = "Tamam";
            buttonTamam.UseVisualStyleBackColor = true;
            buttonTamam.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTamam);
            Controls.Add(checkBoxOnay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxOnay;
        private Button buttonTamam;
    }
}