using System.Collections;

namespace WinFormsAppListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * object[] obj = new object[] { "TRABZON", "HAKKARÝ" };
            string mesaj = "";
            listBox1.Items.Add("Bursa");
            listBox1.Items.Insert(2, "KONYA");
            listBox1.Items.AddRange(obj);
            MessageBox.Show(listBox1.Items.Count.ToString(),"DÝZÝ SAYISI");
            foreach(object o in listBox1.Items)
            {
                mesaj += " , " + o;
            }
            MessageBox.Show(mesaj);
            */
            //MessageBox.Show(listBox1.SelectedItem.ToString()); // seçileni gösterme
            /*MessageBox.Show(listBox1.SelectedIndex.ToString()); // seçili index
            listBox2.Items.Add("Þükrü");
            listBox2.Items.Insert(1, "Aydýn");
            MessageBox.Show(listBox2.Items.Count.ToString());
            listBox2.Items.Insert(0, listBox1.SelectedItem.ToString());
            MessageBox.Show(listBox2.SelectedIndex.ToString());

            string search="Muþ";
            if (listBox1.Items.IndexOf(search) ==-1)
            {
                listBox1.Items.Add(search);
            }
            else
            {
                MessageBox.Show(listBox1.Items.IndexOf(search).ToString()+ " = "+search);
            }

            //arama yapma
            string search = "Ankara";
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == search)
                {
                    MessageBox.Show((i + 1).ToString() + "." + listBox1.Items[i].ToString());
                }
            }
            if (listBox1.SelectedItems.Count > 0)
            {
                listBox2.Items.Clear();
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.SelectedItems[i]); // secilen listleri diðerine ekler 
                }
            }

            listBox1.Items.Remove("Ankara"); // silme iþlem iyapr aynýsýndan varsa ilkini siler
        
            string search = "Ankara";
            if(listBox1.Items.IndexOf(search)!= -1 )
            {
                listBox1.Items.Remove(search);
            } // listbox da aranan deðer listeden kaç tane varsa siler 

           for (int i = 0;i<listBox1.Items.Count;i++) // verie bitene kadar siler
            {
                listBox1.Items.RemoveAt(0);  // indexe göre silme yapar
            }*/
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.SelectedItem = "Samet";
            listBox1.SelectedItem = "Ankara"; // baþlangýçta seçili gelir
            iller.SelectedItem = "Ankara";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] str = new string[10];
            ArrayList list = new ArrayList();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                str[i] = listBox1.Items[i].ToString();

            }
            list.AddRange(listBox1.Items);
            foreach (string l in list)
            {
                MessageBox.Show(l);
            }
            List<string> arryGeneric = new List<string>();
            arryGeneric = listBox1.Items.Cast<string>().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] list = new string[] { "Ankara", "Aydýn", "Karabük", "Sivas" };
            ArrayList arr = new ArrayList();
            arr.Add("Ankara");
            arr.Add("Aydýn");
            arr.Add("Karabük");
            arr.Add("Sivas");
            listBox3.Items.AddRange(arr.ToArray());


        }

        private void button4_Click(object sender, EventArgs e)
        {
            iller.Items.Add("Konya");
            iller.Items.Insert(0, "Afyon");
            object[] obj = new object[] { "Su", "Hava", "Ateþ", "Toprak" };
            ArrayList list = new ArrayList();
            iller.Items.AddRange(obj);
            MessageBox.Show(iller.Items.Count.ToString());
        }

        private void iller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iller_DoubleClick(object sender, EventArgs e)
        {
            if (iller.SelectedItem != null)
            {
                MessageBox.Show(iller.SelectedItem.ToString());
            }
            MessageBox.Show((iller.SelectedIndex + 1).ToString());
        }

        private void searchButton_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < iller.Items.Count; i++)
            {
                if (iller.Items[i].ToString() == "Adýyaman")
                {
                    MessageBox.Show((i + 1).ToString() + ". index : Adýyaman");
                }
            }
        }

        private void buttonAktar_Click(object sender, EventArgs e)
        {
            if (iller.SelectedItems.Count > 0)
            {
                if (listBox4.Items.Count > 0)
                {
                    for (int j = 0; j < iller.SelectedItems.Count; j++)
                    {
                        bool alreadyExists = false;
                        for (int i = 0; i < listBox4.Items.Count; i++)
                        {
                            if (listBox4.Items[i].ToString() == iller.SelectedItems[j].ToString())
                            {
                                alreadyExists = true;
                                break;
                            }

                        }
                        if (!alreadyExists)
                        {
                            listBox4.Items.Add(iller.SelectedItems[j]);
                        }
                    }
                    for (int i = 0; i < listBox4.Items.Count; i++)
                    {
                        bool alreadyExists = true;
                        for (int j = 0; j < iller.SelectedItems.Count; j++)
                        {
                            if (listBox4.Items[i].ToString() == iller.SelectedItems[j].ToString())
                            {
                                alreadyExists = false;
                                break;
                            }

                        }

                        if (alreadyExists)
                        {
                            listBox4.Items.RemoveAt(i);
                        }
                    }

                }
                else
                {
                    foreach (var selectedItem in iller.SelectedItems)
                    {
                        listBox4.Items.Add(selectedItem); // Seçili öðeleri listBox4'e ekle
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (iller.SelectedItems.Count > 0)
            {
                if (listBox4.Items.Count > 0)
                {
                    for (int j = 0; j < iller.SelectedItems.Count; j++)
                    {
                        bool alreadyExists = false;
                        for (int i = 0; i < listBox4.Items.Count; i++)
                        {
                            if (listBox4.Items[i].ToString() == iller.SelectedItems[j].ToString())
                            {
                                alreadyExists = true;
                                break;
                            }

                        }
                        if (!alreadyExists)
                        {
                            listBox4.Items.Add(iller.SelectedItems[j]);
                        }
                    }
                    for (int i = 0; i < listBox4.Items.Count; i++)
                    {
                        bool alreadyExists = true;
                        for (int j = 0; j < iller.SelectedItems.Count; j++)
                        {
                            if (listBox4.Items[i].ToString() == iller.SelectedItems[j].ToString())
                            {
                                alreadyExists = false;
                                break;
                            }

                        }

                        if (alreadyExists)
                        {
                            listBox4.Items.RemoveAt(i);
                        }
                    }

                }
                else
                {
                    foreach (var selectedItem in iller.SelectedItems)
                    {
                        listBox4.Items.Add(selectedItem); // Seçili öðeleri listBox4'e ekle
                    }
                }
            }
        }
    }
}