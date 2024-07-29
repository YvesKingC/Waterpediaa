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
            dataGridView1 = new DataGridView();
            buttonSearchWTP = new Button();
            textBoxWTP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(637, 320);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 22);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // buttonNewfilter
            // 
            buttonNewfilter.Location = new Point(637, 119);
            buttonNewfilter.Margin = new Padding(3, 2, 3, 2);
            buttonNewfilter.Name = "buttonNewfilter";
            buttonNewfilter.Size = new Size(125, 22);
            buttonNewfilter.TabIndex = 34;
            buttonNewfilter.Text = "Filter Baru";
            buttonNewfilter.UseVisualStyleBackColor = true;
            // 
            // buttonInvoice
            // 
            buttonInvoice.BackColor = Color.FromArgb(128, 255, 128);
            buttonInvoice.ForeColor = SystemColors.ControlText;
            buttonInvoice.Location = new Point(637, 294);
            buttonInvoice.Margin = new Padding(3, 2, 3, 2);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(125, 22);
            buttonInvoice.TabIndex = 30;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = false;
            // 
            // buttonEditWTP
            // 
            buttonEditWTP.Location = new Point(637, 93);
            buttonEditWTP.Margin = new Padding(3, 2, 3, 2);
            buttonEditWTP.Name = "buttonEditWTP";
            buttonEditWTP.Size = new Size(125, 22);
            buttonEditWTP.TabIndex = 29;
            buttonEditWTP.Text = "Edit Item";
            buttonEditWTP.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 47);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(584, 295);
            dataGridView1.TabIndex = 27;
            // 
            // buttonSearchWTP
            // 
            buttonSearchWTP.Location = new Point(637, 21);
            buttonSearchWTP.Margin = new Padding(3, 2, 3, 2);
            buttonSearchWTP.Name = "buttonSearchWTP";
            buttonSearchWTP.Size = new Size(125, 22);
            buttonSearchWTP.TabIndex = 26;
            buttonSearchWTP.Text = "Search";
            buttonSearchWTP.UseVisualStyleBackColor = true;
            // 
            // textBoxWTP
            // 
            textBoxWTP.Location = new Point(39, 20);
            textBoxWTP.Margin = new Padding(3, 2, 3, 2);
            textBoxWTP.Name = "textBoxWTP";
            textBoxWTP.Size = new Size(585, 23);
            textBoxWTP.TabIndex = 25;
            // 
            // FormInventoryWTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 361);
            Controls.Add(btnBack);
            Controls.Add(buttonNewfilter);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditWTP);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearchWTP);
            Controls.Add(textBoxWTP);
            Name = "FormInventoryWTP";
            Text = "FormInventoryWTP";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBack;
        private Button buttonNewfilter;
        private Button buttonInvoice;
        private Button buttonEditWTP;
        private DataGridView dataGridView1;
        private Button buttonSearchWTP;
        private TextBox textBoxWTP;
    }
}