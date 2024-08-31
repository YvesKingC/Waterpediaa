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
    public partial class FormReceipt : Form
    {
        private Bitmap panelReceiptBitmap;

        public FormReceipt()
        {
            InitializeComponent();
        }
        public long Subtotal { get; set; }
        public long PPNPercentage { get; set; }
        public long PPN { get; set; }
        public long Total { get; set; }
        public DataTable DataTable { get; set; }
        public int parentInvID { get; set; }
        public DateTime receiptDate { get; set; }
        public string OtherComment { get; set; }
        public string NamaTTd { get; set; }
        public string NamaCustomer { get; set; }
        public string Perusahaan { get; set; }
        public string Alamat { get; set; }

        static string connectionString = "server=localhost;uid=root;pwd=;database=Waterpedia;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void FormReceipt_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            dataGridViewReceipt.DataSource = DataTable;
            tBoxDetailCustomer.Text = $"Nama Customer: {NamaCustomer}\r\n\r\nPerusahaan: {Perusahaan}\r\n\r\nAlamat: {Alamat}";
            tBoxInvoiceID.Text = parentInvID.ToString();
            tBoxDate.Text = receiptDate.ToString("dd/MM/yyyy");
            tBoxOtherComments.Text = OtherComment;

            lblSubTotal.Text = "Sub Total : " + $"Rp {Subtotal}";
            lblPPN.Text = $"PPN : " + $"Rp {PPN}";
            lblTotal.Text = "Total : " + $"Rp {Total}";

            tBoxNamaTTD.Text = NamaTTd;
        }
        private void btnCreatePDF_Click(object sender, EventArgs e)
        {
            CapturePanel(panelReceipt);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                panelReceiptBitmap = new Bitmap(panelReceipt.Width, panelReceipt.Height);
                panelReceipt.DrawToBitmap(panelReceiptBitmap, new Rectangle(0, 0, panelReceipt.Width, panelReceipt.Height));
                panelReceiptBitmap.Save("Receipt.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            ReduceStock();

            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();

            sqlConnect.Close();
        }
        private void CapturePanel(Panel panel)
        {
            panelReceiptBitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(panelReceiptBitmap, new Rectangle(0, 0, panel.Width, panel.Height));
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(panelReceiptBitmap, 0, 0);
        }
        private void ReduceStock()
        {
            try
            {
                // Start transaction
                using (var transaction = sqlConnect.BeginTransaction())
                {
                    // Reduce Stock_Bakteri
                    ReduceStockForEachItem("SELECT Stock_BakteriID, Jumlah_Keluar FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_BakteriID IS NOT NULL", "Stock_BakteriID", "Stock_Bakteri", "Volume", transaction);

                    // Reduce Stock_Filter
                    ReduceStockForEachItem("SELECT Stock_FilterID, Jumlah_Keluar FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_FilterID IS NOT NULL", "Stock_FilterID", "Stock_Filter", "Jumlah", transaction);

                    // Reduce Stock_Packaging
                    ReduceStockForEachItem("SELECT Stock_PackagingID, Jumlah_Keluar FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_PackagingID IS NOT NULL", "Stock_PackagingID", "Stock_Packaging", "Jumlah", transaction);

                    // Reduce Paket_Bakteri (for both Stock_Bakteri and Stock_Packaging within the package)
                    ReduceStockForPaketBakteri(transaction);

                    // Commit transaction
                    transaction.Commit();
                    MessageBox.Show("Stock has been successfully reduced!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateMutasi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reducing the stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReduceStockForEachItem(string query, string stockColumn, string tableName, string quantityColumn, MySqlTransaction transaction)
        {
            using (var cmd = new MySqlCommand(query, sqlConnect, transaction))
            {
                cmd.Parameters.AddWithValue("@ParentInvID", parentInvID);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string stockID = reader[stockColumn].ToString();
                        long jumlahKeluar = Convert.ToInt64(reader["Jumlah_Keluar"]);

                        UpdateStock($"UPDATE {tableName} SET {quantityColumn} = {quantityColumn} - @JumlahKeluar WHERE ID = @StockID", stockID, jumlahKeluar, transaction);
                    }
                }
            }
        }

        private void UpdateStock(string query, string stockID, long jumlahKeluar, MySqlTransaction transaction)
        {
            using (var cmd = new MySqlCommand(query, sqlConnect, transaction))
            {
                cmd.Parameters.AddWithValue("@StockID", stockID);
                cmd.Parameters.AddWithValue("@JumlahKeluar", jumlahKeluar);
                cmd.ExecuteNonQuery();
            }
        }

        private void ReduceStockForPaketBakteri(MySqlTransaction transaction)
        {
            // Reduce Stock_Bakteri in Paket_Bakteri
            ReduceStockForEachItem("SELECT PB.Stock_BakteriID, I.Jumlah_Keluar FROM Invoice I JOIN Paket_Bakteri PB ON I.Paket_BakteriID = PB.ID WHERE I.ParentInvID = @ParentInvID AND I.Paket_BakteriID IS NOT NULL", "Stock_BakteriID", "Stock_Bakteri", "Volume", transaction);

            // Reduce Stock_Packaging in Paket_Bakteri
            ReduceStockForEachItem("SELECT PB.Stock_PackagingID, I.Jumlah_Keluar FROM Invoice I JOIN Paket_Bakteri PB ON I.Paket_BakteriID = PB.ID WHERE I.ParentInvID = @ParentInvID AND I.Paket_BakteriID IS NOT NULL", "Stock_PackagingID", "Stock_Packaging", "Jumlah", transaction);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();

            sqlConnect.Close();
        }
        private void UpdateMutasi()
        {
            try
            {
                // Start transaction
                using (var transaction = sqlConnect.BeginTransaction())
                {
                    string invID = parentInvID.ToString();
                    if (!string.IsNullOrEmpty(invID))
                    {
                        // Insert record for each item in Stock_Bakteri
                        InsertMutasiForEachItem("SELECT Stock_BakteriID, 0, Jumlah_Keluar, 'Sales' FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_BakteriID IS NOT NULL", "Stock_BakteriID", transaction);

                        // Insert record for each item in Stock_Filter
                        InsertMutasiForEachItem("SELECT Stock_FilterID, 0, Jumlah_Keluar, 'Sales' FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_FilterID IS NOT NULL", "Stock_FilterID", transaction);

                        // Insert record for each item in Stock_Packaging
                        InsertMutasiForEachItem("SELECT Stock_PackagingID, 0, Jumlah_Keluar, 'Sales' FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_PackagingID IS NOT NULL", "Stock_PackagingID", transaction);

                        // Commit transaction
                        transaction.Commit();
                        MessageBox.Show("Mutasi Produk has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Invoice ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    sqlConnect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating Mutasi Produk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertMutasiForEachItem(string query, string stockColumn, MySqlTransaction transaction)
        {
            using (var cmd = new MySqlCommand(query, sqlConnect, transaction))
            {
                cmd.Parameters.AddWithValue("@ParentInvID", parentInvID);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string stockID = reader[stockColumn].ToString();
                        long jumlahKeluar = Convert.ToInt64(reader["Jumlah_Keluar"]);

                        InsertMutasi($"INSERT INTO Mutasi_Produk ({stockColumn}, Masuk, Keluar, Keterangan) VALUES (@StockID, 0, @JumlahKeluar, 'Sales')", stockID, jumlahKeluar, transaction);
                    }
                }
            }
        }

        private void InsertMutasi(string query, string stockID, long jumlahKeluar, MySqlTransaction transaction)
        {
            using (var cmd = new MySqlCommand(query, sqlConnect, transaction))
            {
                cmd.Parameters.AddWithValue("@StockID", stockID);
                cmd.Parameters.AddWithValue("@JumlahKeluar", jumlahKeluar);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnCreatePDF_Click_1(object sender, EventArgs e)
        {

        }
    }
}


