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
    using MySql.Data.MySqlClient;
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class FormTambahBakteri : Form
    {
        private FormInventoryBakteri mainForm;

        public FormTambahBakteri(FormInventoryBakteri form)
        {
            InitializeComponent();
            this.Load += new EventHandler(FormTambahBakteri_Load);
            mainForm = form;
        }

        private void FormTambahBakteri_Load(object sender, EventArgs e)
        {
            LoadStockBakteriData();
        }

        private void LoadStockBakteriData()
        {
            DataTable dataTable = GetStockBakteri();
            dataGridViewStok.DataSource = dataTable;
        }

        public DataTable GetStockBakteri()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT * FROM Stock_Bakteri";

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
            string namaBakteri = textBoxNewBakteri.Text;
            int hargaPerLiter = (int)nudNewBakteri.Value;
            int stockAwal = (int)nudStokNewBakteri.Value;

            // Insert the new data into Stock_Bakteri table
            InsertNewBakteri(namaBakteri, hargaPerLiter, stockAwal);

            // Reload the data in dataGridViewStok
            LoadStockBakteriData();
        }

        private void InsertNewBakteri(string namaBakteri, int hargaPerLiter, int stockAwal)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "INSERT INTO Stock_Bakteri (Jenis_Bakteri, Volume, Harga_Per_Liter) VALUES (@nama, @volume, @harga)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nama", namaBakteri);
                    cmd.Parameters.AddWithValue("@volume", stockAwal);
                    cmd.Parameters.AddWithValue("@harga", hargaPerLiter);

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
