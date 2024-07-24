﻿using System;
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
    public partial class FormInventoryBakteri : Form
    {
        private MySqlConnection? connection;

        public FormInventoryBakteri()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.FormInventoryBakteri_Load);
        }

        private void FormInventoryBakteri_Load(object? sender, EventArgs e)
        {
            LoadStockBakteriData();
        }

        private void LoadStockBakteriData()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            connection = new MySqlConnection(connectionString);

            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Stock_Bakteri";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                OpenConnection();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                CloseConnection();
            }

            dgvInventoryBakteri.DataSource = dataTable;
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

        private void buttonAddBakteri_Click(object sender, EventArgs e)
        {
            // Create an instance of FormTambahBakteri and pass the current form as a parameter
            FormTambahBakteri formTambahBakteri = new FormTambahBakteri(this);

            // Show the FormTambahBakteri form as a modal dialog
            formTambahBakteri.ShowDialog();
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            if (dgvInventoryBakteri.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvInventoryBakteri.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                string name = selectedRow.Cells["Jenis_Bakteri"].Value.ToString();
                int volume = Convert.ToInt32(selectedRow.Cells["Volume"].Value);
                long harga = Convert.ToInt64(selectedRow.Cells["Harga_Per_Liter"].Value);

                // Create an instance of FormEditBakteri with parameters
                FormEditBakteri formEditBakteri = new FormEditBakteri(id, name, volume, harga);

                // Show the FormEditBakteri form as a modal dialog
                formEditBakteri.ShowDialog();

                // Reload data in dgvInventoryBakteri if needed
                LoadStockBakteriData();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }


        private void buttonAddPackaging_Click(object sender, EventArgs e)
        {
            FormPaketBakteri formPaketBakteri = new FormPaketBakteri();
            formPaketBakteri.ShowDialog();
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            FormBuatInvoicePenjualan formBuatInvoicePenjualan = new FormBuatInvoicePenjualan();
            formBuatInvoicePenjualan.ShowDialog();
        }
        public void UpdateDataGridView()
        {
            LoadStockBakteriData();
        }

    }


}
