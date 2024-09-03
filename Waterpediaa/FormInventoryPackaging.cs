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
    public partial class FormInventoryPackaging : Form
    {
        private MySqlConnection connection;

        public FormInventoryPackaging()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormInventoryPackaging_Load);
        }

        private void FormInventoryPackaging_Load(object sender, EventArgs e)
        {
            LoadPackagingData();
        }

        public void LoadPackagingData()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            connection = new MySqlConnection(connectionString);

            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Stock_Packaging";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                OpenConnection();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                CloseConnection();
            }

            dataGridViewPackaging.DataSource = dataTable;
            dataGridViewPackaging.Columns["ID"].Visible = false; // Hide the ID column
        }

        private void OpenConnection()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void buttonEditInventory_Click(object sender, EventArgs e)
        {
            if (dataGridViewPackaging.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewPackaging.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string namaBarang = selectedRow.Cells["Nama_Barang"].Value.ToString();
                int jumlah = Convert.ToInt32(selectedRow.Cells["Jumlah"].Value);
                long hargaPerBarang = Convert.ToInt64(selectedRow.Cells["Harga_Per_Barang"].Value);

                // Create an instance of FormEditPackaging with parameters
                FormEditPackaging formEditPackaging = new FormEditPackaging(id, namaBarang, jumlah, hargaPerBarang);

                // Show the FormEditPackaging form as a modal dialog
                formEditPackaging.Show();

                // Reload data in dataGridViewPackaging if needed
                LoadPackagingData();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }


        private void buttonItemPack_Click(object sender, EventArgs e)
        {
            // Create an instance of FormTambahPackaging
            FormTambahPackaging formTambahPackaging = new FormTambahPackaging(this);

            // Show the FormTambahPackaging form as a modal dialog
            formTambahPackaging.Show();

            // Reload data in dataGridViewPackaging if needed
            LoadPackagingData();
        }

        public void UpdateDataGridView()
        {
            LoadPackagingData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormPilihDivisi formPilihDivisi = new FormPilihDivisi();
            formPilihDivisi.Show();
            this.Hide();
        }
    }
}

