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
using System;
using System.Windows.Forms;

namespace Waterpediaa
{
    public partial class FormEditPackaging : Form
    {
        private int id;

        public FormEditPackaging(int id, string namaBarang, int jumlah, long hargaPerBarang)
        {
            InitializeComponent();

            this.id = id;
            textBoxNamaBarang.Text = namaBarang;
            nudJumlah.Value = jumlah;
            nudHargaPerBarang.Value = hargaPerBarang;

            // Adjust the maximum values for NumericUpDown controls if needed
            nudJumlah.Maximum = 1000000;
            nudHargaPerBarang.Maximum = 1000000;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string namaBarang = textBoxNamaBarang.Text;
            int jumlah = (int)nudJumlah.Value;
            long hargaPerBarang = (long)nudHargaPerBarang.Value;

            UpdatePackagingData(id, namaBarang, jumlah, hargaPerBarang);

            this.Close();
        }

        private void UpdatePackagingData(int id, string namaBarang, int jumlah, long hargaPerBarang)
        {
            string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
            string query = "UPDATE Stock_Packaging SET Nama_Barang = @namaBarang, Jumlah = @jumlah, Harga_Per_Barang = @hargaPerBarang WHERE ID = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@namaBarang", namaBarang);
                    cmd.Parameters.AddWithValue("@jumlah", jumlah);
                    cmd.Parameters.AddWithValue("@hargaPerBarang", hargaPerBarang);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

