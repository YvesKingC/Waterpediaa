using Microsoft.Extensions.Logging;
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
    public partial class FormBuatInvoicePenjualan : Form
    {
        public FormBuatInvoicePenjualan()
        {
            InitializeComponent();
        }

        static string connectionString = "server=localhost;uid=root;pwd=;database=Waterpedia;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable TempTableInvoice = new DataTable();
        DataTable NewCustomer = new DataTable();
        DataTable Customer = new DataTable();
        DataTable Product = new DataTable();
        DataTable Provinsi = new DataTable();
        DataTable KabupatenKota = new DataTable();

        private void LoadData()
        {
            /*nanti akan pakai temporary table invoice*/
            TempTableInvoice.Clear();
            sqlQuery = "SELECT * FROM invoice_penjualan";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(TempTableInvoice);
            dataGridViewInvoice.DataSource = TempTableInvoice;
        }
        private void LoadcBoxProvinsi()
        {
            Customer.Clear();
            sqlQuery = "SELECT Nama_Provinsi FROM Provinsi";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Provinsi);
            cBoxProvinsi.DataSource = Provinsi;
            cBoxProvinsi.DisplayMember = "Provinsi";
        }
        private void LoadcBoxKabupatenKota()
        {
            Customer.Clear();
            sqlQuery = "SELECT Nama_KabupatenKota FROM Kabupaten_Kota Where ProvinsiID == '" + cBoxProvinsi + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(KabupatenKota);
            cBoxKabupatenKota.DataSource = KabupatenKota;
            cBoxKabupatenKota.DisplayMember = "Kabupaten_Kota";
        }
        private void LoadcBoxMetodePembayaran()
        {
            Customer.Clear();
            sqlQuery = "SELECT Metode FROM Metode_Pembayaran";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Customer);
            cBoxMetodePembayaran.DataSource = Customer;
            cBoxMetodePembayaran.DisplayMember = "Metode_Pembayaran";
        }
        private void NewCustomerData()
        {
            /*untuk insert new customernya, kabupaten kota dan 
             * provinsi belum selesai. masi perkiraan sekarang*/
            sqlConnect.Open();
            sqlQuery = "INSERT INTO Customer (Nama, Perusahaan, Contact, Alamat, Provinsi, Kabupaten_Kota) VALUES ('" + tBoxNamaCust.Text + "', '" + tBoxPerusahaan.Text + "', '" + tBoxContact.Text + "', '" + tBoxAlamat.Text + "', '" + cBoxProvinsi.Text + "', '" + cBoxKabupatenKota.Text + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
        private void FormBuatInvoicePenjualan_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcBoxProvinsi();
            LoadcBoxKabupatenKota();
        }
    }
}
