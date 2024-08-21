using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas.Parser.ClipperLib;
using MySql.Data.MySqlClient;


namespace Waterpediaa
{
    public partial class FormDashboardSales : Form
    {
        public FormDashboardSales()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormDashboardSales_Load);
        }

        private async void FormDashboardSales_Load(object sender, EventArgs e)
        {
            await UpdateLabelsAsync();
        }

        private async Task UpdateLabelsAsync()
        {
            string connectionString = "server=localhost;database=waterpedia;user=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();  // Await the asynchronous open operation

                string query = "SELECT SUM(Harga_Jual) FROM Invoice";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    object result = await cmd.ExecuteScalarAsync();  // Await the asynchronous execute operation

                    if (result != DBNull.Value && result != null)
                    {
                        decimal totalOmset = Convert.ToDecimal(result);
                        labelOmset.Text = totalOmset.ToString("N0");  // Format the number with commas
                    }
                    else
                    {
                        labelOmset.Text = "0";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();
            formSales.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBuatInvoicePenjualan formInvoice = new FormBuatInvoicePenjualan();
            formInvoice.Show();
        }
    }
}


