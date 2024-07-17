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
            buttonAddBakteri = new Button();
            buttonInvoice = new Button();
            buttonEditItem = new Button();
            buttonSearch = new Button();
            dgvInventoryBakteri = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryBakteri).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(634, 319);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 22);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // buttonAddBakteri
            // 
            buttonAddBakteri.Anchor = AnchorStyles.None;
            buttonAddBakteri.Location = new Point(634, 107);
            buttonAddBakteri.Margin = new Padding(3, 2, 3, 2);
            buttonAddBakteri.Name = "buttonAddBakteri";
            buttonAddBakteri.Size = new Size(125, 22);
            buttonAddBakteri.TabIndex = 31;
            buttonAddBakteri.Text = "Bakteri Baru";
            buttonAddBakteri.UseVisualStyleBackColor = true;
            // 
            // buttonInvoice
            // 
            buttonInvoice.Anchor = AnchorStyles.None;
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.Location = new Point(634, 293);
            buttonInvoice.Margin = new Padding(3, 2, 3, 2);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(125, 22);
            buttonInvoice.TabIndex = 30;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            // 
            // buttonEditItem
            // 
            buttonEditItem.Anchor = AnchorStyles.None;
            buttonEditItem.Location = new Point(633, 81);
            buttonEditItem.Margin = new Padding(3, 2, 3, 2);
            buttonEditItem.Name = "buttonEditItem";
            buttonEditItem.Size = new Size(125, 22);
            buttonEditItem.TabIndex = 28;
            buttonEditItem.Text = "Edit Item";
            buttonEditItem.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.None;
            buttonSearch.BackColor = Color.White;
            buttonSearch.ForeColor = SystemColors.ControlText;
            buttonSearch.Location = new Point(633, 20);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(125, 22);
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
            dgvInventoryBakteri.Location = new Point(42, 50);
            dgvInventoryBakteri.Margin = new Padding(3, 2, 3, 2);
            dgvInventoryBakteri.Name = "dgvInventoryBakteri";
            dgvInventoryBakteri.ReadOnly = true;
            dgvInventoryBakteri.RowHeadersWidth = 51;
            dgvInventoryBakteri.RowTemplate.Height = 29;
            dgvInventoryBakteri.Size = new Size(569, 291);
            dgvInventoryBakteri.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(42, 21);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(569, 23);
            textBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(633, 133);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(125, 22);
            button1.TabIndex = 35;
            button1.Text = "Paket Bakteri";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormInventoryBakteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(buttonAddBakteri);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditItem);
            Controls.Add(buttonSearch);
            Controls.Add(dgvInventoryBakteri);
            Controls.Add(textBox1);
            Name = "FormInventoryBakteri";
            Text = "FormInventoryBakteri";
            ((System.ComponentModel.ISupportInitialize)dgvInventoryBakteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button buttonAddBakteri;
        private Button buttonInvoice;
        private Button buttonEditItem;
        private Button buttonSearch;
        private DataGridView dgvInventoryBakteri;
        private TextBox textBox1;
        private Button button1;
    }
}