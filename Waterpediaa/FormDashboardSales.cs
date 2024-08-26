using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                // Query to calculate total sales (Omset)
                string queryOmset = "SELECT SUM(Harga_Jual * Jumlah_Keluar) FROM Invoice";

                // Query to calculate total cost and profit
                string queryProfit = @"
                    SELECT 
                        IFNULL(SUM((inv.Harga_Jual * inv.Jumlah_Keluar)), 0) - 
                        IFNULL(SUM(
                            (IFNULL(sb.Harga_Per_Liter, 0) * inv.Jumlah_Keluar) +
                            (IFNULL(sf.Harga_Per_Barang, 0) * inv.Jumlah_Keluar) +
                            (IFNULL(sp.Harga_Per_Barang, 0) * inv.Jumlah_Keluar)
                        ), 0) AS Profit
                    FROM 
                        Invoice inv
                    LEFT JOIN 
                        Stock_Bakteri sb ON inv.Stock_BakteriID = sb.ID
                    LEFT JOIN 
                        Stock_Filter sf ON inv.Stock_FilterID = sf.ID
                    LEFT JOIN 
                        Stock_Packaging sp ON inv.Stock_PackagingID = sp.ID";

                // Execute the Omset query
                using (MySqlCommand cmdOmset = new MySqlCommand(queryOmset, connection))
                {
                    object resultOmset = await cmdOmset.ExecuteScalarAsync();  // Await the asynchronous execute operation

                    if (resultOmset != DBNull.Value && resultOmset != null)
                    {
                        decimal totalOmset = Convert.ToDecimal(resultOmset);
                        labelOmset.Text = totalOmset.ToString("N0");  // Format the number with commas
                    }
                    else
                    {
                        labelOmset.Text = "0";
                    }
                }

                // Execute the Profit query
                using (MySqlCommand cmdProfit = new MySqlCommand(queryProfit, connection))
                {
                    object resultProfit = await cmdProfit.ExecuteScalarAsync();  // Await the asynchronous execute operation

                    if (resultProfit != DBNull.Value && resultProfit != null)
                    {
                        decimal totalProfit = Convert.ToDecimal(resultProfit);
                        labelProfit.Text = totalProfit.ToString("N0");  // Format the number with commas
                    }
                    else
                    {
                        labelProfit.Text = "0";
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



