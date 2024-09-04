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
    public partial class FormInventoryWTP : Form
    {
        private MySqlConnection connection;

        public FormInventoryWTP()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormInventoryWTP_Load);
        }

        private void FormInventoryWTP_Load(object sender, EventArgs e)
        {
            LoadWTPData();
        }

        public void LoadWTPData()
        {
            string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
            connection = new MySqlConnection(connectionString);

            DataTable dataTable = new DataTable();
            string query = "SELECT ID, Jenis_Filter, Jumlah, Berat, Harga_Per_Barang FROM Stock_Filter";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                OpenConnection();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                CloseConnection();
            }

            dataGridViewWTP.DataSource = dataTable;
            dataGridViewWTP.Columns["ID"].Visible = false; // Hide the ID column
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

        private void buttonEditWTP_Click(object sender, EventArgs e)
        {
            if (dataGridViewWTP.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewWTP.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string name = selectedRow.Cells["Jenis_Filter"].Value.ToString();
                int jumlah = Convert.ToInt32(selectedRow.Cells["Jumlah"].Value);
                long harga = Convert.ToInt64(selectedRow.Cells["Harga_Per_Barang"].Value);

                // Create an instance of FormEditWTP with 4 parameters
                FormEditWTP formEditWTP = new FormEditWTP(id, name, jumlah, harga);

                // Show the FormEditWTP form as a modal dialog
                formEditWTP.ShowDialog();

                // Reload data in dataGridViewWTP if needed
                LoadWTPData();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }


        public void UpdateDataGridView()
        {
            LoadWTPData();
        }

        private void buttonNewfilter_Click(object sender, EventArgs e)
        {
            // Create an instance of FormTambahWTP
            FormTambahWTP formTambahWTP = new FormTambahWTP(this);

            // Show the FormTambahWTP form as a modal dialog
            formTambahWTP.ShowDialog();

            // Reload data in dataGridViewWTP if needed
            LoadWTPData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormPilihDivisi formPilihDivisi = new FormPilihDivisi();
            formPilihDivisi.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            FormBuatInvoicePenjualan formBuatInvoicePenjualan = new FormBuatInvoicePenjualan();
            formBuatInvoicePenjualan.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void buttonPackaging_Click(object sender, EventArgs e)
        {
            FormInventoryPackaging formInventoryPackaging = new FormInventoryPackaging();
            formInventoryPackaging.ShowDialog();
            this.Close();
            this.Hide();
        }
    }
}

