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
            dgvInventoryBakteri = new DataGridView();
            buttonPackaging = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventoryBakteri).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1146, 477);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 34);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // buttonAddPackaging
            // 
            buttonAddPackaging.Anchor = AnchorStyles.None;
            buttonAddPackaging.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddPackaging.Location = new Point(1146, 329);
            buttonAddPackaging.Margin = new Padding(3, 2, 3, 2);
            buttonAddPackaging.Name = "buttonAddPackaging";
            buttonAddPackaging.Size = new Size(125, 32);
            buttonAddPackaging.TabIndex = 32;
            buttonAddPackaging.Text = "Paket Bakteri";
            buttonAddPackaging.UseVisualStyleBackColor = true;
            buttonAddPackaging.Click += buttonAddPackaging_Click;
            // 
            // buttonAddBakteri
            // 
            buttonAddBakteri.Anchor = AnchorStyles.None;
            buttonAddBakteri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddBakteri.Location = new Point(1146, 292);
            buttonAddBakteri.Margin = new Padding(3, 2, 3, 2);
            buttonAddBakteri.Name = "buttonAddBakteri";
            buttonAddBakteri.Size = new Size(125, 33);
            buttonAddBakteri.TabIndex = 31;
            buttonAddBakteri.Text = "Bakteri Baru";
            buttonAddBakteri.UseVisualStyleBackColor = true;
            buttonAddBakteri.Click += buttonAddBakteri_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.Anchor = AnchorStyles.None;
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInvoice.Location = new Point(1146, 365);
            buttonInvoice.Margin = new Padding(3, 2, 3, 2);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(125, 33);
            buttonInvoice.TabIndex = 30;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            buttonInvoice.Click += buttonInvoice_Click;
            // 
            // buttonEditItem
            // 
            buttonEditItem.Anchor = AnchorStyles.None;
            buttonEditItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditItem.Location = new Point(1146, 255);
            buttonEditItem.Margin = new Padding(3, 2, 3, 2);
            buttonEditItem.Name = "buttonEditItem";
            buttonEditItem.Size = new Size(125, 33);
            buttonEditItem.TabIndex = 28;
            buttonEditItem.Text = "Edit Item";
            buttonEditItem.UseVisualStyleBackColor = true;
            buttonEditItem.Click += buttonEditItem_Click;
            // 
            // dgvInventoryBakteri
            // 
            dgvInventoryBakteri.AllowUserToAddRows = false;
            dgvInventoryBakteri.AllowUserToDeleteRows = false;
            dgvInventoryBakteri.Anchor = AnchorStyles.None;
            dgvInventoryBakteri.BackgroundColor = SystemColors.ScrollBar;
            dgvInventoryBakteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventoryBakteri.Location = new Point(12, 11);
            dgvInventoryBakteri.Margin = new Padding(3, 2, 3, 2);
            dgvInventoryBakteri.Name = "dgvInventoryBakteri";
            dgvInventoryBakteri.ReadOnly = true;
            dgvInventoryBakteri.RowHeadersWidth = 51;
            dgvInventoryBakteri.RowTemplate.Height = 29;
            dgvInventoryBakteri.Size = new Size(1108, 639);
            dgvInventoryBakteri.TabIndex = 24;
            // 
            // buttonPackaging
            // 
            buttonPackaging.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPackaging.Location = new Point(1146, 217);
            buttonPackaging.Margin = new Padding(3, 2, 3, 2);
            buttonPackaging.Name = "buttonPackaging";
            buttonPackaging.Size = new Size(125, 34);
            buttonPackaging.TabIndex = 35;
            buttonPackaging.Text = "Packaging";
            buttonPackaging.UseVisualStyleBackColor = true;
            buttonPackaging.Click += buttonPackaging_Click;
            // 
            // FormInventoryBakteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 661);
            Controls.Add(buttonPackaging);
            Controls.Add(btnBack);
            Controls.Add(buttonAddPackaging);
            Controls.Add(buttonAddBakteri);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditItem);
            Controls.Add(dgvInventoryBakteri);
            Name = "FormInventoryBakteri";
            Text = "FormInventoryBakteri";
            ((System.ComponentModel.ISupportInitialize)dgvInventoryBakteri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button buttonAddPackaging;
        private Button buttonAddBakteri;
        private Button buttonInvoice;
        private Button buttonEditItem;
        private DataGridView dgvInventoryBakteri;
        private Button buttonPackaging;
    }
}