namespace Waterpediaa
{
    partial class FormInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInvoice));
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelInvoice = new Panel();
            tBoxInvoiceID = new TextBox();
            tBoxDueDate = new TextBox();
            tBoxServiceOrder = new TextBox();
            label23 = new Label();
            label21 = new Label();
            label14 = new Label();
            panel8 = new Panel();
            panel5 = new Panel();
            lblPPN = new Label();
            panel9 = new Panel();
            lblSubTotal = new Label();
            panel4 = new Panel();
            lblTotal = new Label();
            panel1 = new Panel();
            tBoxOtherComments = new TextBox();
            panel3 = new Panel();
            label16 = new Label();
            panelProduk = new Panel();
            dataGridViewInvoice = new DataGridView();
            panel2 = new Panel();
            label19 = new Label();
            panelBillTo = new Panel();
            tBoxMetodePembayaran = new TextBox();
            tBoxContact = new TextBox();
            tBoxDetailCustomer = new TextBox();
            label18 = new Label();
            label15 = new Label();
            label13 = new Label();
            label12 = new Label();
            panelHeader1 = new Panel();
            label11 = new Label();
            linkLblWaterpedia = new LinkLabel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCreatePDF = new Button();
            btnBack = new Button();
            panelInvoice.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panelProduk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            panel2.SuspendLayout();
            panelBillTo.SuspendLayout();
            panelHeader1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // panelInvoice
            // 
            panelInvoice.AutoSize = true;
            panelInvoice.BackColor = Color.White;
            panelInvoice.Controls.Add(tBoxInvoiceID);
            panelInvoice.Controls.Add(tBoxDueDate);
            panelInvoice.Controls.Add(tBoxServiceOrder);
            panelInvoice.Controls.Add(label23);
            panelInvoice.Controls.Add(label21);
            panelInvoice.Controls.Add(label14);
            panelInvoice.Controls.Add(panel8);
            panelInvoice.Controls.Add(panel1);
            panelInvoice.Controls.Add(panelProduk);
            panelInvoice.Controls.Add(panelBillTo);
            panelInvoice.Controls.Add(linkLblWaterpedia);
            panelInvoice.Controls.Add(label10);
            panelInvoice.Controls.Add(label9);
            panelInvoice.Controls.Add(label8);
            panelInvoice.Controls.Add(label7);
            panelInvoice.Controls.Add(label6);
            panelInvoice.Controls.Add(label5);
            panelInvoice.Controls.Add(label4);
            panelInvoice.Controls.Add(label3);
            panelInvoice.Controls.Add(label2);
            panelInvoice.Controls.Add(pictureBox1);
            panelInvoice.Controls.Add(label1);
            panelInvoice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            panelInvoice.Location = new Point(0, 0);
            panelInvoice.Name = "panelInvoice";
            panelInvoice.Size = new Size(794, 1100);
            panelInvoice.TabIndex = 30;
            // 
            // tBoxInvoiceID
            // 
            tBoxInvoiceID.BorderStyle = BorderStyle.FixedSingle;
            tBoxInvoiceID.Location = new Point(581, 241);
            tBoxInvoiceID.Name = "tBoxInvoiceID";
            tBoxInvoiceID.Size = new Size(172, 25);
            tBoxInvoiceID.TabIndex = 52;
            // 
            // tBoxDueDate
            // 
            tBoxDueDate.BorderStyle = BorderStyle.FixedSingle;
            tBoxDueDate.Location = new Point(581, 210);
            tBoxDueDate.Name = "tBoxDueDate";
            tBoxDueDate.Size = new Size(172, 25);
            tBoxDueDate.TabIndex = 51;
            // 
            // tBoxServiceOrder
            // 
            tBoxServiceOrder.BorderStyle = BorderStyle.FixedSingle;
            tBoxServiceOrder.Location = new Point(581, 179);
            tBoxServiceOrder.Name = "tBoxServiceOrder";
            tBoxServiceOrder.Size = new Size(172, 25);
            tBoxServiceOrder.TabIndex = 50;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(516, 243);
            label23.Name = "label23";
            label23.Size = new Size(59, 19);
            label23.TabIndex = 49;
            label23.Text = "Invoice :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(501, 212);
            label21.Name = "label21";
            label21.Size = new Size(74, 19);
            label21.TabIndex = 48;
            label21.Text = "Due Date :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(477, 181);
            label14.Name = "label14";
            label14.Size = new Size(98, 19);
            label14.TabIndex = 47;
            label14.Text = "Service Order :";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(panel5);
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(panel4);
            panel8.Location = new Point(455, 800);
            panel8.Name = "panel8";
            panel8.Size = new Size(302, 102);
            panel8.TabIndex = 46;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.Controls.Add(lblPPN);
            panel5.Location = new Point(0, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(302, 29);
            panel5.TabIndex = 16;
            // 
            // lblPPN
            // 
            lblPPN.AutoSize = true;
            lblPPN.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPPN.ForeColor = Color.FromArgb(224, 224, 224);
            lblPPN.Location = new Point(44, 5);
            lblPPN.Name = "lblPPN";
            lblPPN.Size = new Size(46, 19);
            lblPPN.TabIndex = 13;
            lblPPN.Text = "PPN :";
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkBlue;
            panel9.Controls.Add(lblSubTotal);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(316, 29);
            panel9.TabIndex = 14;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.ForeColor = Color.FromArgb(224, 224, 224);
            lblSubTotal.Location = new Point(11, 4);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(79, 19);
            lblSubTotal.TabIndex = 13;
            lblSubTotal.Text = "Sub Total :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(lblTotal);
            panel4.Location = new Point(0, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 29);
            panel4.TabIndex = 15;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.FromArgb(224, 224, 224);
            lblTotal.Location = new Point(41, 5);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 19);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total :";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tBoxOtherComments);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(36, 800);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 200);
            panel1.TabIndex = 45;
            // 
            // tBoxOtherComments
            // 
            tBoxOtherComments.BorderStyle = BorderStyle.FixedSingle;
            tBoxOtherComments.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxOtherComments.Location = new Point(3, 35);
            tBoxOtherComments.Multiline = true;
            tBoxOtherComments.Name = "tBoxOtherComments";
            tBoxOtherComments.Size = new Size(406, 160);
            tBoxOtherComments.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(label16);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 29);
            panel3.TabIndex = 14;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(11, 4);
            label16.Name = "label16";
            label16.Size = new Size(122, 19);
            label16.TabIndex = 13;
            label16.Text = "Other Comments";
            // 
            // panelProduk
            // 
            panelProduk.BorderStyle = BorderStyle.FixedSingle;
            panelProduk.Controls.Add(dataGridViewInvoice);
            panelProduk.Controls.Add(panel2);
            panelProduk.Location = new Point(37, 520);
            panelProduk.Name = "panelProduk";
            panelProduk.Size = new Size(720, 274);
            panelProduk.TabIndex = 44;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Location = new Point(3, 35);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowTemplate.Height = 25;
            dataGridViewInvoice.Size = new Size(712, 234);
            dataGridViewInvoice.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label19);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 29);
            panel2.TabIndex = 14;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(11, 4);
            label19.Name = "label19";
            label19.Size = new Size(107, 19);
            label19.TabIndex = 13;
            label19.Text = "PRODUK/JASA";
            // 
            // panelBillTo
            // 
            panelBillTo.BackColor = Color.White;
            panelBillTo.BorderStyle = BorderStyle.FixedSingle;
            panelBillTo.Controls.Add(tBoxMetodePembayaran);
            panelBillTo.Controls.Add(tBoxContact);
            panelBillTo.Controls.Add(tBoxDetailCustomer);
            panelBillTo.Controls.Add(label18);
            panelBillTo.Controls.Add(label15);
            panelBillTo.Controls.Add(label13);
            panelBillTo.Controls.Add(label12);
            panelBillTo.Controls.Add(panelHeader1);
            panelBillTo.Location = new Point(36, 312);
            panelBillTo.Name = "panelBillTo";
            panelBillTo.Size = new Size(721, 202);
            panelBillTo.TabIndex = 42;
            // 
            // tBoxMetodePembayaran
            // 
            tBoxMetodePembayaran.BorderStyle = BorderStyle.None;
            tBoxMetodePembayaran.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxMetodePembayaran.Location = new Point(449, 89);
            tBoxMetodePembayaran.Multiline = true;
            tBoxMetodePembayaran.Name = "tBoxMetodePembayaran";
            tBoxMetodePembayaran.Size = new Size(241, 49);
            tBoxMetodePembayaran.TabIndex = 22;
            // 
            // tBoxContact
            // 
            tBoxContact.BorderStyle = BorderStyle.None;
            tBoxContact.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxContact.Location = new Point(449, 159);
            tBoxContact.Name = "tBoxContact";
            tBoxContact.Size = new Size(241, 18);
            tBoxContact.TabIndex = 21;
            // 
            // tBoxDetailCustomer
            // 
            tBoxDetailCustomer.BorderStyle = BorderStyle.FixedSingle;
            tBoxDetailCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxDetailCustomer.Location = new Point(75, 42);
            tBoxDetailCustomer.Multiline = true;
            tBoxDetailCustomer.Name = "tBoxDetailCustomer";
            tBoxDetailCustomer.Size = new Size(351, 139);
            tBoxDetailCustomer.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(449, 141);
            label18.Name = "label18";
            label18.Size = new Size(158, 15);
            label18.TabIndex = 19;
            label18.Text = "Confirmation after payment:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(449, 72);
            label15.Name = "label15";
            label15.Size = new Size(191, 15);
            label15.TabIndex = 16;
            label15.Text = "Pembayaran bisa melalui Rekening";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(449, 42);
            label13.Name = "label13";
            label13.Size = new Size(142, 30);
            label13.TabIndex = 15;
            label13.Text = "Payment by transfer bank\r\nTransfer to Waterpedia\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(24, 44);
            label12.Name = "label12";
            label12.Size = new Size(45, 19);
            label12.TabIndex = 13;
            label12.Text = "Dear :";
            // 
            // panelHeader1
            // 
            panelHeader1.BackColor = Color.DarkBlue;
            panelHeader1.Controls.Add(label11);
            panelHeader1.Location = new Point(0, 0);
            panelHeader1.Name = "panelHeader1";
            panelHeader1.Size = new Size(720, 29);
            panelHeader1.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(11, 4);
            label11.Name = "label11";
            label11.Size = new Size(58, 19);
            label11.TabIndex = 13;
            label11.Text = "BILL TO";
            // 
            // linkLblWaterpedia
            // 
            linkLblWaterpedia.AutoSize = true;
            linkLblWaterpedia.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLblWaterpedia.Location = new Point(116, 280);
            linkLblWaterpedia.Name = "linkLblWaterpedia";
            linkLblWaterpedia.Size = new Size(154, 19);
            linkLblWaterpedia.TabIndex = 41;
            linkLblWaterpedia.TabStop = true;
            linkLblWaterpedia.Text = "https://Waterpedia.co.id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(116, 259);
            label10.Name = "label10";
            label10.Size = new Size(177, 19);
            label10.TabIndex = 40;
            label10.Text = "info.waterpedia@gmail.com";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(116, 239);
            label9.Name = "label9";
            label9.Size = new Size(127, 19);
            label9.TabIndex = 39;
            label9.Text = "[+6231 3977 660 ]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(106, 280);
            label8.Name = "label8";
            label8.Size = new Size(12, 19);
            label8.TabIndex = 38;
            label8.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(106, 259);
            label7.Name = "label7";
            label7.Size = new Size(12, 19);
            label7.TabIndex = 37;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(106, 239);
            label6.Name = "label6";
            label6.Size = new Size(12, 19);
            label6.TabIndex = 36;
            label6.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 280);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 35;
            label5.Text = "Website";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 259);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 34;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 239);
            label3.Name = "label3";
            label3.Size = new Size(33, 19);
            label3.TabIndex = 33;
            label3.Text = "Telp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(48, 179);
            label2.Name = "label2";
            label2.Size = new Size(427, 60);
            label2.TabIndex = 32;
            label2.Text = "PT. Waterpedia Rejeki Langit\r\nTraining & Consulting | Water & Wastewater Treatement\r\njl. Raya Tenaru No.2 Driorejo, Gresik, Jawa Timur, Indonesia\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logo_Waterpedia_PNG;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(36, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(558, 34);
            label1.Name = "label1";
            label1.Size = new Size(199, 59);
            label1.TabIndex = 30;
            label1.Text = "INVOICE";
            // 
            // btnCreatePDF
            // 
            btnCreatePDF.BackColor = Color.FromArgb(192, 255, 192);
            btnCreatePDF.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreatePDF.Location = new Point(822, 446);
            btnCreatePDF.Name = "btnCreatePDF";
            btnCreatePDF.Size = new Size(96, 35);
            btnCreatePDF.TabIndex = 31;
            btnCreatePDF.Text = "Create PDF";
            btnCreatePDF.UseVisualStyleBackColor = false;
            btnCreatePDF.Click += btnCreatePDF_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(821, 487);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 27);
            btnBack.TabIndex = 32;
            btnBack.Text = "Calcel";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(948, 1061);
            Controls.Add(btnBack);
            Controls.Add(btnCreatePDF);
            Controls.Add(panelInvoice);
            Name = "FormInvoice";
            Text = "FormInvoice";
            Load += FormInvoice_Load;
            panelInvoice.ResumeLayout(false);
            panelInvoice.PerformLayout();
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelProduk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelBillTo.ResumeLayout(false);
            panelBillTo.PerformLayout();
            panelHeader1.ResumeLayout(false);
            panelHeader1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panelInvoice;
        private Panel panelProduk;
        private Panel panel2;
        private Label label19;
        private Panel panelBillTo;
        private TextBox tBoxMetodePembayaran;
        private TextBox tBoxContact;
        private TextBox tBoxDetailCustomer;
        private Label label18;
        private Label label15;
        private Label label13;
        private Label label12;
        private Panel panelHeader1;
        private Label label11;
        private LinkLabel linkLblWaterpedia;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnCreatePDF;
        private Panel panel1;
        private Panel panel3;
        private Label label16;
        private Panel panel4;
        private Label lblTotal;
        private Panel panel8;
        private Panel panel5;
        private Label lblPPN;
        private Panel panel9;
        private Label lblSubTotal;
        private TextBox tBoxOtherComments;
        private DataGridView dataGridViewInvoice;
        private Label label23;
        private Label label21;
        private Label label14;
        private TextBox tBoxServiceOrder;
        private TextBox tBoxInvoiceID;
        private TextBox tBoxDueDate;
        private Button btnBack;
    }
}