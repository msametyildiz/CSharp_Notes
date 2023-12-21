namespace WinFormsApp_MEssageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Kayýt silme iþlemini onaylýyor musunuz?"
                ,"Dikkat!"
                ,MessageBoxButtons.YesNo
                ,MessageBoxIcon.Question
                ,MessageBoxDefaultButton.Button2/*varsayýlan buton*/
                );
            if (result== DialogResult.Yes)
            {
                MessageBox.Show("Ýþlem Baþarýlý !", "Ýþlem");
            }
            else
            {
                MessageBox.Show("Ýþlem Baþarýsýz .", "Ýþlem !!");
            }
        }
    }
}