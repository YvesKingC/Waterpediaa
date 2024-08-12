using MySql.Data.MySqlClient;
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

namespace Waterpediaa
{
    public partial class FormQuotation : Form
    {
        private Bitmap panelQuotationBitmap;
        public FormQuotation()
        {
            InitializeComponent();
        }
        public string NamaCustomer { get; set; }
        public string Perusahaan { get; set; }
        public string Alamat { get; set; }
        public string ServiceOrder { get; set; }
        public string DueDate { get; set; }
        public string TermsConds { get; set; }
        public long Subtotal { get; set; }
        public string StringPPN { get; set; }
        public string StringTotal { get; set; }
        public DataTable DataTable { get; set; }
        public string parentQuoteID { get; set; }

        static string connectionString = "server=localhost;uid=root;pwd=;database=Waterpedia;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormQuotation_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            dataGridViewQuote.DataSource = DataTable;
            tBoxDetailCustomer.Text = $"Nama Customer: {NamaCustomer}\r\n\r\nPerusahaan: {Perusahaan}\r\n\r\nAlamat: {Alamat}";
            tBoxServiceOrder.Text = ServiceOrder;
            tBoxDueDate.Text = DueDate;
            tBoxTNC.Text = TermsConds;

            lblSubTotal.Text = "Sub Total : " + $"Rp {Subtotal}";
            lblPPN.Text = $"PPN : " + $"Rp " + StringPPN;
            lblTotal.Text = "Total : " + $"Rp " + StringTotal;

            tBoxQuoteID.Text = parentQuoteID;
        }

        private void btnCreatePDF_Click(object sender, EventArgs e)
        {
            // Capture the panelInvoice content
            CapturePanel(panelQuotation);

            // Show the print dialog
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Show print preview dialog
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.WindowState = FormWindowState.Maximized;
                printPreviewDialog1.ShowDialog();
            }
        }
        private void CapturePanel(Panel panel)
        {
            panelQuotation = panel;
            panelQuotationBitmap = new Bitmap(panelQuotation.Width, panelQuotation.Height);
            panelQuotation.DrawToBitmap(panelQuotationBitmap, new Rectangle(0, 0, panelQuotation.Width, panelQuotation.Height));
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(panelQuotationBitmap, 0, 0);
        }
    }
}
