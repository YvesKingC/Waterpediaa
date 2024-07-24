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
            LoadBakteriNames();
            LoadProcureData();
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
            cBoxNamaBakteri.ValueMember = "ID"; // Assuming ID is the primary key
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

        private void btnInputProcureBakteri_Click(object sender, EventArgs e)
        {
            int selectedBakteriId = (int)cBoxNamaBakteri.SelectedValue;
            int volumeToAdd = (int)nudVolume.Value;
            DateTime selectedDate = dateTimePickerbakteri.Value;

            // Update the volume of the selected Bakteri and insert into Procure table
            UpdateBakteriVolume(selectedBakteriId, volumeToAdd, selectedDate);
        }


        private void UpdateBakteriVolume(int bakteriId, int volumeToAdd, DateTime tanggal)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string updateQuery = "UPDATE Stock_Bakteri SET Volume = Volume + @volumeToAdd WHERE ID = @id";
            string insertProcureQuery = "INSERT INTO Procure (Stock_BakteriID, Tanggal, Volume) VALUES (@bakteriId, @tanggal, @volumeToAdd)";

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
            }

            // Reload the data in dataGridViewStok and dataGridViewProcure
            LoadStockBakteriData();
            LoadProcureData();
        }
        private void LoadProcureData()
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT * FROM Procure";

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



    }


}
