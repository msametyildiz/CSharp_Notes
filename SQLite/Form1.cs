using System.Diagnostics;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;


namespace SQLite
{
    public partial class Form1 : Form
    {
        string dbFileName = "vp.db";
        string connectionString = @"URI=file:" + Application.StartupPath + "\\user_login_test.db";
        public Form1()
        {
            InitializeComponent();
        }


        private void createDataBase()
        {
            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);
                using (var connection = new SQLiteConnection(@"Data Source = " + dbFileName))
                {
                    connection.Open();
                    string sql1 = "create table first_table(number1 INTEGER NOT NULL)";
                    SQLiteCommand cmd = new SQLiteCommand(sql1, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                Debug.WriteLine("Database is already created");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            createDataBase();
        }
    }
}