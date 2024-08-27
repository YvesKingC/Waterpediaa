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
using System.Windows.Forms;

namespace Waterpediaa
{
    public partial class FormBuatReceipt : Form
    {
        public FormBuatReceipt()
        {
            InitializeComponent();
        }
        static string connectionString = "server=localhost;uid=root;pwd=;database=Waterpedia;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable dt = new DataTable();
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

        private void FormBuatReceipt_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            LoadData();
            LoadcBoxCustomer();
            LoadcBoxProvinsi();
            LoadcBoxKabupatenKota();
            LoadInvoiceList();

            numericUpDownPPN.Value = 11;
        }
        private void LoadData()
        {
            dt.Clear();
            sqlQuery = "SELECT * FROM Invoice WHERE parentInvID = '" + cBoxInvoiceID.Text + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(dt);
            dataGridViewReceipt.DataSource = dt;

        }
        private void LoadInvoiceList()
        {
            sqlQuery = "SELECT Distinct parentInvID FROM Invoice";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            sqlAdapter.Fill(InvoiceID);
            cBoxInvoiceID.DataSource = InvoiceID;
            cBoxInvoiceID.DisplayMember = "parentInvID";
        }
        private void LoadInvoiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
        }

        private void btnCreatePDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cBoxInvoiceID.Text))
            {
                MessageBox.Show("Please select an Invoice ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected Invoice ID
            int selectedInvoiceID = Convert.ToInt32(cBoxInvoiceID.Text);

            // Get the Receipt Date and Remarks from the form
            DateTime receiptDate = dtpReceiptDate.Value;
            string OtherComments = tBoxOtherComments.Text;

            // get the name of the person who signed the receipt
            string NamaTTd = tBoxTTD.Text;
            string namaCustomer = cBoxCustomer.Text;
            string perusahaan = tBoxPerusahaan.Text;
            string alamat = tBoxAlamat.Text;

            // SQL Query to insert data into the Receipt table
            sqlQuery = "INSERT INTO Receipt (InvoiceID, Receipt_Date, Other_Comments) " +
                        "VALUES (@InvoiceID, @Receipt_Date, @Other_Comments)";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);

            // Add parameters to the SQL Command
            sqlCommand.Parameters.AddWithValue("@InvoiceID", selectedInvoiceID);
            sqlCommand.Parameters.AddWithValue("@Receipt_Date", receiptDate);
            sqlCommand.Parameters.AddWithValue("@Other_Comments", OtherComments);

            //save data to use in FormReceipt
            FormReceipt formReceipt = new FormReceipt();
            {
                //save all public string and long to be used in FormReceipt
                formReceipt.Subtotal = Subtotal;
                formReceipt.PPNPercentage = PPNPercentage;
                formReceipt.PPN = PPN;
                formReceipt.Total = Total;
                formReceipt.DataTable = dt;
                formReceipt.parentInvID = cBoxInvoiceID.Text;
                formReceipt.receiptDate = receiptDate;
                formReceipt.OtherComment = OtherComments;
                formReceipt.NamaTTd = NamaTTd;
                formReceipt.NamaCustomer = namaCustomer;
                formReceipt.Perusahaan = perusahaan;
                formReceipt.Alamat = alamat;
            }

            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Receipt saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
