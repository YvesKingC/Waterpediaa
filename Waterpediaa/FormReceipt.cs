using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
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

        static string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void FormReceipt_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            dataGridViewReceipt.DataSource = DataTable;
            tBoxDetailCustomer.Text = $"{NamaCustomer}\r\n{Perusahaan}\r\n{Alamat}";
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
            ProcessTransaction();

            CapturePanel(panelReceipt);
            // Show the print dialog
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Show print preview dialog
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.WindowState = FormWindowState.Maximized;
                printPreviewDialog1.ShowDialog();
            }

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
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
        }
        private void ProcessTransaction()
        {
            using (var transactionScope = new TransactionScope())
            {
                try
                {
                    foreach (DataRow row in DataTable.Rows)
                    {
                        string productName = row["Product"].ToString();
                        string packagingName = row["Packaging"].ToString();
                        int quantity = Convert.ToInt32(row["QTY"]);

                        sqlQuery = @"
                    SELECT 
                        sb.ID AS Stock_BakteriID,
                        sf.ID AS Stock_FilterID,
                        sp.ID AS Stock_PackagingID
                    FROM 
                        Stock_Bakteri sb
                    LEFT JOIN 
                        Stock_Filter sf ON sb.Jenis_Bakteri = @productName
                    LEFT JOIN 
                        Paket_Bakteri pb ON pb.Nama_Paket = @productName
                    LEFT JOIN 
                        Stock_Packaging sp ON sp.Nama_Barang = @packagingName
                    WHERE 
                        sb.Jenis_Bakteri = @productName OR 
                        sf.Jenis_Filter = @productName OR 
                        pb.Nama_Paket = @productName";

                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlCommand.Parameters.AddWithValue("@productName", productName);
                        sqlCommand.Parameters.AddWithValue("@packagingName", packagingName);

                        MySqlDataReader reader = sqlCommand.ExecuteReader();

                        int stockBakteriID = 0;
                        int stockFilterID = 0;
                        int stockPackagingID = 0;

                        if (reader.Read())
                        {
                            stockBakteriID = reader["Stock_BakteriID"] != DBNull.Value ? Convert.ToInt32(reader["Stock_BakteriID"]) : 0;
                            stockFilterID = reader["Stock_FilterID"] != DBNull.Value ? Convert.ToInt32(reader["Stock_FilterID"]) : 0;
                            stockPackagingID = reader["Stock_PackagingID"] != DBNull.Value ? Convert.ToInt32(reader["Stock_PackagingID"]) : 0;
                        }
                        reader.Close();

                        if (stockBakteriID > 0)
                        {
                            sqlQuery = $"UPDATE Stock_Bakteri SET Volume = Volume - {quantity} WHERE ID = {stockBakteriID}";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                            sqlCommand.ExecuteNonQuery();
                        }

                        if (stockFilterID > 0)
                        {
                            sqlQuery = $"UPDATE Stock_Filter SET Jumlah = Jumlah - {quantity} WHERE ID = {stockFilterID}";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                            sqlCommand.ExecuteNonQuery();
                        }

                        if (stockPackagingID > 0)
                        {
                            sqlQuery = $"UPDATE Stock_Packaging SET Jumlah = Jumlah - {quantity} WHERE ID = {stockPackagingID}";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                            sqlCommand.ExecuteNonQuery();
                        }

                        // Log the stock movement using the new UpdateMutasi function
                        UpdateMutasi(stockBakteriID, stockFilterID, stockPackagingID, 0, quantity, "Sales");
                    }

                    transactionScope.Complete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    sqlConnect.Close();
                }
            }
        }

        private void UpdateMutasi(int stockBakteriID, int stockFilterID, int stockPackagingID, int masuk, int keluar, string keterangan)
        {
            try
            {
                sqlQuery = @"INSERT INTO Mutasi_Produk 
                    (Stock_BakteriID, Stock_FilterID, Stock_PackagingID, Masuk, Keluar, Keterangan) 
                    VALUES 
                    (@stockBakteriID, @stockFilterID, @stockPackagingID, @masuk, @keluar, @keterangan)";

                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@stockBakteriID", stockBakteriID > 0 ? (object)stockBakteriID : DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@stockFilterID", stockFilterID > 0 ? (object)stockFilterID : DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@stockPackagingID", stockPackagingID > 0 ? (object)stockPackagingID : DBNull.Value);
                sqlCommand.Parameters.AddWithValue("@masuk", masuk);
                sqlCommand.Parameters.AddWithValue("@keluar", keluar);
                sqlCommand.Parameters.AddWithValue("@keterangan", keterangan);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while logging to Mutasi_Produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


