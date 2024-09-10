using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterpediaa
{
    public partial class FormTambahProcureBakteri : Form
    {
        private FormInventoryBakteri mainForm;

        public FormTambahProcureBakteri(FormInventoryBakteri form)
        {
            InitializeComponent();
            this.Load += new EventHandler(FormTambahProcureBakteri_Load);
            mainForm = form; // Corrected assignment
        }

        private void FormTambahProcureBakteri_Load(object sender, EventArgs e)
        {
            LoadStockBakteriData();
            LoadBakteriNames();
            LoadProcureData();
            LoadMutasiBakteriData();
        }

        private void LoadStockBakteriData()
        {
            DataTable dataTable = GetStockBakteri();
            dataGridViewStok.DataSource = dataTable;
        }

        private void LoadBakteriNames()
        {
            DataTable dataTable = GetStockBakteri();
            cBoxNamaBakteri.DataSource = dataTable;
            cBoxNamaBakteri.DisplayMember = "Jenis_Bakteri";
            cBoxNamaBakteri.ValueMember = "ID"; // Set ValueMember to ID
        }

        public DataTable GetStockBakteri()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
            string query = "SELECT ID, Jenis_Bakteri, Volume, Harga_Per_Liter FROM Stock_Bakteri;"; // Include ID

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

        private void btnInputBakteriBaru_Click(object sender, EventArgs e)
        {
            // Get the input values
            string namaBakteri = tBoxNamaBakteri.Text;
            int HPL = Convert.ToInt32(tBoxHargaPerLiter.Text);
            int hargaPerLiter = (int)HPL;
            int stockAwal = (int)numericUpDownVolume.Value;

            // Insert the new data into Stock_Bakteri table
            InsertNewBakteri(namaBakteri, hargaPerLiter, stockAwal);

            // Reload the data in dataGridViewStok
            LoadStockBakteriData();
        }

        private void InsertNewBakteri(string namaBakteri, int hargaPerLiter, int stockAwal)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "INSERT INTO Stock_Bakteri (Jenis_Bakteri, Volume, Harga_Per_Liter, Jenis_ProdukID) VALUES (@nama, @volume, @harga, @jenisProdukID)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nama", namaBakteri);
                    cmd.Parameters.AddWithValue("@volume", stockAwal);
                    cmd.Parameters.AddWithValue("@harga", hargaPerLiter);
                    cmd.Parameters.AddWithValue("@jenisProdukID", 1); // Set Jenis_ProdukID to 1

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.UpdateDataGridView(); // Call the update method on the main form
            this.Close(); // Close the current form
        }

        private void btnInputProcureBakteri_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = cBoxNamaBakteri.SelectedItem as DataRowView;
            if (selectedRow != null && selectedRow["ID"] != DBNull.Value)
            {
                int selectedBakteriId = Convert.ToInt32(selectedRow["ID"]);
                int volumeToAdd = (int)nudVolume.Value;
                DateTime selectedDate = dateTimePickerbakteri.Value;

                // Update the volume of the selected Bakteri and insert into Procure table
                UpdateBakteriVolume(selectedBakteriId, volumeToAdd, selectedDate);
            }
            else
            {
                MessageBox.Show("Please select a valid Bakteri.");
            }
        }

        private void UpdateBakteriVolume(int bakteriId, int volumeToAdd, DateTime tanggal)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string updateQuery = "UPDATE Stock_Bakteri SET Volume = Volume + @volumeToAdd WHERE ID = @id";
            string insertProcureQuery = "INSERT INTO Procure (Stock_BakteriID, Tanggal, Volume) VALUES (@bakteriId, @tanggal, @volumeToAdd)";
            string insertMutasiQuery = "INSERT INTO mutasi_produk (Stock_BakteriID, Masuk, Keluar, Keterangan) VALUES (@bakteriId, @masuk, @keluar, @keterangan)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.AddWithValue("@volumeToAdd", volumeToAdd);
                    updateCmd.Parameters.AddWithValue("@id", bakteriId);
                    updateCmd.ExecuteNonQuery();
                }

                using (MySqlCommand insertCmd = new MySqlCommand(insertProcureQuery, connection))
                {
                    insertCmd.Parameters.AddWithValue("@bakteriId", bakteriId);
                    insertCmd.Parameters.AddWithValue("@tanggal", tanggal);
                    insertCmd.Parameters.AddWithValue("@volumeToAdd", volumeToAdd);
                    insertCmd.ExecuteNonQuery();
                }

                using (MySqlCommand insertMutasiCmd = new MySqlCommand(insertMutasiQuery, connection))
                {
                    insertMutasiCmd.Parameters.AddWithValue("@bakteriId", bakteriId);
                    insertMutasiCmd.Parameters.AddWithValue("@masuk", volumeToAdd);
                    insertMutasiCmd.Parameters.AddWithValue("@keluar", 0); // Assuming this is an incoming stock, so 'Keluar' is 0
                    insertMutasiCmd.Parameters.AddWithValue("@keterangan", "Procurement"); // Description for the operation
                    insertMutasiCmd.ExecuteNonQuery();
                }
            }

            // Reload the data in dataGridViewStok, dataGridViewProcure, and dataGridViewMutasiBakteri
            LoadStockBakteriData();
            LoadProcureData();
            LoadMutasiBakteriData();
        }



        private void LoadProcureData()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = @"SELECT p.ID, s.Jenis_Bakteri AS Nama_Bakteri, p.Tanggal, p.Volume 
                             FROM Procure p
                             JOIN Stock_Bakteri s ON p.Stock_BakteriID = s.ID";

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

            dataGridViewProcure.DataSource = dataTable;
        }

        private void LoadMutasiBakteriData()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = @"SELECT m.ID, s.Jenis_Bakteri AS Produk, m.Masuk, m.Keluar, m.Keterangan 
                     FROM mutasi_produk m
                     JOIN Stock_Bakteri s ON m.Stock_BakteriID = s.ID
                     WHERE m.Stock_BakteriID IS NOT NULL";

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

            dataGridViewMutasiBakteri.DataSource = dataTable;
        }


    }
}
