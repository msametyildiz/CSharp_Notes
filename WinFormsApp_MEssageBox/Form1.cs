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
            result = MessageBox.Show("Kay�t silme i�lemini onayl�yor musunuz?"
                ,"Dikkat!"
                ,MessageBoxButtons.YesNo
                ,MessageBoxIcon.Question
                ,MessageBoxDefaultButton.Button2/*varsay�lan buton*/
                );
            if (result== DialogResult.Yes)
            {
                MessageBox.Show("��lem Ba�ar�l� !", "��lem");
            }
            else
            {
                MessageBox.Show("��lem Ba�ar�s�z .", "��lem !!");
            }
        }
    }
}