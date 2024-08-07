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
        }

        private void LoadStockData()
        {
            DataTable dataTable = GetStockFilter();
            dataGridViewStock.DataSource = dataTable;
        }

        private DataTable GetStockFilter()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT * FROM Stock_Filter";

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

        private void btnInput_Click(object sender, EventArgs e)
        {
            // Get the input values
            string jenisFilter = textBoxNama.Text;
            int berat = (int)nudBerat.Value;
            int stokAwal = (int)nudStok.Value;
            long harga = (long)nudHarga.Value;

            // Insert the new data into Stock_Filter table
            InsertNewFilter(jenisFilter, berat, stokAwal, harga);

            // Reload the data in dataGridViewStock
            LoadStockData();
        }

        private void InsertNewFilter(string jenisFilter, int berat, int stokAwal, long harga)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "INSERT INTO Stock_Filter (Jenis_Filter, Berat, Jumlah, Harga_Per_Barang) VALUES (@jenisFilter, @berat, @stokAwal, @harga)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@jenisFilter", jenisFilter);
                    cmd.Parameters.AddWithValue("@berat", berat);
                    cmd.Parameters.AddWithValue("@stokAwal", stokAwal);
                    cmd.Parameters.AddWithValue("@harga", harga);

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

    }
}


