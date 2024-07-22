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
using System.Transactions;
using System.Web;
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

        DataTable dt = new DataTable();
        DataTable Metode = new DataTable();
        DataTable Customer = new DataTable();
        DataTable Product = new DataTable();
        DataTable Provinsi = new DataTable();
        DataTable KabupatenKota = new DataTable();


        private void FormBuatInvoicePenjualan_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            LoadData();
            LoadcBoxProvinsi();
            LoadcBoxCustomer();
            LoadcBoxJenisProduct();
            LoadMetode();

            numericUpDownPPN.Value = 11;    
        }
        private void formBuatInvoicePenjualan_Closed(object sender, FormClosedEventArgs e)
        {
            sqlConnect.Close();
        }
        private void LoadData()
        {
            sqlQuery = @"
                CREATE TEMPORARY TABLE IF NOT EXISTS TempInvoice (
                    ID INT AUTO_INCREMENT PRIMARY KEY,
                    Nama_Barang VARCHAR(255),
                    Packaging VARCHAR(255),
                    Quantity INT,
                    Harga_Jual BIGINT
                );";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            sqlQuery = "select * from TempInvoice";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(dt);
            dataGridViewInvoice.DataSource = dt;
        }
        private void LoadMetode()
        {
            Metode.Clear();
            sqlQuery = "SELECT Metode FROM Metode_Pembayaran";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Metode);
            cBoxMetodePembayaran.DataSource = Customer;
            cBoxMetodePembayaran.DisplayMember = "Metode_Pembayaran";
        }
        private void LoadcBoxProvinsi()
        {
            Provinsi.Clear();
            sqlQuery = "SELECT Nama_Provinsi FROM Provinsi";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Provinsi);
            cBoxProvinsi.DataSource = Provinsi;
            cBoxProvinsi.DisplayMember = "Provinsi";

            KabupatenKota.Clear();
            sqlQuery = "SELECT Kabupaten_Kota.Nama_KabupatenKota " +
                       "FROM Kabupaten_Kota " +
                       "JOIN Provinsi ON Kabupaten_Kota.ProvinsiID = Provinsi.ID " +
                       "WHERE Provinsi.Nama_Provinsi = 'Jawa Timur'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(KabupatenKota);
            cBoxKabupatenKota.DataSource = KabupatenKota;
            cBoxKabupatenKota.DisplayMember = "Nama_KabupatenKota";
        }
        private void LoadcBoxCustomer()
        {
            Customer.Clear();
            sqlQuery = "SELECT Nama FROM Customer";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Customer);
            cBoxCustomer.DataSource = Customer;
            cBoxCustomer.DisplayMember = "Nama";
        }
        private void LoadcBoxJenisProduct()
        {
            Product.Clear();
            sqlQuery = "SELECT Jenis_Produk FROM Jenis_Produk";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Product);
            cBoxJenisProduk.DataSource = Product;
            cBoxJenisProduk.DisplayMember = "Jenis_Produk";
        }

        /*Masalah di add new customer, karena perlu join joinan*/
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            var ids = GetIDs(cBoxProvinsi.Text, cBoxKabupatenKota.Text);
            sqlQuery = "INSERT INTO Customer (Nama, Perusahaan, Contact, Alamat, Provinsi, Kabupaten_Kota, Zipcode) VALUES ('" + tBoxNamaCust.Text + "', '" + tBoxPerusahaan.Text + "', '" + tBoxContact.Text + "', '" + tBoxAlamat.Text + "', '" + ids.ProvinsiID + "', '" + ids.KabupatenKotaID + "',  '" + ids.ProvinsiID + "', '" + ids.KabupatenKotaID + "', '" + tBoxZipCode.Text + "',)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            LoadcBoxCustomer();
        }
        private (int ProvinsiID, int KabupatenKotaID) GetIDs(string namaProvinsi, string namaKabupatenKota)
        {
            int provinsiID = 0;
            int kabupatenKotaID = 0;
            using (var transaction = sqlConnect.BeginTransaction())
            {
                // Retrieve ProvinsiID
                sqlCommand = new MySqlCommand("SELECT ID FROM Provinsi WHERE Nama_Provinsi = @Nama_Provinsi", sqlConnect, transaction);
                sqlCommand.Parameters.AddWithValue("@Nama_Provinsi", namaProvinsi);
                var result = sqlCommand.ExecuteScalar();
                if (result != null)
                {
                    provinsiID = Convert.ToInt32(result);
                }

                // Retrieve Kabupaten_KotaID
                sqlCommand = new MySqlCommand("SELECT ID FROM Kabupaten_Kota WHERE Nama_KabupatenKota = @Nama_KabupatenKota", sqlConnect, transaction);
                sqlCommand.Parameters.AddWithValue("@Nama_KabupatenKota", namaKabupatenKota);
                result = sqlCommand.ExecuteScalar();
                if (result != null)
                {
                    kabupatenKotaID = Convert.ToInt32(result);
                }

                transaction.Commit();
            }

            return (provinsiID, kabupatenKotaID);
        }


        private void btnAddProduk_Click(object sender, EventArgs e)
        {
            sqlQuery = "INSERT INTO TempInvoice (Nama_Barang, Packaging, Quantity, Harga_Jual) VALUES ('" + cBoxNamaProduk.Text + "', '" + cBoxPackaging.Text + "', '" + numericUpDownQTY.Text + "', '" + tBoxHargaJual.Text + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            LoadData();
            HitungTotalSubtotal();


        }
        private void HitungTotalSubtotal()
        {
            long Subtotal = 0;
            foreach (DataRow row in dt.Rows)
            {
                Subtotal += Convert.ToInt64(row["Harga_Jual"]);
            }
            lblSubTotal.Text = "SubTotal  : " + Subtotal.ToString();

            int PPNPercentage = Convert.ToInt32(numericUpDownPPN.Text);
            long PPN = Subtotal * PPNPercentage / 100;
            lblPPN.Text = "  : " + PPN.ToString();

            long Total = Subtotal + PPN;
            lblTotal.Text = "Total  : " + Total.ToString();
        }
    }
}
