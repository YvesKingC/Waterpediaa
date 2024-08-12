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
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormSales_Load);
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            LoadSalesData(); // Load all sales data initially
        }

        private void LoadSalesData(string query = "SELECT * FROM sales_biasa")
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";

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

            dataGridViewSales.DataSource = dataTable;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date; // Start date at 00:00:00
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1); // End date at 23:59:59

            string query = "SELECT * FROM sales_biasa WHERE Tanggal BETWEEN @startDate AND @endDate";
            LoadSalesDataWithFilter(query, startDate, endDate);
        }


        private void LoadSalesDataWithFilter(string query, DateTime startDate, DateTime endDate)
        {
            DataTable dataTable = new DataTable();
            string connectionString = "server=localhost;database=waterpedia;user=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);

                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            dataGridViewSales.DataSource = dataTable;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            LoadSalesData(); // Reload all data without any filters
        }
    }
}
