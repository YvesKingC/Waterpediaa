using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterpediaa
{
    public partial class FormBuatReceipt : Form
    {
        public FormBuatReceipt()
        {
            InitializeComponent();
        }
        static string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable InvoiceID = new DataTable();
        DataTable Customer = new DataTable();
        DataTable Provinsi = new DataTable();
        DataTable KabupatenKota = new DataTable();

        public int provinsiID = 0;
        public int kabupatenKotaID = 0;
        public long Subtotal = 0;
        public int PPNPercentage = 0;
        public long PPN = 0;
        public long Total = 0;
        public string namaCustomer;
        public string perusahaan;
        public string alamat;

        public DateTime receiptDate;
        public string OtherComments;
        public string NamaTTd;

        public int parentInvID;
        public int parentID;
        private void FormBuatReceipt_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            LoadInvoiceList();
            LoadData();
            LoadData2();
            LoadcBoxCustomer();
            LoadcBoxProvinsi();
            LoadcBoxKabupatenKota();
            HitungTotalSubtotal();
        }
        private void LoadData()
        {
            try
            {
                dt.Clear();
                sqlQuery = "SELECT * FROM Invoice WHERE parentInvID = @parentInvID";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

                parentInvID = Convert.ToInt32(cBoxParentInvID.Text);
                sqlCommand.Parameters.AddWithValue("@parentInvID", parentInvID);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                sqlAdapter.Fill(dt);
                dataGridViewReceipt.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData2()
        {
            try
            {
                dt2.Clear();
                sqlQuery = @"
    SELECT 
        CONCAT_WS(', ',
            CASE WHEN sb.Jenis_Bakteri IS NOT NULL THEN sb.Jenis_Bakteri END,
            CASE WHEN sf.Jenis_Filter IS NOT NULL THEN sf.Jenis_Filter END,
            CASE WHEN pb.Nama_Paket IS NOT NULL THEN pb.Nama_Paket END
        ) AS Product,
        sp.Nama_Barang AS Packaging,
        i.Jumlah_Keluar AS QTY,
        i.Harga_Jual AS Harga
    FROM 
        Invoice i
    LEFT JOIN 
        Stock_Bakteri sb ON i.Stock_BakteriID = sb.ID
    LEFT JOIN 
        Stock_Filter sf ON i.Stock_FilterID = sf.ID
    LEFT JOIN 
        Paket_Bakteri pb ON i.Paket_BakteriID = pb.ID
    LEFT JOIN 
        Stock_Packaging sp ON i.Stock_PackagingID = sp.ID
    WHERE 
        i.ParentInvID = @parentInvID";

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

                parentInvID = Convert.ToInt32(cBoxParentInvID.Text);
                sqlCommand.Parameters.AddWithValue("@parentInvID", parentInvID);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);

                sqlAdapter.Fill(dt2);
                dataGridViewReceipt2.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadInvoiceList()
        {
            sqlQuery = "SELECT Distinct parentInvID FROM Invoice";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(InvoiceID);
            cBoxParentInvID.DataSource = InvoiceID;
            cBoxParentInvID.DisplayMember = "parentInvID";
        }

        private void btnAddNewCustomer_Click_1(object sender, EventArgs e)
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
        private void cBoxProvinsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadcBoxKabupatenKota();
        }
        public void HitungTotalSubtotal()
        {
            Subtotal = dt.AsEnumerable().Sum(row => row.Field<long>("Harga_Jual"));
            lblSubTotal.Text = "SubTotal  : " + Subtotal.ToString();

            PPN = dt.AsEnumerable().Max(row => Convert.ToInt64(row.Field<int>("PPN")));
            lblPPN.Text = "PPN : " + PPN.ToString();

            Total = Subtotal + PPN;
            lblTotal.Text = "Total  : " + Total.ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
            this.Close();

            sqlConnect.Close();
        }
        private void LoadCustomerData(int customerId)
        {
            try
            {
                namaCustomer = cBoxCustomer.Text;

                sqlQuery = "SELECT Perusahaan, Alamat FROM Customer WHERE Nama = @NamaCustomer";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@NamaCustomer", namaCustomer);

                using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        perusahaan = reader["Perusahaan"].ToString();
                        alamat = reader["Alamat"].ToString();
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreatePDF_Click_1(object sender, EventArgs e)
        {
            if (dt2.Rows.Count == 0)
            {
                MessageBox.Show("No data available to create a receipt.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the Receipt Date and Remarks from the form
            DateTime receiptDate = dtpReceiptDate.Value;
            string otherComments = tBoxOtherComments.Text;

            NamaTTd = tBoxTTD.Text;
            parentID = Convert.ToInt32(cBoxParentInvID.Text);

            LoadCustomerData(parentID);
            try
            {
                // Save data to use in FormReceipt
                FormReceipt formReceipt = new FormReceipt
                {
                    Subtotal = Subtotal,
                    PPNPercentage = PPNPercentage,
                    PPN = PPN,
                    Total = Total,
                    DataTable = dt2,
                    parentInvID = parentID,
                    receiptDate = receiptDate,
                    OtherComment = otherComments,
                    NamaTTd = NamaTTd,
                    NamaCustomer = namaCustomer,
                    Perusahaan = perusahaan,
                    Alamat = alamat
                };
                foreach (DataRow row in dt.Rows)
                {
                    int invoiceID = Convert.ToInt32(row["ID"]);

                    // SQL Query to insert data into the Receipt table
                    sqlQuery = "INSERT INTO Receipt (InvoiceID, Receipt_Date, Other_Comments) " +
                               "VALUES (@InvoiceID, @Receipt_Date, @Other_Comments)";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

                    // Add parameters to the SQL Command
                    sqlCommand.Parameters.AddWithValue("@InvoiceID", invoiceID);
                    sqlCommand.Parameters.AddWithValue("@Receipt_Date", receiptDate);
                    sqlCommand.Parameters.AddWithValue("@Other_Comments", otherComments);

                    sqlCommand.ExecuteNonQuery();
                }
                MessageBox.Show("Receipt(s) saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                formReceipt.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the receipt(s): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadData2();
            HitungTotalSubtotal();
        }
    }
}
