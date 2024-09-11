using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Waterpediaa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        static string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable Login = new DataTable();

        public static string Izin_Akses;
        public static string Nama;
        public static string UID = "";
        public static string PASS = "";

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tBoxPassword.UseSystemPasswordChar = true;
            /*remember usename if exist*/
            if (!string.IsNullOrEmpty(Properties.Settings.Default.RememberedUsername))
            {
                tBoxUsername.Text = Properties.Settings.Default.RememberedUsername;
                cBoxRememberUser.Checked = true;
            }

        }
        private void cBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowPass.Checked)
            {
                tBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect.Open();
                sqlQuery = "SELECT * FROM main_user WHERE Username = '" + tBoxUsername.Text + "' and Password = '" + tBoxPassword.Text + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(Login);

                if (Login.Rows.Count > 0)
                {
                    Nama = Login.Rows[0]["Nama"].ToString();
                    Izin_Akses = Login.Rows[0]["Izin_Akses"].ToString();
                    if (cBoxRememberUser.Checked)
                    {
                        Properties.Settings.Default.RememberedUsername = tBoxUsername.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.RememberedUsername = string.Empty;
                        Properties.Settings.Default.Save();
                    }
                    Form formPilihDivisi = new FormPilihDivisi();
                    formPilihDivisi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User / Password Salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
