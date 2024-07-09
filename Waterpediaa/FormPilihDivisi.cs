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
            Form formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
