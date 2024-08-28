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
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        public string NamaCustomer { get; set; }
        public string Perusahaan { get; set; }
        public string Alamat { get; set; }
        public string ServiceOrder { get; set; }
        public string DueDate { get; set; }
        public string TermsConds { get; set; }
        public long Subtotal { get; set; }
        public long StringPPN { get; set; }
        public long StringTotal { get; set; }
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
            tBoxDetailCustomer.Text = $"{NamaCustomer}\r\n\r\n{Perusahaan}\r\n\r\n{Alamat}";
            tBoxServiceOrder.Text = ServiceOrder;
            tBoxDueDate.Text = DueDate;
            tBoxTNC.Text = TermsConds;

            lblSubTotal.Text = "Sub Total : " + $"Rp {Subtotal}";
            lblPPN.Text = $"PPN : " + $"Rp {StringPPN}";
            lblTotal.Text = "Total : " + $"Rp {StringTotal}";

            tBoxQuoteID.Text = parentQuoteID;
        }
        private void btnCreatePDF_Click_1(object sender, EventArgs e)
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
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();

            sqlConnect.Close();
        }
        private void CapturePanel(Panel panel)
        {
            panelQuotationBitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(panelQuotationBitmap, new Rectangle(0, 0, panel.Width, panel.Height));
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(panelQuotationBitmap, 0, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = "info@waterpedia.co.id";
            string mailto = $"mailto:{email}";
            System.Diagnostics.Process.Start(mailto);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form FormPilihDivisi = new FormPilihDivisi();
            FormPilihDivisi.Show();
            this.Hide();
        }
    }
}
