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
            labelFilter = new Label();
            btnBack = new Button();
            buttonNewfilter = new Button();
            comboBox1 = new ComboBox();
            buttonInvoice = new Button();
            buttonEditWTP = new Button();
            buttonApplyWTP = new Button();
            dataGridView1 = new DataGridView();
            buttonSearchWTP = new Button();
            textBoxWTP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelFilter
            // 
            labelFilter.Anchor = AnchorStyles.None;
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(629, 70);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(42, 15);
            labelFilter.TabIndex = 36;
            labelFilter.Text = "Filter : ";
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
            buttonNewfilter.Location = new Point(637, 184);
            buttonNewfilter.Margin = new Padding(3, 2, 3, 2);
            buttonNewfilter.Name = "buttonNewfilter";
            buttonNewfilter.Size = new Size(125, 22);
            buttonNewfilter.TabIndex = 34;
            buttonNewfilter.Text = "Filter Baru";
            buttonNewfilter.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(629, 88);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 31;
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
            buttonEditWTP.Location = new Point(637, 158);
            buttonEditWTP.Margin = new Padding(3, 2, 3, 2);
            buttonEditWTP.Name = "buttonEditWTP";
            buttonEditWTP.Size = new Size(125, 22);
            buttonEditWTP.TabIndex = 29;
            buttonEditWTP.Text = "Edit Item";
            buttonEditWTP.UseVisualStyleBackColor = true;
            // 
            // buttonApplyWTP
            // 
            buttonApplyWTP.Location = new Point(654, 113);
            buttonApplyWTP.Margin = new Padding(3, 2, 3, 2);
            buttonApplyWTP.Name = "buttonApplyWTP";
            buttonApplyWTP.Size = new Size(82, 22);
            buttonApplyWTP.TabIndex = 28;
            buttonApplyWTP.Text = "Apply";
            buttonApplyWTP.UseVisualStyleBackColor = true;
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
            buttonSearchWTP.Location = new Point(630, 19);
            buttonSearchWTP.Margin = new Padding(3, 2, 3, 2);
            buttonSearchWTP.Name = "buttonSearchWTP";
            buttonSearchWTP.Size = new Size(132, 22);
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
            Controls.Add(labelFilter);
            Controls.Add(btnBack);
            Controls.Add(buttonNewfilter);
            Controls.Add(comboBox1);
            Controls.Add(buttonInvoice);
            Controls.Add(buttonEditWTP);
            Controls.Add(buttonApplyWTP);
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

        private Label labelFilter;
        private Button btnBack;
        private Button buttonNewfilter;
        private ComboBox comboBox1;
        private Button buttonInvoice;
        private Button buttonEditWTP;
        private Button buttonApplyWTP;
        private DataGridView dataGridView1;
        private Button buttonSearchWTP;
        private TextBox textBoxWTP;
    }
}