namespace Waterpediaa
{
    partial class FormBuatReceipt
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
            panel4 = new Panel();
            btnUpdate = new Button();
            cBoxParentInvID = new ComboBox();
            label1 = new Label();
            panel5 = new Panel();
            label18 = new Label();
            dtpReceiptDate = new DateTimePicker();
            label17 = new Label();
            dataGridViewReceipt = new DataGridView();
            panel8 = new Panel();
            lblTotal = new Label();
            lblSubTotal = new Label();
            lblPPN = new Label();
            panel9 = new Panel();
            label22 = new Label();
            panel6 = new Panel();
            tBoxOtherComments = new TextBox();
            panel7 = new Panel();
            label21 = new Label();
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
            label4 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            label19 = new Label();
            panel1 = new Panel();
            tBoxTTD = new TextBox();
            label6 = new Label();
            cBoxCustomer = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            btnCreatePDF = new Button();
            btnBack = new Button();
            dataGridViewReceipt2 = new DataGridView();
            btnConfirmProvinsi = new Button();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReceipt).BeginInit();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panelProduk.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReceipt2).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(cBoxParentInvID);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(317, 101);
            panel4.TabIndex = 33;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 192);
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(215, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(97, 30);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cBoxParentInvID
            // 
            cBoxParentInvID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxParentInvID.FormattingEnabled = true;
            cBoxParentInvID.Location = new Point(133, 35);
            cBoxParentInvID.Name = "cBoxParentInvID";
            cBoxParentInvID.Size = new Size(179, 25);
            cBoxParentInvID.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 38);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 46;
            label1.Text = "Invoice :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.Controls.Add(label18);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1349, 29);
            panel5.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(11, 4);
            label18.Name = "label18";
            label18.Size = new Size(118, 19);
            label18.TabIndex = 13;
            label18.Text = "Selected Invoice";
            // 
            // dtpReceiptDate
            // 
            dtpReceiptDate.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpReceiptDate.Location = new Point(132, 97);
            dtpReceiptDate.Name = "dtpReceiptDate";
            dtpReceiptDate.Size = new Size(179, 23);
            dtpReceiptDate.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(81, 97);
            label17.Name = "label17";
            label17.Size = new Size(45, 19);
            label17.TabIndex = 15;
            label17.Text = "Date :";
            // 
            // dataGridViewReceipt
            // 
            dataGridViewReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReceipt.Location = new Point(335, 344);
            dataGridViewReceipt.Name = "dataGridViewReceipt";
            dataGridViewReceipt.RowTemplate.Height = 25;
            dataGridViewReceipt.Size = new Size(1021, 188);
            dataGridViewReceipt.TabIndex = 37;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblTotal);
            panel8.Controls.Add(lblSubTotal);
            panel8.Controls.Add(lblPPN);
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(1040, 537);
            panel8.Name = "panel8";
            panel8.Size = new Size(316, 179);
            panel8.TabIndex = 44;
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
            lblPPN.Location = new Point(63, 75);
            lblPPN.Name = "lblPPN";
            lblPPN.Size = new Size(42, 19);
            lblPPN.TabIndex = 15;
            lblPPN.Text = "PPN :";
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
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(tBoxOtherComments);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(12, 557);
            panel6.Name = "panel6";
            panel6.Size = new Size(316, 159);
            panel6.TabIndex = 45;
            // 
            // tBoxOtherComments
            // 
            tBoxOtherComments.BorderStyle = BorderStyle.FixedSingle;
            tBoxOtherComments.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxOtherComments.Location = new Point(3, 35);
            tBoxOtherComments.Multiline = true;
            tBoxOtherComments.Name = "tBoxOtherComments";
            tBoxOtherComments.Size = new Size(308, 119);
            tBoxOtherComments.TabIndex = 15;
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
            label21.Size = new Size(122, 19);
            label21.TabIndex = 13;
            label21.Text = "Other Comments";
            // 
            // panelProduk
            // 
            panelProduk.BorderStyle = BorderStyle.FixedSingle;
            panelProduk.Controls.Add(btnConfirmProvinsi);
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
            panelProduk.Controls.Add(label4);
            panelProduk.Controls.Add(label12);
            panelProduk.Controls.Add(panel2);
            panelProduk.Location = new Point(12, 119);
            panelProduk.Name = "panelProduk";
            panelProduk.Size = new Size(316, 299);
            panelProduk.TabIndex = 46;
            // 
            // btnAddNewCustomer
            // 
            btnAddNewCustomer.BackColor = Color.FromArgb(192, 255, 192);
            btnAddNewCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewCustomer.Location = new Point(214, 267);
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
            label16.Location = new Point(62, 159);
            label16.Name = "label16";
            label16.Size = new Size(64, 19);
            label16.TabIndex = 25;
            label16.Text = "Provinsi :";
            // 
            // cBoxKabupatenKota
            // 
            cBoxKabupatenKota.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxKabupatenKota.FormattingEnabled = true;
            cBoxKabupatenKota.Location = new Point(133, 208);
            cBoxKabupatenKota.Name = "cBoxKabupatenKota";
            cBoxKabupatenKota.Size = new Size(179, 25);
            cBoxKabupatenKota.TabIndex = 27;
            // 
            // cBoxProvinsi
            // 
            cBoxProvinsi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxProvinsi.FormattingEnabled = true;
            cBoxProvinsi.Location = new Point(132, 156);
            cBoxProvinsi.Name = "cBoxProvinsi";
            cBoxProvinsi.Size = new Size(179, 25);
            cBoxProvinsi.TabIndex = 26;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(56, 238);
            label20.Name = "label20";
            label20.Size = new Size(71, 19);
            label20.TabIndex = 26;
            label20.Text = "Zip Code :";
            // 
            // tBoxZipCode
            // 
            tBoxZipCode.BorderStyle = BorderStyle.FixedSingle;
            tBoxZipCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxZipCode.Location = new Point(133, 236);
            tBoxZipCode.Name = "tBoxZipCode";
            tBoxZipCode.Size = new Size(179, 25);
            tBoxZipCode.TabIndex = 24;
            // 
            // tBoxAlamat
            // 
            tBoxAlamat.BorderStyle = BorderStyle.FixedSingle;
            tBoxAlamat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxAlamat.Location = new Point(132, 128);
            tBoxAlamat.Name = "tBoxAlamat";
            tBoxAlamat.Size = new Size(179, 25);
            tBoxAlamat.TabIndex = 23;
            // 
            // tBoxContact
            // 
            tBoxContact.BorderStyle = BorderStyle.FixedSingle;
            tBoxContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxContact.Location = new Point(132, 97);
            tBoxContact.Name = "tBoxContact";
            tBoxContact.Size = new Size(179, 25);
            tBoxContact.TabIndex = 22;
            // 
            // tBoxPerusahaan
            // 
            tBoxPerusahaan.BorderStyle = BorderStyle.FixedSingle;
            tBoxPerusahaan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPerusahaan.Location = new Point(132, 66);
            tBoxPerusahaan.Name = "tBoxPerusahaan";
            tBoxPerusahaan.Size = new Size(179, 25);
            tBoxPerusahaan.TabIndex = 21;
            // 
            // tBoxNamaCust
            // 
            tBoxNamaCust.BorderStyle = BorderStyle.FixedSingle;
            tBoxNamaCust.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxNamaCust.Location = new Point(132, 35);
            tBoxNamaCust.Name = "tBoxNamaCust";
            tBoxNamaCust.Size = new Size(179, 25);
            tBoxNamaCust.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(67, 130);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 19;
            label9.Text = "Alamat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 18;
            label3.Text = "Kabupaten/Kota :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 68);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 17;
            label2.Text = "Perusahaan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 99);
            label4.Name = "label4";
            label4.Size = new Size(64, 19);
            label4.TabIndex = 16;
            label4.Text = "Contact :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 37);
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
            panel1.Controls.Add(tBoxTTD);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cBoxCustomer);
            panel1.Controls.Add(dtpReceiptDate);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 424);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 127);
            panel1.TabIndex = 48;
            // 
            // tBoxTTD
            // 
            tBoxTTD.BorderStyle = BorderStyle.FixedSingle;
            tBoxTTD.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxTTD.Location = new Point(132, 66);
            tBoxTTD.Name = "tBoxTTD";
            tBoxTTD.Size = new Size(179, 25);
            tBoxTTD.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 69);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 48;
            label6.Text = "Ber TTD :";
            // 
            // cBoxCustomer
            // 
            cBoxCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxCustomer.FormattingEnabled = true;
            cBoxCustomer.Location = new Point(132, 35);
            cBoxCustomer.Name = "cBoxCustomer";
            cBoxCustomer.Size = new Size(179, 25);
            cBoxCustomer.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(75, 38);
            label5.Name = "label5";
            label5.Size = new Size(51, 19);
            label5.TabIndex = 46;
            label5.Text = "Bill To :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(label7);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1018, 29);
            panel3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(11, 4);
            label7.Name = "label7";
            label7.Size = new Size(142, 19);
            label7.TabIndex = 13;
            label7.Text = "Receipt Information";
            // 
            // btnCreatePDF
            // 
            btnCreatePDF.BackColor = Color.FromArgb(192, 255, 192);
            btnCreatePDF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreatePDF.Location = new Point(335, 542);
            btnCreatePDF.Name = "btnCreatePDF";
            btnCreatePDF.Size = new Size(119, 49);
            btnCreatePDF.TabIndex = 49;
            btnCreatePDF.Text = "Create \r\nReceipt";
            btnCreatePDF.UseVisualStyleBackColor = false;
            btnCreatePDF.Click += btnCreatePDF_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(335, 674);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 38);
            btnBack.TabIndex = 50;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // dataGridViewReceipt2
            // 
            dataGridViewReceipt2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReceipt2.Location = new Point(335, 13);
            dataGridViewReceipt2.Name = "dataGridViewReceipt2";
            dataGridViewReceipt2.RowTemplate.Height = 25;
            dataGridViewReceipt2.Size = new Size(1021, 325);
            dataGridViewReceipt2.TabIndex = 51;
            // 
            // btnConfirmProvinsi
            // 
            btnConfirmProvinsi.BackColor = Color.FromArgb(192, 255, 192);
            btnConfirmProvinsi.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmProvinsi.Location = new Point(230, 185);
            btnConfirmProvinsi.Name = "btnConfirmProvinsi";
            btnConfirmProvinsi.Size = new Size(81, 19);
            btnConfirmProvinsi.TabIndex = 41;
            btnConfirmProvinsi.Text = "Refresh";
            btnConfirmProvinsi.UseVisualStyleBackColor = false;
            btnConfirmProvinsi.Click += btnConfirmProvinsi_Click;
            // 
            // FormBuatReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 728);
            Controls.Add(dataGridViewReceipt2);
            Controls.Add(btnBack);
            Controls.Add(btnCreatePDF);
            Controls.Add(panel1);
            Controls.Add(panelProduk);
            Controls.Add(panel6);
            Controls.Add(panel8);
            Controls.Add(dataGridViewReceipt);
            Controls.Add(panel4);
            Name = "FormBuatReceipt";
            Text = "FormBuatReceipt";
            Load += FormBuatReceipt_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReceipt).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panelProduk.ResumeLayout(false);
            panelProduk.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReceipt2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private DateTimePicker dtpReceiptDate;
        private Label label17;
        private Panel panel5;
        private Label label18;
        private ComboBox cBoxParentInvID;
        private Label label1;
        private DataGridView dataGridViewReceipt;
        private Panel panel8;
        private Label lblTotal;
        private Label lblSubTotal;
        private Label lblPPN;
        private Panel panel9;
        private Label label22;
        private Panel panel6;
        private TextBox tBoxOtherComments;
        private Panel panel7;
        private Label label21;
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
        private Label label4;
        private Label label12;
        private Panel panel2;
        private Label label19;
        private Panel panel1;
        private ComboBox cBoxCustomer;
        private Label label5;
        private Panel panel3;
        private Label label7;
        private Button btnCreatePDF;
        private Button btnBack;
        private Label label6;
        private TextBox tBoxTTD;
        private Button btnUpdate;
        private DataGridView dataGridViewReceipt2;
        private Button btnConfirmProvinsi;
    }
}