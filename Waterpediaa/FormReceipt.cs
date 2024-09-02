using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
            sqlConnect.Open();
            CapturePanel(panelReceipt);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                panelReceiptBitmap = new Bitmap(panelReceipt.Width, panelReceipt.Height);
                panelReceipt.DrawToBitmap(panelReceiptBitmap, new Rectangle(0, 0, panelReceipt.Width, panelReceipt.Height));
                panelReceiptBitmap.Save("Receipt.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            ProcessTransaction();

            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
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
        private void ProcessTransaction()
        {
            using (MySqlConnection localConnection = new MySqlConnection(connectionString))
            {
                try
                {
                    localConnection.Open();
                    using (var transaction = localConnection.BeginTransaction())
                    {
                        try
                        {
                            // Ensure the connection is associated with the transaction
                            ReduceStock(transaction, localConnection);
                            UpdateMutasi(transaction, localConnection);

                            // Commit the transaction if everything is successful
                            transaction.Commit();
                            MessageBox.Show("Stock and Mutasi Produk have been successfully processed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            // Rollback the transaction in case of an error
                            transaction.Rollback();
                            throw; // Re-throw the exception to be caught by the outer catch block
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while processing the transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ReduceStock(MySqlTransaction transaction, MySqlConnection localConnection)
        {
            ExecuteStockOperation("SELECT Stock_BakteriID, Jumlah_Keluar FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_BakteriID IS NOT NULL",
                                  "Stock_BakteriID", "Stock_Bakteri", "Volume", transaction, localConnection, true);

            ExecuteStockOperation("SELECT Stock_FilterID, Jumlah_Keluar FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_FilterID IS NOT NULL",
                                  "Stock_FilterID", "Stock_Filter", "Jumlah", transaction, localConnection, true);

            ExecuteStockOperation("SELECT Stock_PackagingID, Jumlah_Keluar FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_PackagingID IS NOT NULL",
                                  "Stock_PackagingID", "Stock_Packaging", "Jumlah", transaction, localConnection, true);

            ExecuteStockOperation("SELECT PB.Stock_BakteriID, I.Jumlah_Keluar FROM Invoice I JOIN Paket_Bakteri PB ON I.Paket_BakteriID = PB.ID WHERE I.ParentInvID = @ParentInvID AND I.Paket_BakteriID IS NOT NULL",
                                  "Stock_BakteriID", "Stock_Bakteri", "Volume", transaction, localConnection, true);

            ExecuteStockOperation("SELECT PB.Stock_PackagingID, I.Jumlah_Keluar FROM Invoice I JOIN Paket_Bakteri PB ON I.Paket_BakteriID = PB.ID WHERE I.ParentInvID = @ParentInvID AND I.Paket_BakteriID IS NOT NULL",
                                  "Stock_PackagingID", "Stock_Packaging", "Jumlah", transaction, localConnection, true);
        }

        private void UpdateMutasi(MySqlTransaction transaction, MySqlConnection localConnection)
        {
            ExecuteStockOperation("SELECT Stock_BakteriID, 0, Jumlah_Keluar, 'Sales' FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_BakteriID IS NOT NULL",
                                  "Stock_BakteriID", "Stock_Bakteri", "Volume", transaction, localConnection, false);

            ExecuteStockOperation("SELECT Stock_FilterID, 0, Jumlah_Keluar, 'Sales' FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_FilterID IS NOT NULL",
                                  "Stock_FilterID", "Stock_Filter", "Jumlah", transaction, localConnection, false);

            ExecuteStockOperation("SELECT Stock_PackagingID, 0, Jumlah_Keluar, 'Sales' FROM Invoice WHERE ParentInvID = @ParentInvID AND Stock_PackagingID IS NOT NULL",
                                  "Stock_PackagingID", "Stock_Packaging", "Jumlah", transaction, localConnection, false);
        }

        private void ExecuteStockOperation(string selectQuery, string stockColumn, string tableName, string quantityColumn, MySqlTransaction transaction, MySqlConnection localConnection, bool isReduceStock)
        {
            using (var cmd = new MySqlCommand(selectQuery, localConnection, transaction))
            {
                cmd.Parameters.AddWithValue("@ParentInvID", parentInvID);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string stockID = reader[stockColumn].ToString();
                        long jumlahKeluar = Convert.ToInt64(reader["Jumlah_Keluar"]);
                        if (isReduceStock)
                        {
                            // Update Stock
                            sqlQuery = $"UPDATE {tableName} SET {quantityColumn} = {quantityColumn} - @JumlahKeluar WHERE ID = @StockID";
                            using (var updateCmd = new MySqlCommand(sqlQuery, localConnection, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@StockID", stockID);
                                updateCmd.Parameters.AddWithValue("@JumlahKeluar", jumlahKeluar);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert Mutasi
                            sqlQuery = $"INSERT INTO Mutasi_Produk ({stockColumn}, Masuk, Keluar, Keterangan) VALUES (@StockID, 0, @JumlahKeluar, 'Sales')";
                            using (var insertCmd = new MySqlCommand(sqlQuery, localConnection, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@StockID", stockID);
                                insertCmd.Parameters.AddWithValue("@JumlahKeluar", jumlahKeluar);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
        }
    }
}


