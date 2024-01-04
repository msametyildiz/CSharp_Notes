namespace WinFormsAppTabControl
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
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            label2 = new Label();
            buttonColor = new Button();
            labelText = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            tabPage2 = new TabPage();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 455);
            tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(buttonColor);
            tabPage3.Controls.Add(labelText);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(button2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "New Tab Page";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 110);
            label2.MaximumSize = new Size(27, 27);
            label2.MinimumSize = new Size(27, 27);
            label2.Name = "label2";
            label2.Size = new Size(27, 27);
            label2.TabIndex = 4;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(264, 110);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(194, 29);
            buttonColor.TabIndex = 3;
            buttonColor.Text = "Select Color";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(181, 59);
            labelText.Name = "labelText";
            labelText.Size = new Size(36, 20);
            labelText.TabIndex = 2;
            labelText.Text = "Text";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(264, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 27);
            textBox2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(264, 161);
            button2.Name = "button2";
            button2.Size = new Size(218, 62);
            button2.TabIndex = 0;
            button2.Text = "ADD NEW TABPAGE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(268, 90);
            label1.Name = "label1";
            label1.Size = new Size(230, 67);
            label1.TabIndex = 2;
            label1.Text = "GOOGLE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(492, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TabPage tabPage3;
        private Button button2;
        private Label labelText;
        private TextBox textBox2;
        private ColorDialog colorDialog1;
        private Button buttonColor;
        private Label label2;
    }
}