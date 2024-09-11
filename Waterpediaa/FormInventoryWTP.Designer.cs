namespace Waterpediaa
{
    partial class FormInventoryWTP
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
            buttonNewfilter = new Button();
            buttonInvoice = new Button();
            buttonEditWTP = new Button();
            dataGridViewWTP = new DataGridView();
            buttonPackaging = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWTP).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1137, 440);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 37);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // buttonNewfilter
            // 
            buttonNewfilter.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewfilter.Location = new Point(1137, 239);
            buttonNewfilter.Margin = new Padding(3, 2, 3, 2);
            buttonNewfilter.Name = "buttonNewfilter";
            buttonNewfilter.Size = new Size(125, 37);
            buttonNewfilter.TabIndex = 34;
            buttonNewfilter.Text = "Filter Baru";
            buttonNewfilter.UseVisualStyleBackColor = true;
            buttonNewfilter.Click += buttonNewfilter_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInvoice.ForeColor = SystemColors.ControlText;
            buttonInvoice.Location = new Point(1137, 321);
            buttonInvoice.Margin = new Padding(3, 2, 3, 2);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(125, 37);
            buttonInvoice.TabIndex = 30;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            buttonInvoice.Click += buttonInvoice_Click;
            // 
            // buttonEditWTP
            // 
            buttonEditWTP.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditWTP.Location = new Point(1137, 198);
            buttonEditWTP.Margin = new Padding(3, 2, 3, 2);
            buttonEditWTP.Name = "buttonEditWTP";
            buttonEditWTP.Size = new Size(125, 37);
            buttonEditWTP.TabIndex = 29;
            buttonEditWTP.Text = "Edit Item";
            buttonEditWTP.UseVisualStyleBackColor = true;
            buttonEditWTP.Click += buttonEditWTP_Click;
            // 
            // dataGridViewWTP
            // 
            dataGridViewWTP.BackgroundColor = SystemColors.ScrollBar;
            dataGridViewWTP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWTP.GridColor = SystemColors.ScrollBar;
            dataGridViewWTP.Location = new Point(12, 11);
            dataGridViewWTP.Margin = new Padding(3, 2, 3, 2);
            dataGridViewWTP.Name = "dataGridViewWTP";
            dataGridViewWTP.RowHeadersWidth = 51;
            dataGridViewWTP.RowTemplate.Height = 29;
            dataGridViewWTP.Size = new Size(1086, 639);
            dataGridViewWTP.TabIndex = 27;
            // 
            // buttonPackaging
            // 
            buttonPackaging.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPackaging.Location = new Point(1137, 280);
            buttonPackaging.Margin = new Padding(3, 2, 3, 2);
            buttonPackaging.Name = "buttonPackaging";
            buttonPackaging.Size = new Size(125, 37);
            buttonPackaging.TabIndex = 36;
            buttonPackaging.Text = "Packaging";
            buttonPackaging.UseVisualStyleBackColor = true;
            buttonPackaging.Click += buttonPackaging_Click;
            // 
            // FormInventoryWTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 661);
            Controls.Add(buttonPackaging);
            Controls.Add(btnBack);
            Controls.Add(buttonNewfilter);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditWTP);
            Controls.Add(dataGridViewWTP);
            Name = "FormInventoryWTP";
            Text = "FormInventoryWTP";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWTP).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack;
        private Button buttonNewfilter;
        private Button buttonInvoice;
        private Button buttonEditWTP;
        private DataGridView dataGridViewWTP;
        private Button buttonPackaging;
    }
}