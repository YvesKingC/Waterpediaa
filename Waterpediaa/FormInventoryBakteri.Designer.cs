namespace Waterpediaa
{
    partial class FormInventoryBakteri
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
            buttonAddPackaging = new Button();
            buttonAddBakteri = new Button();
            buttonInvoice = new Button();
            buttonEditItem = new Button();
            buttonSearch = new Button();
            dgvInventoryBakteri = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryBakteri).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(725, 425);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 29);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // buttonAddPackaging
            // 
            buttonAddPackaging.Anchor = AnchorStyles.None;
            buttonAddPackaging.Location = new Point(725, 222);
            buttonAddPackaging.Name = "buttonAddPackaging";
            buttonAddPackaging.Size = new Size(143, 29);
            buttonAddPackaging.TabIndex = 32;
            buttonAddPackaging.Text = "Paket Bakteri";
            buttonAddPackaging.UseVisualStyleBackColor = true;
            buttonAddPackaging.Click += buttonAddPackaging_Click;
            // 
            // buttonAddBakteri
            // 
            buttonAddBakteri.Anchor = AnchorStyles.None;
            buttonAddBakteri.Location = new Point(725, 186);
            buttonAddBakteri.Name = "buttonAddBakteri";
            buttonAddBakteri.Size = new Size(143, 29);
            buttonAddBakteri.TabIndex = 31;
            buttonAddBakteri.Text = "Bakteri Baru";
            buttonAddBakteri.UseVisualStyleBackColor = true;
            buttonAddBakteri.Click += buttonAddBakteri_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.Anchor = AnchorStyles.None;
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.Location = new Point(725, 290);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(143, 29);
            buttonInvoice.TabIndex = 30;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            buttonInvoice.Click += buttonInvoice_Click;
            // 
            // buttonEditItem
            // 
            buttonEditItem.Anchor = AnchorStyles.None;
            buttonEditItem.Location = new Point(725, 152);
            buttonEditItem.Name = "buttonEditItem";
            buttonEditItem.Size = new Size(143, 29);
            buttonEditItem.TabIndex = 28;
            buttonEditItem.Text = "Edit Item";
            buttonEditItem.UseVisualStyleBackColor = true;
            buttonEditItem.Click += buttonEditItem_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.None;
            buttonSearch.BackColor = Color.White;
            buttonSearch.ForeColor = SystemColors.ControlText;
            buttonSearch.Location = new Point(723, 27);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(143, 29);
            buttonSearch.TabIndex = 27;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // dgvInventoryBakteri
            // 
            dgvInventoryBakteri.AllowUserToAddRows = false;
            dgvInventoryBakteri.AllowUserToDeleteRows = false;
            dgvInventoryBakteri.Anchor = AnchorStyles.None;
            dgvInventoryBakteri.BackgroundColor = SystemColors.ScrollBar;
            dgvInventoryBakteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryBakteri.Location = new Point(48, 67);
            dgvInventoryBakteri.Name = "dgvInventoryBakteri";
            dgvInventoryBakteri.ReadOnly = true;
            dgvInventoryBakteri.RowHeadersWidth = 51;
            dgvInventoryBakteri.RowTemplate.Height = 29;
            dgvInventoryBakteri.Size = new Size(650, 388);
            dgvInventoryBakteri.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(48, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(650, 27);
            textBox1.TabIndex = 23;
            // 
            // FormInventoryBakteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 481);
            Controls.Add(btnBack);
            Controls.Add(buttonAddPackaging);
            Controls.Add(buttonAddBakteri);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditItem);
            Controls.Add(buttonSearch);
            Controls.Add(dgvInventoryBakteri);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormInventoryBakteri";
            Text = "FormInventoryBakteri";
            ((System.ComponentModel.ISupportInitialize)dgvInventoryBakteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button buttonAddPackaging;
        private Button buttonAddBakteri;
        private Button buttonInvoice;
        private Button buttonEditItem;
        private Button buttonSearch;
        private DataGridView dgvInventoryBakteri;
        private TextBox textBox1;
    }
}