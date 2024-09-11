using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterpediaa
{
    public partial class FormViewUser : Form
    {
        public FormViewUser()
        {
            InitializeComponent();
        }

        static string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable Title = new DataTable();
        DataTable dt = new DataTable();
        DataTable Remove = new DataTable();

        private void FormViewUser_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxData();
        }

        private void LoadData()
        {
            dt.Clear();
            sqlQuery = "SELECT * FROM main_user ORDER BY Nama ASC";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(dt);
            dataGridViewUser.DataSource = dt;
        }

        private void LoadComboBoxData()
        {
            Title.Clear();
            sqlQuery = "SELECT Title FROM Izin_Akses";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Title);
            cBoxIzinAkses.DataSource = Title;
            cBoxIzinAkses.DisplayMember = "Title";

            Remove.Clear();
            sqlQuery = "SELECT Nama FROM main_user ORDER BY Nama ASC";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Remove);
            cBoxRemoveUser.DataSource = Remove;
            cBoxRemoveUser.DisplayMember = "Nama";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "INSERT INTO main_user (Nama, Username, Password, Izin_Akses) VALUES ('" + tBoxNama.Text + "', '" + tBoxUsername.Text + "', '" + tBoxPassword.Text + "', '" + cBoxIzinAkses.Text + "');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            LoadData();
            LoadComboBoxData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "DELETE FROM main_user WHERE Nama = '" + cBoxRemoveUser.Text + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            LoadData();
            LoadComboBoxData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form back = new FormPilihDivisi();
            back.Show();
            this.Hide();
            this.Close();
        }
    }
}
