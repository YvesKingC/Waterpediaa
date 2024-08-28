namespace Waterpediaa
{
    partial class FormBuatQuotation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            btnCreatePDF = new Button();
            dataGridViewQuote = new DataGridView();
            panel6 = new Panel();
            tBoxTNC = new TextBox();
            panel7 = new Panel();
            label21 = new Label();
            panel4 = new Panel();
            cBoxCustomer = new ComboBox();
            label23 = new Label();
            dtpDueDate = new DateTimePicker();
            dtpServiceOrder = new DateTimePicker();
            label13 = new Label();
            label17 = new Label();
            panel5 = new Panel();
            label18 = new Label();
            panelProduk = new Panel();
            btnAddNewCustomer = new Button();
            label16 = new Label();
            cBoxKabupatenKota = new ComboBox();
            cBoxProvinsi = new ComboBox();
            label20 = new Label();
            tBoxZipCode = new TextBox();
            tBoxAlamat = new TextBox();
            tBoxContact = new TextBox();
            tBoxPerusahaan = new TextBox();
            tBoxNamaCust = new TextBox();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            label19 = new Label();
            panel1 = new Panel();
            btnAddProduk = new Button();
            numericUpDownQTY = new NumericUpDown();
            tBoxHargaBeli = new TextBox();
            cBoxPackaging = new ComboBox();
            cBoxNamaProduk = new ComboBox();
            cBoxJenisProduk = new ComboBox();
            label10 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            panel8 = new Panel();
            label24 = new Label();
            numericUpDownPPN = new NumericUpDown();
            lblTotal = new Label();
            lblSubTotal = new Label();
            lblPPN = new Label();
            panel9 = new Panel();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuote).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panelProduk.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQTY).BeginInit();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPPN).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(337, 678);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 38);
            btnBack.TabIndex = 39;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnCreatePDF
            // 
            btnCreatePDF.BackColor = Color.FromArgb(192, 255, 192);
            btnCreatePDF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreatePDF.Location = new Point(337, 573);
            btnCreatePDF.Name = "btnCreatePDF";
            btnCreatePDF.Size = new Size(119, 49);
            btnCreatePDF.TabIndex = 38;
            btnCreatePDF.Text = "Create \r\nQuotation";
            btnCreatePDF.UseVisualStyleBackColor = false;
            btnCreatePDF.Click += btnCreatePDF_Click_1;
            // 
            // dataGridViewQuote
            // 
            dataGridViewQuote.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQuote.Location = new Point(336, 115);
            dataGridViewQuote.Name = "dataGridViewQuote";
            dataGridViewQuote.RowTemplate.Height = 25;
            dataGridViewQuote.Size = new Size(1019, 452);
            dataGridViewQuote.TabIndex = 36;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tBoxTNC);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(14, 537);
            panel6.Name = "panel6";
            panel6.Size = new Size(316, 179);
            panel6.TabIndex = 34;
            // 
            // tBoxTNC
            // 
            tBoxTNC.BorderStyle = BorderStyle.FixedSingle;
            tBoxTNC.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxTNC.Location = new Point(3, 35);
            tBoxTNC.Multiline = true;
            tBoxTNC.Name = "tBoxTNC";
            tBoxTNC.Size = new Size(308, 139);
            tBoxTNC.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkBlue;
            panel7.Controls.Add(label21);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(316, 29);
            panel7.TabIndex = 14;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(11, 4);
            label21.Name = "label21";
            label21.Size = new Size(147, 19);
            label21.TabIndex = 13;
            label21.Text = "Terms and Condition";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cBoxCustomer);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(dtpDueDate);
            panel4.Controls.Add(dtpServiceOrder);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(336, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(1019, 97);
            panel4.TabIndex = 32;
            // 
            // cBoxCustomer
            // 
            cBoxCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxCustomer.FormattingEnabled = true;
            cBoxCustomer.Location = new Point(140, 49);
            cBoxCustomer.Name = "cBoxCustomer";
            cBoxCustomer.Size = new Size(280, 25);
            cBoxCustomer.TabIndex = 45;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(18, 52);
            label23.Name = "label23";
            label23.Size = new Size(116, 19);
            label23.TabIndex = 44;
            label23.Text = "Customer Name :";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDueDate.Location = new Point(814, 51);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(191, 23);
            dtpDueDate.TabIndex = 28;
            // 
            // dtpServiceOrder
            // 
            dtpServiceOrder.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpServiceOrder.Location = new Point(530, 52);
            dtpServiceOrder.Name = "dtpServiceOrder";
            dtpServiceOrder.Size = new Size(198, 23);
            dtpServiceOrder.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(734, 52);
            label13.Name = "label13";
            label13.Size = new Size(74, 19);
            label13.TabIndex = 18;
            label13.Text = "Due Date :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(426, 52);
            label17.Name = "label17";
            label17.Size = new Size(98, 19);
            label17.TabIndex = 15;
            label17.Text = "Service Order :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.Controls.Add(label18);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1018, 29);
            panel5.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(11, 4);
            label18.Name = "label18";
            label18.Size = new Size(159, 19);
            label18.TabIndex = 13;
            label18.Text = "Quotation Information";
            // 
            // panelProduk
            // 
            panelProduk.BorderStyle = BorderStyle.FixedSingle;
            panelProduk.Controls.Add(btnAddNewCustomer);
            panelProduk.Controls.Add(label16);
            panelProduk.Controls.Add(cBoxKabupatenKota);
            panelProduk.Controls.Add(cBoxProvinsi);
            panelProduk.Controls.Add(label20);
            panelProduk.Controls.Add(tBoxZipCode);
            panelProduk.Controls.Add(tBoxAlamat);
            panelProduk.Controls.Add(tBoxContact);
            panelProduk.Controls.Add(tBoxPerusahaan);
            panelProduk.Controls.Add(tBoxNamaCust);
            panelProduk.Controls.Add(label9);
            panelProduk.Controls.Add(label3);
            panelProduk.Controls.Add(label2);
            panelProduk.Controls.Add(label1);
            panelProduk.Controls.Add(label12);
            panelProduk.Controls.Add(panel2);
            panelProduk.Location = new Point(14, 12);
            panelProduk.Name = "panelProduk";
            panelProduk.Size = new Size(316, 286);
            panelProduk.TabIndex = 41;
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.BackColor = Color.FromArgb(192, 255, 192);
            btnAddNewCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewCustomer.Location = new Point(214, 253);
            btnAddNewCustomer.Name = "btnAddNewCustomer";
            btnAddNewCustomer.Size = new Size(97, 27);
            btnAddNewCustomer.TabIndex = 30;
            btnAddNewCustomer.Text = "Add";
            btnAddNewCustomer.UseVisualStyleBackColor = false;
            btnAddNewCustomer.Click += btnAddNewCustomer_Click_1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(62, 166);
            label16.Name = "label16";
            label16.Size = new Size(64, 19);
            label16.TabIndex = 25;
            label16.Text = "Provinsi :";
            // 
            // cBoxKabupatenKota
            // 
            cBoxKabupatenKota.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxKabupatenKota.FormattingEnabled = true;
            cBoxKabupatenKota.Location = new Point(132, 193);
            cBoxKabupatenKota.Name = "cBoxKabupatenKota";
            cBoxKabupatenKota.Size = new Size(179, 25);
            cBoxKabupatenKota.TabIndex = 27;
            // 
            // cBoxProvinsi
            // 
            cBoxProvinsi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxProvinsi.FormattingEnabled = true;
            cBoxProvinsi.Location = new Point(132, 163);
            cBoxProvinsi.Name = "cBoxProvinsi";
            cBoxProvinsi.Size = new Size(179, 25);
            cBoxProvinsi.TabIndex = 26;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(55, 224);
            label20.Name = "label20";
            label20.Size = new Size(71, 19);
            label20.TabIndex = 26;
            label20.Text = "Zip Code :";
            // 
            // tBoxZipCode
            // 
            tBoxZipCode.BorderStyle = BorderStyle.FixedSingle;
            tBoxZipCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxZipCode.Location = new Point(132, 222);
            tBoxZipCode.Name = "tBoxZipCode";
            tBoxZipCode.Size = new Size(179, 25);
            tBoxZipCode.TabIndex = 24;
            // 
            // tBoxAlamat
            // 
            tBoxAlamat.BorderStyle = BorderStyle.FixedSingle;
            tBoxAlamat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxAlamat.Location = new Point(132, 133);
            tBoxAlamat.Name = "tBoxAlamat";
            tBoxAlamat.Size = new Size(179, 25);
            tBoxAlamat.TabIndex = 23;
            // 
            // tBoxContact
            // 
            tBoxContact.BorderStyle = BorderStyle.FixedSingle;
            tBoxContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxContact.Location = new Point(132, 102);
            tBoxContact.Name = "tBoxContact";
            tBoxContact.Size = new Size(179, 25);
            tBoxContact.TabIndex = 22;
            // 
            // tBoxPerusahaan
            // 
            tBoxPerusahaan.BorderStyle = BorderStyle.FixedSingle;
            tBoxPerusahaan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPerusahaan.Location = new Point(132, 69);
            tBoxPerusahaan.Name = "tBoxPerusahaan";
            tBoxPerusahaan.Size = new Size(179, 25);
            tBoxPerusahaan.TabIndex = 21;
            // 
            // tBoxNamaCust
            // 
            tBoxNamaCust.BorderStyle = BorderStyle.FixedSingle;
            tBoxNamaCust.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxNamaCust.Location = new Point(132, 38);
            tBoxNamaCust.Name = "tBoxNamaCust";
            tBoxNamaCust.Size = new Size(179, 25);
            tBoxNamaCust.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(67, 135);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 19;
            label9.Text = "Alamat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 196);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 18;
            label3.Text = "Kabupaten/Kota :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 71);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 17;
            label2.Text = "Perusahaan :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(62, 104);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 16;
            label1.Text = "Contact :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 40);
            label12.Name = "label12";
            label12.Size = new Size(52, 19);
            label12.TabIndex = 15;
            label12.Text = "Nama :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label19);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 29);
            panel2.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(11, 4);
            label19.Name = "label19";
            label19.Size = new Size(190, 19);
            label19.TabIndex = 13;
            label19.Text = "New Customer Information";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAddProduk);
            panel1.Controls.Add(numericUpDownQTY);
            panel1.Controls.Add(tBoxHargaBeli);
            panel1.Controls.Add(cBoxPackaging);
            panel1.Controls.Add(cBoxNamaProduk);
            panel1.Controls.Add(cBoxJenisProduk);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(14, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 227);
            panel1.TabIndex = 42;
            // 
            // btnAddProduk
            // 
            btnAddProduk.BackColor = Color.FromArgb(192, 255, 192);
            btnAddProduk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddProduk.Location = new Point(214, 194);
            btnAddProduk.Name = "btnAddProduk";
            btnAddProduk.Size = new Size(97, 27);
            btnAddProduk.TabIndex = 31;
            btnAddProduk.Text = "Add";
            btnAddProduk.UseVisualStyleBackColor = false;
            btnAddProduk.Click += btnAddProduk_Click_1;
            // 
            // numericUpDownQTY
            // 
            numericUpDownQTY.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownQTY.Location = new Point(132, 132);
            numericUpDownQTY.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownQTY.Name = "numericUpDownQTY";
            numericUpDownQTY.Size = new Size(179, 25);
            numericUpDownQTY.TabIndex = 38;
            // 
            // tBoxHargaBeli
            // 
            tBoxHargaBeli.BorderStyle = BorderStyle.FixedSingle;
            tBoxHargaBeli.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxHargaBeli.Location = new Point(132, 163);
            tBoxHargaBeli.Name = "tBoxHargaBeli";
            tBoxHargaBeli.Size = new Size(179, 25);
            tBoxHargaBeli.TabIndex = 25;
            // 
            // cBoxPackaging
            // 
            cBoxPackaging.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxPackaging.FormattingEnabled = true;
            cBoxPackaging.Location = new Point(132, 101);
            cBoxPackaging.Name = "cBoxPackaging";
            cBoxPackaging.Size = new Size(179, 25);
            cBoxPackaging.TabIndex = 22;
            // 
            // cBoxNamaProduk
            // 
            cBoxNamaProduk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxNamaProduk.FormattingEnabled = true;
            cBoxNamaProduk.Location = new Point(132, 70);
            cBoxNamaProduk.Name = "cBoxNamaProduk";
            cBoxNamaProduk.Size = new Size(179, 25);
            cBoxNamaProduk.TabIndex = 21;
            // 
            // cBoxJenisProduk
            // 
            cBoxJenisProduk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxJenisProduk.FormattingEnabled = true;
            cBoxJenisProduk.Location = new Point(132, 39);
            cBoxJenisProduk.Name = "cBoxJenisProduk";
            cBoxJenisProduk.Size = new Size(179, 25);
            cBoxJenisProduk.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(46, 165);
            label10.Name = "label10";
            label10.Size = new Size(78, 19);
            label10.TabIndex = 19;
            label10.Text = "Harga Beli :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 134);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 18;
            label4.Text = "Quantity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(81, 42);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 17;
            label5.Text = "Jenis :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 104);
            label6.Name = "label6";
            label6.Size = new Size(78, 19);
            label6.TabIndex = 16;
            label6.Text = "Packaging :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 73);
            label7.Name = "label7";
            label7.Size = new Size(99, 19);
            label7.TabIndex = 15;
            label7.Text = "Nama Barang :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(label8);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(316, 29);
            panel3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(11, 4);
            label8.Name = "label8";
            label8.Size = new Size(58, 19);
            label8.TabIndex = 13;
            label8.Text = "Produk";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label24);
            panel8.Controls.Add(numericUpDownPPN);
            panel8.Controls.Add(lblTotal);
            panel8.Controls.Add(lblSubTotal);
            panel8.Controls.Add(lblPPN);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(1040, 573);
            panel8.Name = "panel8";
            panel8.Size = new Size(316, 144);
            panel8.TabIndex = 43;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(17, 74);
            label24.Name = "label24";
            label24.Size = new Size(35, 19);
            label24.TabIndex = 40;
            label24.Text = "PPN";
            // 
            // numericUpDownPPN
            // 
            numericUpDownPPN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownPPN.Location = new Point(53, 72);
            numericUpDownPPN.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownPPN.Name = "numericUpDownPPN";
            numericUpDownPPN.Size = new Size(38, 25);
            numericUpDownPPN.TabIndex = 39;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(60, 104);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 19);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "Total :";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(33, 44);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(72, 19);
            lblSubTotal.TabIndex = 17;
            lblSubTotal.Text = "Sub Total :";
            // 
            // lblPPN
            // 
            lblPPN.AutoSize = true;
            lblPPN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPPN.Location = new Point(93, 74);
            lblPPN.Name = "lblPPN";
            lblPPN.Size = new Size(12, 19);
            lblPPN.TabIndex = 15;
            lblPPN.Text = ":";
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Controls.Add(label22);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(316, 29);
            panel9.TabIndex = 14;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.Location = new Point(11, 4);
            label22.Name = "label22";
            label22.Size = new Size(102, 19);
            label22.TabIndex = 13;
            label22.Text = "Total Subtotal";
            // 
            // FormBuatQuotation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 728);
            Controls.Add(panel8);
            Controls.Add(panel1);
            Controls.Add(panelProduk);
            Controls.Add(btnBack);
            Controls.Add(btnCreatePDF);
            Controls.Add(dataGridViewQuote);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Name = "FormBuatQuotation";
            Text = "FormBuatQuotation";
            Load += FormBuatQuotation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuote).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelProduk.ResumeLayout(false);
            panelProduk.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQTY).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPPN).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack;
        private Button btnCreatePDF;
        private DataGridView dataGridViewQuote;
        private Panel panel6;
        private TextBox tBoxTNC;
        private Panel panel7;
        private Label label21;
        private Panel panel4;
        private DateTimePicker dtpDueDate;
        private DateTimePicker dtpServiceOrder;
        private Label label13;
        private Label label17;
        private Panel panel5;
        private Label label18;
        private Panel panelProduk;
        private Button btnAddNewCustomer;
        private Label label16;
        private ComboBox cBoxKabupatenKota;
        private ComboBox cBoxProvinsi;
        private Label label20;
        private TextBox tBoxZipCode;
        private TextBox tBoxAlamat;
        private TextBox tBoxContact;
        private TextBox tBoxPerusahaan;
        private TextBox tBoxNamaCust;
        private Label label9;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label12;
        private Panel panel2;
        private Label label19;
        private Panel panel1;
        private Button btnAddProduk;
        private NumericUpDown numericUpDownQTY;
        private TextBox tBoxHargaBeli;
        private ComboBox cBoxPackaging;
        private ComboBox cBoxNamaProduk;
        private ComboBox cBoxJenisProduk;
        private Label label10;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Panel panel8;
        private Label label24;
        private NumericUpDown numericUpDownPPN;
        private Label lblTotal;
        private Label lblSubTotal;
        private Label lblPPN;
        private Panel panel9;
        private Label label22;
        private ComboBox cBoxCustomer;
        private Label label23;
    }
}