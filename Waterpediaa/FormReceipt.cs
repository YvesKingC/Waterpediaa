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
        public string parentInvID { get; set; }
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
            tBoxInvoiceID.Text = parentInvID;
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
            if (string.IsNullOrEmpty(parentInvID))
            {
                MessageBox.Show("Invalid Invoice ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Start transaction
                using (var transaction = sqlConnect.BeginTransaction())
                {
                    // Reduce Stock_Bakteri
                    UpdateStock("UPDATE Stock_Bakteri SB JOIN Invoice I ON SB.ID = I.Stock_BakteriID " +
                                "SET SB.Volume = SB.Volume - I.Jumlah_Keluar WHERE I.ParentInvID = @ParentInvID AND I.Stock_BakteriID IS NOT NULL", transaction);

                    // Reduce Stock_Filter
                    UpdateStock("UPDATE Stock_Filter SF JOIN Invoice I ON SF.ID = I.Stock_FilterID " +
                                "SET SF.Jumlah = SF.Jumlah - I.Jumlah_Keluar WHERE I.ParentInvID = @ParentInvID AND I.Stock_FilterID IS NOT NULL", transaction);

                    // Reduce Stock_Packaging
                    UpdateStock("UPDATE Stock_Packaging SP JOIN Invoice I ON SP.ID = I.Stock_PackagingID " +
                                "SET SP.Jumlah = SP.Jumlah - I.Jumlah_Keluar WHERE I.ParentInvID = @ParentInvID AND I.Stock_PackagingID IS NOT NULL", transaction);

                    // Reduce Paket_Bakteri
                    UpdateStock("UPDATE Stock_Bakteri SB JOIN Paket_Bakteri PB ON SB.ID = PB.Stock_BakteriID " +
                                "JOIN Invoice I ON PB.ID = I.Paket_BakteriID " +
                                "SET SB.Volume = SB.Volume - I.Jumlah_Keluar WHERE I.ParentInvID = @ParentInvID AND I.Paket_BakteriID IS NOT NULL", transaction);

                    UpdateStock("UPDATE Stock_Packaging SP JOIN Paket_Bakteri PB ON SP.ID = PB.Stock_PackagingID " +
                                "JOIN Invoice I ON PB.ID = I.Paket_BakteriID " +
                                "SET SP.Jumlah = SP.Jumlah - I.Jumlah_Keluar WHERE I.ParentInvID = @ParentInvID AND I.Paket_BakteriID IS NOT NULL", transaction);

                    // Commit transaction
                    transaction.Commit();
                    MessageBox.Show("Stock has been successfully reduced!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reducing the stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStock(string query, MySqlTransaction transaction)
        {
            using (var cmd = new MySqlCommand(query, sqlConnect, transaction))
            {
                cmd.Parameters.AddWithValue("@ParentInvID", parentInvID);
                cmd.ExecuteNonQuery();
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
