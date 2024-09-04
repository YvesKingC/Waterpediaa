using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Waterpediaa
{
    public partial class FormInvoice : Form
    {
        private Bitmap panelInvoiceBitmap;
        public FormInvoice()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }
        public string MetodePembayaran { get; set; }
        public string NamaCustomer { get; set; }
        public string Perusahaan { get; set; }
        public string Alamat { get; set; }
        public string ServiceOrder { get; set; }
        public string DueDate { get; set; }
        public string OtherComment { get; set; }
        public long Subtotal { get; set; }
        public long StringPPN { get; set; }
        public long StringTotal { get; set; }
        public DataTable DataTable { get; set; }
        public string parentInvID { get; set; }
        public string confimPayment { get; set; }

        static string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            dataGridViewInvoice.DataSource = DataTable;
            tBoxDetailCustomer.Text = $"{NamaCustomer}\r\n{Perusahaan}\r\n{Alamat}";
            tBoxServiceOrder.Text = ServiceOrder;
            tBoxDueDate.Text = DueDate;
            tBoxOtherComments.Text = OtherComment;

            lblSubTotal.Text = "Sub Total : " + $"Rp {Subtotal}";
            lblPPN.Text = $"PPN : " + $"Rp {StringPPN}";
            lblTotal.Text = "Total : " + $"Rp {StringTotal}";

            tBoxInvoiceID.Text = parentInvID;
            tBoxContact.Text = confimPayment;
            loadInfoMetodePembayaran();
        }
        private void loadInfoMetodePembayaran()
        {
            try
            {
                sqlQuery = "SELECT NoRek FROM Metode_Pembayaran WHERE Metode = @MetodePembayaran";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.Parameters.AddWithValue("@MetodePembayaran", MetodePembayaran);

                using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string noRekening = reader["NoRek"].ToString();
                        tBoxMetodePembayaran.Text = $"Metode Pembayaran: {MetodePembayaran}\r\nNo Rekening: {noRekening}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading payment method info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*sudah works*/
        private void btnCreatePDF_Click(object sender, EventArgs e)
        {
            // Capture the panelInvoice content
            CapturePanel(panelInvoice);

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

            sqlConnect.Close();
        }

        private void CapturePanel(Panel panel)
        {
            // Create a bitmap of the same size as the panel
            panelInvoiceBitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(panelInvoiceBitmap, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Draw the bitmap on the print document
            e.Graphics.DrawImage(panelInvoiceBitmap, 0, 0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
        }
    }
}
