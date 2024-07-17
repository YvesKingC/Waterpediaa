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
            buttonApplyFilter = new Button();
            buttonEditItem = new Button();
            buttonSearch = new Button();
            labelFilter = new Label();
            comboBox1 = new ComboBox();
            dgvInventoryBakteri = new DataGridView();
            textBox1 = new TextBox();
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
            buttonAddBakteri.Location = new Point(634, 184);
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
            // buttonApplyFilter
            // 
            buttonApplyFilter.Anchor = AnchorStyles.None;
            buttonApplyFilter.Location = new Point(651, 113);
            buttonApplyFilter.Margin = new Padding(3, 2, 3, 2);
            buttonApplyFilter.Name = "buttonApplyFilter";
            buttonApplyFilter.Size = new Size(82, 22);
            buttonApplyFilter.TabIndex = 29;
            buttonApplyFilter.Text = "Apply";
            buttonApplyFilter.UseVisualStyleBackColor = true;
            // 
            // buttonEditItem
            // 
            buttonEditItem.Anchor = AnchorStyles.None;
            buttonEditItem.Location = new Point(634, 158);
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
            // labelFilter
            // 
            labelFilter.Anchor = AnchorStyles.None;
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(626, 70);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(42, 15);
            labelFilter.TabIndex = 26;
            labelFilter.Text = "Filter : ";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(626, 88);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 25;
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
            // FormInventoryBakteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(btnBack);
            Controls.Add(buttonAddBakteri);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonApplyFilter);
            Controls.Add(buttonEditItem);
            Controls.Add(buttonSearch);
            Controls.Add(labelFilter);
            Controls.Add(comboBox1);
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
        private Button buttonApplyFilter;
        private Button buttonEditItem;
        private Button buttonSearch;
        private Label labelFilter;
        private ComboBox comboBox1;
        private DataGridView dgvInventoryBakteri;
        private TextBox textBox1;
    }
}