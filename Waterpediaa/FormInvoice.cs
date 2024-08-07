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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
            
        }
        public string MetodePembayaran { get; set; }
        public string NamaCustomer { get; set; }
        public string Perusahaan { get; set; }
        public string Alamat { get; set; }
        public string ServiceOrder { get; set; }
        public string DueDate { get; set; }
        public string OtherComment { get; set; }
        public long Subtotal { get; set; }
        public string StringPPN { get; set; }
        public string StringTotal { get; set; }
        public DataTable DataTable { get; set; }

        static string connectionString = "server=localhost;uid=root;pwd=;database=Waterpedia;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            dataGridViewInvoice.DataSource = DataTable;
            tBoxDetailCustomer.Text = $"Nama Customer: {NamaCustomer}\r\n\r\nPerusahaan: {Perusahaan}\r\n\r\nAlamat: {Alamat}";
            tBoxServiceOrder.Text = ServiceOrder;
            tBoxDueDate.Text = DueDate;
            tBoxOtherComments.Text = OtherComment;

            lblSubTotal.Text = "Sub Total : " + $"Rp {Subtotal}";
            lblPPN.Text = $"PPN : " + $"Rp "+ StringPPN;
            lblTotal.Text = "Total : " + $"Rp " + StringTotal;
        }
    }
}
