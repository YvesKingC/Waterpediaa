namespace Waterpediaa
{
    partial class FormPilihDivisi
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
            lblWellcome = new Label();
            btnLogout = new Button();
            btnWTP = new Button();
            btnBakteri = new Button();
            panel1 = new Panel();
            btnProcure = new Button();
            btnQuotation = new Button();
            btnInvoice = new Button();
            btnViewUser = new Button();
            panel2 = new Panel();
            btnSales = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblWellcome
            // 
            lblWellcome.AutoSize = true;
            lblWellcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWellcome.Location = new Point(12, 13);
            lblWellcome.Name = "lblWellcome";
            lblWellcome.Size = new Size(127, 37);
            lblWellcome.TabIndex = 15;
            lblWellcome.Text = "Welcome";
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(22, 202);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(72, 31);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnWTP
            // 
            btnWTP.AutoSize = true;
            btnWTP.BackColor = Color.FromArgb(192, 255, 255);
            btnWTP.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnWTP.Location = new Point(240, 20);
            btnWTP.Name = "btnWTP";
            btnWTP.Size = new Size(180, 158);
            btnWTP.TabIndex = 12;
            btnWTP.Text = "Divisi WTP";
            btnWTP.UseVisualStyleBackColor = false;
            btnWTP.Click += btnWTP_Click;
            // 
            // btnBakteri
            // 
            btnBakteri.AutoSize = true;
            btnBakteri.BackColor = Color.FromArgb(192, 255, 255);
            btnBakteri.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnBakteri.Location = new Point(22, 20);
            btnBakteri.Name = "btnBakteri";
            btnBakteri.Size = new Size(180, 158);
            btnBakteri.TabIndex = 11;
            btnBakteri.Text = "Divisi Bakteri";
            btnBakteri.UseVisualStyleBackColor = false;
            btnBakteri.Click += btnBakteri_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(lblWellcome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 65);
            panel1.TabIndex = 16;
            // 
            // 
            // btnQuotation
            // 
            btnQuotation.AutoSize = true;
            btnQuotation.BackColor = Color.FromArgb(192, 255, 255);
            btnQuotation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuotation.Location = new Point(446, 77);
            btnQuotation.Name = "btnQuotation";
            btnQuotation.Size = new Size(180, 48);
            btnQuotation.TabIndex = 18;
            btnQuotation.Text = "Quotation";
            btnQuotation.UseVisualStyleBackColor = false;
            btnQuotation.Click += btnQuotation_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.AutoSize = true;
            btnInvoice.BackColor = Color.FromArgb(192, 255, 255);
            btnInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.Location = new Point(446, 131);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(180, 48);
            btnInvoice.TabIndex = 19;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // btnViewUser
            // 
            btnViewUser.AutoSize = true;
            btnViewUser.BackColor = Color.FromArgb(192, 255, 255);
            btnViewUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewUser.Location = new Point(240, 184);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(180, 48);
            btnViewUser.TabIndex = 20;
            btnViewUser.Text = "View User";
            btnViewUser.UseVisualStyleBackColor = false;
            btnViewUser.Click += btnViewUser_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnSales);
            panel2.Controls.Add(btnWTP);
            panel2.Controls.Add(btnViewUser);
            panel2.Controls.Add(btnBakteri);
            panel2.Controls.Add(btnInvoice);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnQuotation);
            panel2.Controls.Add(btnProcure);
            panel2.Location = new Point(13, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(644, 251);
            panel2.TabIndex = 21;
            // 
            // btnSales
            // 
            btnSales.AutoSize = true;
            btnSales.BackColor = Color.FromArgb(192, 255, 255);
            btnSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSales.Location = new Point(446, 185);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(180, 48);
            btnSales.TabIndex = 21;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // FormPilihDivisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(669, 344);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormPilihDivisi";
            Text = "FormPilihDivisi";
            Load += FormPilihDivisi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWellcome;
        private Button btnLogout;
        private Button btnWTP;
        private Button btnBakteri;
        private Panel panel1;
        private Button btnProcure;
        private Button btnQuotation;
        private Button btnInvoice;
        private Button btnViewUser;
        private Panel panel2;
        private Button btnSales;
    }
}