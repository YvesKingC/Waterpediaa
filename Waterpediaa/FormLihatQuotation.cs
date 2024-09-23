using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormLihatQuotation : Form
    {
        public FormLihatQuotation()
        {
            InitializeComponent();
        }

        static string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia;";
        private string sqlQuery;

        private void FormLihatQuotation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            sqlQuery = @"SELECT q.ID, q.Service_Order, q.Due_Date, c.Nama AS CustomerName, 
                 CASE
                     WHEN pb.ID IS NOT NULL THEN pb.Nama_Paket
                     ELSE IFNULL(sb.Jenis_Bakteri, IFNULL(sf.Jenis_Filter, ''))
                 END AS Product,
                 IFNULL(sp.Nama_Barang, '') AS Packaging,
                 q.Jumlah_Masuk, q.Harga_Jual, q.PPN, q.Terms_Conditions
             FROM Quotation q
             JOIN Customer c ON q.PembeliID = c.ID
             LEFT JOIN Stock_Bakteri sb ON q.Stock_BakteriID = sb.ID
             LEFT JOIN Stock_Packaging sp ON q.Stock_PackagingID = sp.ID
             LEFT JOIN Stock_Filter sf ON q.Stock_FilterID = sf.ID
             LEFT JOIN Paket_Bakteri pb ON q.Paket_BakteriID = pb.ID";


            try
            {
                using (MySqlConnection sqlConnect = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, sqlConnect))
                    {
                        sqlConnect.Open();
                        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        sqlAdapter.Fill(dataTable);
                        dataGridViewQuotation.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormQuotation = new FormBuatQuotation();
            FormQuotation.Show();
            this.Hide();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1).AddSeconds(-1);

            string query = "SELECT * FROM Quotation WHERE Service_Order BETWEEN @startDate AND @endDate";
            LoadFilteredData(query, startDate, endDate);
        }

        private void LoadFilteredData(string query, DateTime startDate, DateTime endDate)
        {
            sqlQuery = @"SELECT q.ID, q.Service_Order, q.Due_Date, c.Nama AS CustomerName, 
                 CASE
                     WHEN pb.ID IS NOT NULL THEN pb.Nama_Paket
                     ELSE IFNULL(sb.Jenis_Bakteri, IFNULL(sf.Jenis_Filter, ''))
                 END AS Product,
                 IFNULL(sp.Nama_Barang, '') AS Packaging,
                 q.Jumlah_Masuk, q.Harga_Jual, q.PPN, q.Terms_Conditions
             FROM Quotation q
             JOIN Customer c ON q.PembeliID = c.ID
             LEFT JOIN Stock_Bakteri sb ON q.Stock_BakteriID = sb.ID
             LEFT JOIN Stock_Packaging sp ON q.Stock_PackagingID = sp.ID
             LEFT JOIN Stock_Filter sf ON q.Stock_FilterID = sf.ID
             LEFT JOIN Paket_Bakteri pb ON q.Paket_BakteriID = pb.ID
             WHERE q.Service_Order BETWEEN @startDate AND @endDate";

            try
            {
                using (MySqlConnection sqlConnect = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand sqlCommand = new MySqlCommand(sqlQuery, sqlConnect))
                    {
                        sqlCommand.Parameters.AddWithValue("@startDate", startDate);
                        sqlCommand.Parameters.AddWithValue("@endDate", endDate);

                        sqlConnect.Open();
                        MySqlDataAdapter sqlAdapter = new MySqlDataAdapter(sqlCommand);
                        DataTable dataTable = new DataTable();
                        sqlAdapter.Fill(dataTable);
                        dataGridViewQuotation.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}