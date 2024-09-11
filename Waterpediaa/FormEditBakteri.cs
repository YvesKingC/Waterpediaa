using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterpediaa
{
    public partial class FormEditBakteri : Form
    {
        private int bakteriId;
        private string bakteriName;
        private int volume;
        private long hargaPerLiter;

        public FormEditBakteri(int id, string name, int vol, long harga)
        {
            InitializeComponent();
            bakteriId = id;
            bakteriName = name;
            volume = vol;
            hargaPerLiter = harga;
            LoadBakteriData();
        }

        private void LoadBakteriData()
        {
            txtNamaBakteri.Text = bakteriName;

            // Ensure the value being set is within the allowable range
            nudVolume.Maximum = Math.Max(nudVolume.Maximum, volume);
            nudVolume.Value = volume;

            // Ensure the value being set is within the allowable range
            nudHargaPerLiter.Maximum = Math.Max(nudHargaPerLiter.Maximum, hargaPerLiter);
            nudHargaPerLiter.Value = hargaPerLiter;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Sukses");
            // Update the database with the new values
            UpdateBakteriData();
            this.Close();

            //call LoadStockBakteriData from FormInventoryBakteri
            FormInventoryBakteri formInventoryBakteri = new FormInventoryBakteri();
            formInventoryBakteri.LoadStockBakteriData();
        }

        private void UpdateBakteriData()
        {
            // Your database update logic here
            string connectionString = "server=192.168.1.200;uid=Waterpedia;pwd=Waterpediaid;database=Waterpedia";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Stock_Bakteri SET Jenis_Bakteri = @name, Volume = @vol, Harga_Per_Liter = @harga WHERE ID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", bakteriId);
                    cmd.Parameters.AddWithValue("@name", txtNamaBakteri.Text);
                    cmd.Parameters.AddWithValue("@vol", (int)nudVolume.Value);
                    cmd.Parameters.AddWithValue("@harga", (long)nudHargaPerLiter.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle the event here
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
