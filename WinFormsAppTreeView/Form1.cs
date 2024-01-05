namespace WinFormsAppTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }
    }
}