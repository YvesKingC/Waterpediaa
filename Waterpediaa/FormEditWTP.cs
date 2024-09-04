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
    public partial class FormEditWTP : Form
    {
        private int filterId;

        public FormEditWTP(int id, string name, int jumlah, long harga)
        {
            InitializeComponent();
            filterId = id;
            textBoxNamaFilter.Text = name;
            numericUpDownStok.Value = jumlah;
            numericUpDownHarga.Value = harga;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
            string query = "UPDATE Stock_Filter SET Jenis_Filter = @name, Jumlah = @jumlah, Harga_Per_Barang = @harga WHERE ID = @id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", filterId);
                    cmd.Parameters.AddWithValue("@name", textBoxNamaFilter.Text);
                    cmd.Parameters.AddWithValue("@jumlah", (int)numericUpDownStok.Value);
                    cmd.Parameters.AddWithValue("@harga", (long)numericUpDownHarga.Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            this.Close();
        }
    }
}

