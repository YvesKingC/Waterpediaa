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
    public partial class FormTambahWTP : Form
    {
        private FormInventoryWTP mainForm;

        public FormTambahWTP(FormInventoryWTP form)
        {
            InitializeComponent();
            this.Load += new EventHandler(FormTambahWTP_Load);
            mainForm = form;
        }

        private void FormTambahWTP_Load(object sender, EventArgs e)
        {
            LoadStockData();
            LoadMutasiFilterData();
        }

        private void LoadStockData()
        {
            DataTable dataTable = GetStockFilter();
            dataGridViewStock.DataSource = dataTable;
        }

        private DataTable GetStockFilter()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
            string query = "SELECT ID, Jenis_Filter, Berat, Jumlah, Harga_Per_Barang FROM Stock_Filter"; // Include ID

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

        private long InsertNewFilter(string jenisFilter, int berat, int stokAwal, long harga)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "INSERT INTO Stock_Filter (Jenis_ProdukID, Jenis_Filter, Berat, Jumlah, Harga_Per_Barang) VALUES (@jenisProdukID, @jenisFilter, @berat, @stokAwal, @harga)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@jenisProdukID", 3); // Set Jenis_ProdukID to 3 for filters
                    cmd.Parameters.AddWithValue("@jenisFilter", jenisFilter);
                    cmd.Parameters.AddWithValue("@berat", berat);
                    cmd.Parameters.AddWithValue("@stokAwal", stokAwal);
                    cmd.Parameters.AddWithValue("@harga", harga);

                    cmd.ExecuteNonQuery();

                    // Retrieve and return the last inserted ID
                    return cmd.LastInsertedId;
                }
            }
        }




        private void btnInput_Click(object sender, EventArgs e)
        {
            // Get the input values
            string jenisFilter = textBoxNama.Text;
            int berat = (int)nudBerat.Value;
            int stokAwal = (int)nudStok.Value;
            long harga = (long)nudHarga.Value;

            // Insert the new data into Stock_Filter table
            long newFilterId = InsertNewFilter(jenisFilter, berat, stokAwal, harga);

            if (newFilterId > 0)
            {
                // Insert the corresponding record into mutasi_produk table
                InsertMutasiFilter(newFilterId, stokAwal);

                // Reload the data in dataGridViewStock and dataGridViewMutasiFilter
                LoadStockData();
                LoadMutasiFilterData();
            }
            else
            {
                MessageBox.Show("Failed to insert the new filter.");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.UpdateDataGridView(); // Call the update method on the main form
            this.Close(); // Close the current form
        }

        private void LoadMutasiFilterData()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = @"SELECT m.ID, f.Jenis_Filter AS Produk, m.Masuk, m.Keluar, m.Keterangan 
                     FROM mutasi_produk m
                     JOIN Stock_Filter f ON m.Stock_FilterID = f.ID
                     WHERE m.Stock_FilterID IS NOT NULL";

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

            dataGridViewMutasi.DataSource = dataTable;
        }

        private void InsertMutasiFilter(long filterId, int stokAwal)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string insertMutasiQuery = "INSERT INTO mutasi_produk (Stock_FilterID, Masuk, Keluar, Keterangan) VALUES (@filterId, @masuk, @keluar, @keterangan)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand insertMutasiCmd = new MySqlCommand(insertMutasiQuery, connection))
                {
                    insertMutasiCmd.Parameters.AddWithValue("@filterId", filterId);
                    insertMutasiCmd.Parameters.AddWithValue("@masuk", stokAwal); // 'Masuk' is the amount added
                    insertMutasiCmd.Parameters.AddWithValue("@keluar", 0); // 'Keluar' is 0 for a new addition
                    insertMutasiCmd.Parameters.AddWithValue("@keterangan", "New Filter Item Added"); // Description
                    insertMutasiCmd.ExecuteNonQuery();
                }
            }
        }

    }
}
