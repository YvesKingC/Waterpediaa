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
    public partial class FormTambahPackaging : Form
    {
        private FormInventoryPackaging mainForm;

        public FormTambahPackaging(FormInventoryPackaging form)
        {
            InitializeComponent();
            this.Load += new EventHandler(FormTambahPackaging_Load);
            mainForm = form;
        }

        private void FormTambahPackaging_Load(object sender, EventArgs e)
        {
            LoadStockPackagingData();
        }

        private void LoadStockPackagingData()
        {
            DataTable dataTable = GetStockPackaging();
            dataGridViewStockPackaging.DataSource = dataTable;
        }

        private DataTable GetStockPackaging()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT * FROM Stock_Packaging";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        private void InsertNewPackaging(string namaBarang, int jumlah, int volume, long harga)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "INSERT INTO Stock_Packaging (Nama_Barang, Jumlah, Volume, Harga_Per_Barang) VALUES (@namaBarang, @jumlah, @volume, @harga)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@volume", volume);
                    cmd.Parameters.AddWithValue("@harga", harga);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnInputBakteriBaru_Click(object sender, EventArgs e)
        {
            // Get the input values
            string namaBarang = textBoxNamaBarang.Text;
            int jumlah = (int)nudJumlah.Value;
            int volume = (int)nudVolume.Value;
            long harga = (long)nudHarga.Value;

            // Insert the new data into Stock_Packaging table
            InsertNewPackaging(namaBarang, jumlah, volume, harga);

            // Reload the data in dataGridViewStockPackaging
            LoadStockPackagingData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.UpdateDataGridView(); // Call the update method on the main form
            this.Close(); // Close the current form
        }
    }
}
