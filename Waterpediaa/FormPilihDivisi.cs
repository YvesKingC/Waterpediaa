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
    public partial class FormPilihDivisi : Form
    {
        public FormPilihDivisi()
        {
            InitializeComponent();
        }
        private void FormPilihDivisi_Load(object sender, EventArgs e)
        {
            lblWellcome.Text = "Wellcome " + FormLogin.Nama;
            if (FormLogin.Izin_Akses == "Admin")
            {
                btnViewUser.Enabled = true;
            }
            else
            {
                btnViewUser.Enabled = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form FormLogout = new FormLogin();
            FormLogout.Show();
            this.Hide();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            Form FormViewUser = new FormViewUser();
            FormViewUser.Show();
            this.Hide();
        }

        private void btnProcure_Click(object sender, EventArgs e)
        {
            Form FormTambahBakteri = new FormTambahBakteri();
            FormTambahBakteri.Show();
            this.Hide();
        }

        private void btnQuotation_Click(object sender, EventArgs e)
        {
            Form FormBuatQuotation = new FormBuatQuotation();
            FormBuatQuotation.Show();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            Form FormBuatInvoicePenjualan = new FormBuatInvoicePenjualan();
            FormBuatInvoicePenjualan.Show();
            this.Hide();
        }

        private void btnBakteri_Click(object sender, EventArgs e)
        {
            Form FormInventoryBakteri = new FormInventoryBakteri();
            FormInventoryBakteri.Show();
            this.Hide();
        }

        private void btnWTP_Click(object sender, EventArgs e)
        {
            Form ForminventoryWTP = new FormInventoryWTP();
            ForminventoryWTP.Show();
            this.Hide();
        }
    }
}
