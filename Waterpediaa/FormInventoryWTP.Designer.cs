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
            ((System.ComponentModel.ISupportInitialize)dataGridViewWTP).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(728, 427);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 29);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // buttonNewfilter
            // 
            buttonNewfilter.Location = new Point(728, 159);
            buttonNewfilter.Name = "buttonNewfilter";
            buttonNewfilter.Size = new Size(143, 29);
            buttonNewfilter.TabIndex = 34;
            buttonNewfilter.Text = "Filter Baru";
            buttonNewfilter.UseVisualStyleBackColor = true;
            buttonNewfilter.Click += buttonNewfilter_Click;
            // 
            // buttonInvoice
            // 
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.ForeColor = SystemColors.ControlText;
            buttonInvoice.Location = new Point(728, 392);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(143, 29);
            buttonInvoice.TabIndex = 30;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            // 
            // buttonEditWTP
            // 
            buttonEditWTP.Location = new Point(728, 124);
            buttonEditWTP.Name = "buttonEditWTP";
            buttonEditWTP.Size = new Size(143, 29);
            buttonEditWTP.TabIndex = 29;
            buttonEditWTP.Text = "Edit Item";
            buttonEditWTP.UseVisualStyleBackColor = true;
            buttonEditWTP.Click += buttonEditWTP_Click;
            // 
            // dataGridViewWTP
            // 
            dataGridViewWTP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWTP.Location = new Point(12, 12);
            dataGridViewWTP.Name = "dataGridViewWTP";
            dataGridViewWTP.RowHeadersWidth = 51;
            dataGridViewWTP.RowTemplate.Height = 29;
            dataGridViewWTP.Size = new Size(700, 444);
            dataGridViewWTP.TabIndex = 27;
            // 
            // FormInventoryWTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 481);
            Controls.Add(btnBack);
            Controls.Add(buttonNewfilter);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditWTP);
            Controls.Add(dataGridViewWTP);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}