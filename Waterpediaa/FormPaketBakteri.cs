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
    public partial class FormPaketBakteri : Form
    {
        private DataTable tempTable;
        public FormPaketBakteri()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormPaketBakteri_Load);
        }

        private void FormPaketBakteri_Load(object sender, EventArgs e)
        {
            LoadPaketData();
            LoadBakteriNames();
            LoadPackagingNames();
            LoadPilihPaket();
            LoadDeletePaket(); // Add this line to load data into comboBoxDelete
            InitializeTempTable();
        }

        private void LoadPaketData()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = @"SELECT pb.Nama_Paket, sb.Jenis_Bakteri, sp.Nama_Barang AS 'Jenis Packaging'
                             FROM Paket_Bakteri pb
                             JOIN Stock_Bakteri sb ON pb.Stock_BakteriID = sb.ID
                             JOIN Stock_Packaging sp ON pb.Stock_PackagingID = sp.ID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    dataGridViewPaket.DataSource = dataTable;

                    // Ensure Nama_Paket is the first column
                    dataGridViewPaket.Columns["Nama_Paket"].DisplayIndex = 0;

                    // Optionally, hide ID column if it's part of the query
                    // dataGridViewPaket.Columns["ID"].Visible = false;
                }
            }
        }

        private void LoadBakteriNames()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT ID, Jenis_Bakteri FROM Stock_Bakteri";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    comboBoxBakteri.DataSource = dataTable;
                    comboBoxBakteri.DisplayMember = "Jenis_Bakteri";
                    comboBoxBakteri.ValueMember = "ID";
                }
            }
        }

        private void LoadPackagingNames()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT ID, Nama_Barang FROM Stock_Packaging";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    comboBoxPackaging.DataSource = dataTable;
                    comboBoxPackaging.DisplayMember = "Nama_Barang";
                    comboBoxPackaging.ValueMember = "ID";
                }
            }
        }

        private void LoadPilihPaket()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT ID, Nama_Paket FROM Paket_Bakteri";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    comboBoxPilihPaket.DataSource = dataTable;
                    comboBoxPilihPaket.DisplayMember = "Nama_Paket";
                    comboBoxPilihPaket.ValueMember = "ID";
                }
            }
        }

        private void LoadDeletePaket()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "SELECT ID, Nama_Paket FROM Paket_Bakteri";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                    comboBoxDelete.DataSource = dataTable;
                    comboBoxDelete.DisplayMember = "Nama_Paket";
                    comboBoxDelete.ValueMember = "ID";
                }
            }
        }

        private void InitializeTempTable()
        {
            tempTable = new DataTable();
            tempTable.Columns.Add("Stock_BakteriID", typeof(int));
            tempTable.Columns.Add("Stock_PackagingID", typeof(int));
            tempTable.Columns.Add("Nama_Paket", typeof(string));

            dataGridViewTemp.DataSource = tempTable;
        }

        private void buttonBuat_Click(object sender, EventArgs e)
        {
            string namaPaket = textBoxNamaPaket.Text;

            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "INSERT INTO Paket_Bakteri (Nama_Paket) VALUES (@namaPaket)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@namaPaket", namaPaket);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            LoadPaketData();
            LoadPilihPaket(); // Load the new package into comboBoxPilihPaket
            LoadDeletePaket(); // Load the new package into comboBoxDelete
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DataRowView selectedPaket = comboBoxPilihPaket.SelectedItem as DataRowView;
            DataRowView selectedBakteri = comboBoxBakteri.SelectedItem as DataRowView;
            DataRowView selectedPackaging = comboBoxPackaging.SelectedItem as DataRowView;

            if (selectedPaket != null && selectedBakteri != null && selectedPackaging != null)
            {
                DataRow newRow = tempTable.NewRow();
                newRow["Stock_BakteriID"] = selectedBakteri["ID"];
                newRow["Stock_PackagingID"] = selectedPackaging["ID"];
                newRow["Nama_Paket"] = selectedPaket["Nama_Paket"];

                tempTable.Rows.Add(newRow);
            }
        }

        private void buttonNewPaket_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            string query = "INSERT INTO Paket_Bakteri (Stock_BakteriID, Stock_PackagingID, Nama_Paket) " +
                           "VALUES (@stockBakteriID, @stockPackagingID, @namaPaket)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataRow row in tempTable.Rows)
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@stockBakteriID", row["Stock_BakteriID"]);
                        cmd.Parameters.AddWithValue("@stockPackagingID", row["Stock_PackagingID"]);
                        cmd.Parameters.AddWithValue("@namaPaket", row["Nama_Paket"]);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            LoadPaketData();
            tempTable.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DataRowView selectedPaket = comboBoxDelete.SelectedItem as DataRowView;

            if (selectedPaket != null)
            {
                string namaPaket = selectedPaket["Nama_Paket"].ToString();
                string connectionString = "server=localhost;database=waterpedia;user=root;";
                string query = "DELETE FROM Paket_Bakteri WHERE Nama_Paket = @namaPaket";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@namaPaket", namaPaket);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadPaketData();      // Refresh the data in dataGridViewPaket
                LoadDeletePaket();    // Refresh the data in comboBoxDelete
                LoadPilihPaket();     // Refresh the data in comboBoxPilihPaket if needed
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
