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
    public partial class FormQuotation : Form
    {
        public FormQuotation()
        {
            InitializeComponent();
        }
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
        public string parentQuoteID { get; set; }

        private void FormQuotation_Load(object sender, EventArgs e)
        {

        }
    }
}
