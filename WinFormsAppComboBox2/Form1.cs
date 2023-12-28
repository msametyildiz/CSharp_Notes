namespace WinFormsAppComboBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Object[] obj = new object[] { "ali", "ziya", 1, 1.2 };
            //comboBox1.Items.AddRange(obj);
            //comboBox1.Items.Insert(1, "Çanakkale");
            //int num = comboBox1.Items.Count;
            //MessageBox.Show(num.ToString());
            //_______________________________________________________________________________
            //way2 
            //object obj = comboBox1.SelectedItem;
            //string name = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(obj.ToString());
            //_______________________________________________________________________________
            //way3
            //if (comboBox1.SelectedItem != null)
            //{
            //    MessageBox.Show(comboBox1.SelectedItem.ToString()); 
            //}
            //else
            //{
            //    MessageBox.Show(comboBox1.Items[0].ToString());
            //}
            //_______________________________________________________________________________
            //if (comboBox1.SelectedItem != null)
            //{
            //    MessageBox.Show(comboBox1.SelectedIndex.ToString() + " : " + comboBox1.SelectedItem.ToString());
            //}
            //_______________________________________________________________________________
            //listeye veri ekleme 
            //string name = "Sivas";
            //if (comboBox1.Items.IndexOf(name) == -1)
            //{
            //    comboBox1.Items.Add(name);
            //}
            //else
            //{
            //    MessageBox.Show("zaten var");
            //}
            string aranan = "ABC";
            bool found = false;
            //MessageBox.Show(comboBox1.Items.IndexOf(aranan).ToString());
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Items[i].ToString() == aranan)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                comboBox1.Items.Add(aranan);
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("zaten var");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int arananIndex = 0;
            string aranan = "Adana";
            bool found = false;
            for (int i = 0;i< comboBox1.Items.Count;i++)
            {
                if (comboBox1.Items[i].ToString() == aranan)
                {
                    arananIndex = i;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                comboBox1.Items.RemoveAt(arananIndex);
                MessageBox.Show("Kaldýrýldý");
            }
            else
            {
                MessageBox.Show("Zaten Yok");
            }
        }
    }
}