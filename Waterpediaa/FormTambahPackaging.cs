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
            LoadMutasiPackagingData();
        }

        private void LoadStockPackagingData()
        {
            DataTable dataTable = GetStockPackaging();
            dataGridViewStockPackaging.DataSource = dataTable;
        }

        private DataTable GetStockPackaging()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
            string query = "SELECT ID, Nama_Barang, Jumlah, Volume, Harga_Per_Barang FROM Stock_Packaging"; // Include ID

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
            string query = "INSERT INTO Stock_Packaging (Jenis_ProdukID, Nama_Barang, Jumlah, Volume, Harga_Per_Barang) VALUES (@jenisProdukID, @namaBarang, @jumlah, @volume, @harga)";
            string insertMutasiQuery = "INSERT INTO mutasi_produk (Stock_PackagingID, Masuk, Keluar, Keterangan) VALUES (@packagingId, @masuk, @keluar, @keterangan)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Insert the new packaging item
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@jenisProdukID", 2); // Set Jenis_ProdukID to 2 for packaging
                    cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@volume", volume);
                    cmd.Parameters.AddWithValue("@harga", harga);

                    cmd.ExecuteNonQuery();

                    // Retrieve the last inserted ID
                    long lastInsertedId = cmd.LastInsertedId;

                    // Verify the lastInsertedId is retrieved properly
                    if (lastInsertedId > 0)
                    {
                        // Insert into the mutasi_produk table
                        using (MySqlCommand insertMutasiCmd = new MySqlCommand(insertMutasiQuery, connection))
                        {
                            insertMutasiCmd.Parameters.AddWithValue("@packagingId", lastInsertedId);
                            insertMutasiCmd.Parameters.AddWithValue("@masuk", jumlah); // 'Masuk' is the amount added
                            insertMutasiCmd.Parameters.AddWithValue("@keluar", 0); // 'Keluar' is 0 for a new addition
                            insertMutasiCmd.Parameters.AddWithValue("@keterangan", "New Packaging Item Added"); // Description
                            insertMutasiCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve the last inserted ID for Stock_Packaging.");
                    }
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

            // Insert the new data into Stock_Packaging table and update mutasi_produk table
            InsertNewPackaging(namaBarang, jumlah, volume, harga);

            // Reload the data in dataGridViewStockPackaging and dataGridViewMutasiPackaging
            LoadStockPackagingData();
            LoadMutasiPackagingData();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.UpdateDataGridView(); // Call the update method on the main form
            this.Close(); // Close the current form
        }

        private void LoadMutasiPackagingData()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = @"SELECT m.ID, p.Nama_Barang AS Produk, m.Masuk, m.Keluar, m.Keterangan 
                     FROM mutasi_produk m
                     JOIN Stock_Packaging p ON m.Stock_PackagingID = p.ID
                     WHERE m.Stock_PackagingID IS NOT NULL";

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

            dataGridViewMutasiPackaging.DataSource = dataTable;
        }
    }
}

