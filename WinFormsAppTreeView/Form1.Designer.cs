namespace WinFormsAppTreeView
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
            TreeNode treeNode1 = new TreeNode("Desktop");
            TreeNode treeNode2 = new TreeNode("Laptop");
            TreeNode treeNode3 = new TreeNode("Computer", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Xiaomi");
            TreeNode treeNode5 = new TreeNode("Samsung");
            TreeNode treeNode6 = new TreeNode("Huawei");
            TreeNode treeNode7 = new TreeNode("Android", new TreeNode[] { treeNode4, treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Apple");
            TreeNode treeNode9 = new TreeNode("IOS", new TreeNode[] { treeNode8 });
            TreeNode treeNode10 = new TreeNode("Mobile", new TreeNode[] { treeNode7, treeNode9 });
            treeView1 = new TreeView();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Desktop";
            treeNode2.Name = "laptopNode";
            treeNode2.Text = "Laptop";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Computer";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Xiaomi";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Samsung";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Huawei";
            treeNode7.Name = "androidNote";
            treeNode7.Text = "Android";
            treeNode8.Name = "Node3";
            treeNode8.Text = "Apple";
            treeNode9.Name = "Node8";
            treeNode9.Text = "IOS";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Mobile";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode10 });
            treeView1.Size = new Size(375, 450);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(476, 146);
            button1.Name = "button1";
            button1.Size = new Size(230, 54);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(476, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(476, 217);
            button2.Name = "button2";
            button2.Size = new Size(230, 54);
            button2.TabIndex = 1;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}