using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        DataTable NamaProduct = new DataTable();
        DataTable Packaging = new DataTable();
        DataTable Provinsi = new DataTable();
        DataTable KabupatenKota = new DataTable();

        public int provinsiID = 0;
        public int kabupatenKotaID = 0;
        public long Subtotal = 0;
        public int PPNPercentage = 0;
        public long PPN = 0;
        public long Total = 0;
        public static string MetodePembayaran = "";
        public static string NamaCustomer = "";
        public static string Perusahaan = "";
        public static string Alamat = "";
        public static string ServiceOrder = "";
        public static string DueDate = "";
        public static string OtherComment = "";
        public string parentInvID = "";

        private void FormBuatInvoicePenjualan_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            LoadData();
            LoadcBoxProvinsi();
            LoadcBoxKabupatenKota();
            LoadcBoxCustomer();
            LoadcBoxJenisProduct();
            LoadcBoxNamaBarang();
            LoadcBoxPackaging();
            LoadMetode();

            numericUpDownPPN.Value = 11;
        }
        private void formBuatInvoicePenjualan_Closed(object sender, FormClosedEventArgs e)
        {
            sqlConnect.Close();
        }
        public void LoadData()
        {
            dt.Clear();
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
            cBoxMetodePembayaran.DataSource = Metode;
            cBoxMetodePembayaran.DisplayMember = "Metode";
        }
        private void LoadcBoxProvinsi()
        {
            Provinsi.Clear();
            sqlQuery = "SELECT Nama_Provinsi FROM Provinsi";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(Provinsi);
            cBoxProvinsi.DataSource = Provinsi;
            cBoxProvinsi.DisplayMember = "Nama_Provinsi";
        }
        private void LoadcBoxKabupatenKota()
        {
            KabupatenKota.Clear();
            sqlQuery = "SELECT Kabupaten_Kota.Nama_KabupatenKota " +
                       "FROM Kabupaten_Kota " +
                       "JOIN Provinsi ON Kabupaten_Kota.ProvinsiID = Provinsi.ID " +
                       "WHERE Provinsi.Nama_Provinsi = '" + cBoxProvinsi.Text + "'";
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
        private void LoadcBoxNamaBarang()
        {
            NamaProduct.Clear();
            if (cBoxJenisProduk.Text == "Bakteri")
            {
                sqlQuery = "SELECT Jenis_Bakteri FROM Stock_Bakteri";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(NamaProduct);
                cBoxNamaProduk.DataSource = NamaProduct;
                cBoxNamaProduk.DisplayMember = "Jenis_Bakteri";
            }
            else if (cBoxJenisProduk.Text == "WTP")
            {
                sqlQuery = "SELECT Jenis_FIlter FROM Stock_Filter";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(NamaProduct);
                cBoxNamaProduk.DataSource = NamaProduct;
                cBoxNamaProduk.DisplayMember = "Jenis_Filter";
            }
            else if (cBoxJenisProduk.Text == "Paket Bakteri")
            {
                sqlQuery = "SELECT Nama_Paket FROM Paket_Bakteri";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(NamaProduct);
                cBoxNamaProduk.DataSource = NamaProduct;
                cBoxNamaProduk.DisplayMember = "Nama_Paket";
            }
        }
        private void LoadcBoxPackaging()
        {
            sqlQuery = "SELECT Nama_Barang FROM Stock_Packaging";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Packaging);
            cBoxPackaging.DataSource = Packaging;
            cBoxPackaging.DisplayMember = "Nama_Barang";
        }
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^\d+$");
            if (string.IsNullOrWhiteSpace(tBoxNamaCust.Text) || string.IsNullOrWhiteSpace(tBoxPerusahaan.Text) || string.IsNullOrWhiteSpace(tBoxContact.Text) || string.IsNullOrWhiteSpace(tBoxAlamat.Text))
            {
                MessageBox.Show("Fields must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ids = GetIDs(cBoxProvinsi.Text, cBoxKabupatenKota.Text);
            sqlQuery = "INSERT INTO Customer (Nama, Perusahaan, Contact, Alamat, ProvinsiID, Kabupaten_KotaID, Zipcode) VALUES ('" + tBoxNamaCust.Text + "', '" + tBoxPerusahaan.Text + "', '" + tBoxContact.Text + "', '" + tBoxAlamat.Text + "', '" + ids.ProvinsiID + "', '" + ids.KabupatenKotaID + "', '" + tBoxZipCode.Text + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadcBoxCustomer();
        }
        private (int ProvinsiID, int KabupatenKotaID) GetIDs(string namaProvinsi, string namaKabupatenKota)
        {
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
            if (int.TryParse(tBoxHargaJual.Text, out _) == false || string.IsNullOrWhiteSpace(tBoxHargaJual.Text))
            {
                MessageBox.Show("Harga Jual must not be empty and must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            sqlQuery = "INSERT INTO TempInvoice (Nama_Barang, Packaging, Quantity, Harga_Jual) VALUES ('" + cBoxNamaProduk.Text + "', '" + cBoxPackaging.Text + "', '" + numericUpDownQTY.Text + "', '" + tBoxHargaJual.Text + "')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            LoadData();
            HitungTotalSubtotal();
        }
        public void HitungTotalSubtotal()
        {
            Subtotal = 0;
            foreach (DataRow row in dt.Rows)
            {
                Subtotal += Convert.ToInt64(row["Harga_Jual"]);
            }
            lblSubTotal.Text = "SubTotal  : " + Subtotal.ToString();

            int PPNPercentage = Convert.ToInt32(numericUpDownPPN.Text);
            PPN = Subtotal * PPNPercentage / 100;
            lblPPN.Text = "  : " + PPN.ToString();

            Total = Subtotal + PPN;
            lblTotal.Text = "Total  : " + Total.ToString();
        }
        private void cBoxProvinsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcBoxKabupatenKota();
        }
        private void btnCreatePDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cBoxMetodePembayaran.Text) || string.IsNullOrWhiteSpace(cBoxCustomer.Text))
                {
                    MessageBox.Show("All fields must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MetodePembayaran = cBoxMetodePembayaran.Text;
                NamaCustomer = cBoxCustomer.Text;

                sqlQuery = "SELECT Perusahaan, Alamat FROM Customer WHERE Nama = '" + NamaCustomer + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Perusahaan = reader["Perusahaan"].ToString();
                    Alamat = reader["Alamat"].ToString();
                }
                reader.Close();

                ServiceOrder = dtpServiceOrder.Value.ToString("yyyy-MM-dd");
                DueDate = dtpDueDate.Value.ToString("yyyy-MM-dd");
                OtherComment = tBoxOtherComments.Text;

                DataTable invoiceTable = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    invoiceTable.ImportRow(row);
                }
                AddAllToInvoiceDT();
                FormInvoice FormInvoice = new FormInvoice
                {
                    confimPayment = tBoxConfirmPayment.Text,
                    MetodePembayaran = MetodePembayaran,
                    NamaCustomer = NamaCustomer,
                    Perusahaan = Perusahaan,
                    Alamat = Alamat,
                    ServiceOrder = ServiceOrder,
                    DueDate = DueDate,
                    OtherComment = OtherComment,
                    Subtotal = Subtotal,
                    StringPPN = PPN,
                    StringTotal = Total,
                    DataTable = invoiceTable,
                    parentInvID = parentInvID
                };
                FormInvoice.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoice.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewInvoice.SelectedRows)
                {
                    sqlQuery = "DELETE FROM TempInvoice WHERE ID = '" + row.Cells[0].Value + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                }
                LoadData();
                HitungTotalSubtotal();
            }
        }

        /*dibuat gpt semoga works*/
        private void AddAllToInvoiceDT()
        {
            try
            {
                // Generate ParentInvID
                string todayDate = DateTime.Now.ToString("yyMMdd");
                parentInvID = GetNextParentInvID(todayDate);

                // Retrieve PembeliID based on customer name
                int pembeliID = GetCustomerID(cBoxCustomer.Text);

                // Retrieve Metode_PembayaranID based on payment method
                int metodePembayaranID = GetMetodePembayaranID(cBoxMetodePembayaran.Text);

                foreach (DataRow row in dt.Rows)
                {
                    int? stockBakteriID = GetStockBakteriID(row["Nama_Barang"].ToString());
                    int? paketBakteriID = GetPaketBakteriID(row["Nama_Barang"].ToString());
                    int? stockFilterID = GetStockFilterID(row["Nama_Barang"].ToString());
                    int? stockPackagingID = GetStockPackagingID(row["Packaging"].ToString());

                    sqlQuery = @"
                INSERT INTO Invoice (ParentInvID, Stock_BakteriID, Paket_BakteriID, Stock_FilterID, Stock_PackagingID, PembeliID, Service_Order, Due_Date, Jumlah_Keluar, Harga_Jual, Metode_PembayaranID, PPN, Other_Comments)
                VALUES (@ParentInvID, @Stock_BakteriID, @PaketBakteriID, @StockFilterID, @StockPackagingID, @PembeliID, @ServiceOrder, @DueDate, @JumlahKeluar, @HargaJual, @MetodePembayaranID, @PPN, @OtherComments)";

                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.Parameters.AddWithValue("@ParentInvID", parentInvID);
                    sqlCommand.Parameters.AddWithValue("@Stock_BakteriID", stockBakteriID.HasValue ? (object)stockBakteriID.Value : DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@PaketBakteriID", paketBakteriID.HasValue ? (object)paketBakteriID.Value : DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@StockFilterID", stockFilterID.HasValue ? (object)stockFilterID.Value : DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@StockPackagingID", stockPackagingID.HasValue ? (object)stockPackagingID.Value : DBNull.Value);
                    sqlCommand.Parameters.AddWithValue("@PembeliID", pembeliID);
                    sqlCommand.Parameters.AddWithValue("@ServiceOrder", dtpServiceOrder.Value.ToString("yyyy-MM-dd"));
                    sqlCommand.Parameters.AddWithValue("@DueDate", dtpDueDate.Value.ToString("yyyy-MM-dd"));
                    sqlCommand.Parameters.AddWithValue("@JumlahKeluar", Convert.ToInt32(row["Quantity"]));
                    sqlCommand.Parameters.AddWithValue("@HargaJual", Convert.ToInt64(row["Harga_Jual"]));
                    sqlCommand.Parameters.AddWithValue("@MetodePembayaranID", metodePembayaranID);
                    sqlCommand.Parameters.AddWithValue("@PPN", Convert.ToInt32(PPN));
                    sqlCommand.Parameters.AddWithValue("@OtherComments", OtherComment ?? (object)DBNull.Value);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the invoice: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnect.Close();
            }
        }
        private int GetCustomerID(string customerName)
        {
            sqlQuery = "SELECT ID FROM Customer WHERE Nama = @NamaCustomer";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@NamaCustomer", customerName);
            var result = sqlCommand.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        private int GetMetodePembayaranID(string metodePembayaran)
        {
            sqlQuery = "SELECT ID FROM Metode_Pembayaran WHERE Metode = @MetodePembayaran";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@MetodePembayaran", metodePembayaran);
            var result = sqlCommand.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        private string GetNextParentInvID(string todayDate)
        {
            string lastInvID = "";
            int nextInvNumber = 1;

            sqlQuery = "SELECT ParentInvID FROM Invoice WHERE ParentInvID LIKE @TodayDate ORDER BY ParentInvID DESC LIMIT 1";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@TodayDate", todayDate + "%");
            var result = sqlCommand.ExecuteScalar();
            if (result != null)
            {
                lastInvID = result.ToString();
                string lastInvNumberStr = lastInvID.Substring(6); // Get the last 2 digits
                int lastInvNumber = int.Parse(lastInvNumberStr);
                nextInvNumber = lastInvNumber + 1;
            }

            return todayDate + nextInvNumber.ToString("D2"); // Format to ensure two digits, e.g., 01, 02, etc.
        }

        private int? GetStockBakteriID(string namaBakteri)
        {
            sqlQuery = "SELECT ID FROM Stock_Bakteri WHERE Jenis_Bakteri = @NamaBakteri";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@NamaBakteri", namaBakteri);
            var result = sqlCommand.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : (int?)null;
        }

        private int? GetPaketBakteriID(string namaPaket)
        {
            sqlQuery = "SELECT ID FROM Paket_Bakteri WHERE Nama_Paket = @NamaPaket";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@NamaPaket", namaPaket);
            var result = sqlCommand.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : (int?)null;
        }

        private int? GetStockFilterID(string jenisFilter)
        {
            sqlQuery = "SELECT ID FROM Stock_Filter WHERE Jenis_Filter = @JenisFilter";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@JenisFilter", jenisFilter);
            var result = sqlCommand.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : (int?)null;
        }

        private int? GetStockPackagingID(string namaBarang)
        {
            sqlQuery = "SELECT ID FROM Stock_Packaging WHERE Nama_Barang = @NamaBarang";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.AddWithValue("@NamaBarang", namaBarang);
            var result = sqlCommand.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : (int?)null;
        }

        private void btnUpdateJenis_Click(object sender, EventArgs e)
        {
            LoadcBoxNamaBarang();
        }
    }
}
