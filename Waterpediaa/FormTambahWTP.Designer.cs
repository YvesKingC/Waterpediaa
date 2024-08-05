namespace Waterpediaa
{
    partial class FormTambahWTP
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
            panel1 = new Panel();
            nudBerat = new NumericUpDown();
            labelBerat = new Label();
            btnInput = new Button();
            nudHarga = new NumericUpDown();
            nudStok = new NumericUpDown();
            label3 = new Label();
            textBoxNama = new TextBox();
            label4 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            dataGridViewStock = new DataGridView();
            panel4 = new Panel();
            label8 = new Label();
            dataGridView2 = new DataGridView();
            panel6 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            label13 = new Label();
            dataGridViewMutasi = new DataGridView();
            btnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBerat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMutasi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(nudBerat);
            panel1.Controls.Add(labelBerat);
            panel1.Controls.Add(btnInput);
            panel1.Controls.Add(nudHarga);
            panel1.Controls.Add(nudStok);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNama);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 254);
            panel1.TabIndex = 38;
            // 
            // nudBerat
            // 
            nudBerat.Location = new Point(121, 88);
            nudBerat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBerat.Name = "nudBerat";
            nudBerat.Size = new Size(198, 27);
            nudBerat.TabIndex = 43;
            // 
            // labelBerat
            // 
            labelBerat.AutoSize = true;
            labelBerat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelBerat.Location = new Point(59, 88);
            labelBerat.Name = "labelBerat";
            labelBerat.Size = new Size(59, 23);
            labelBerat.TabIndex = 42;
            labelBerat.Text = "Berat :";
            // 
            // btnInput
            // 
            btnInput.Anchor = AnchorStyles.None;
            btnInput.BackColor = Color.FromArgb(192, 255, 192);
            btnInput.Location = new Point(176, 208);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(143, 29);
            btnInput.TabIndex = 40;
            btnInput.Text = "Input";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // nudHarga
            // 
            nudHarga.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudHarga.Location = new Point(121, 171);
            nudHarga.Margin = new Padding(3, 4, 3, 4);
            nudHarga.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudHarga.Name = "nudHarga";
            nudHarga.Size = new Size(198, 30);
            nudHarga.TabIndex = 39;
            // 
            // nudStok
            // 
            nudStok.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudStok.Location = new Point(121, 129);
            nudStok.Margin = new Padding(3, 4, 3, 4);
            nudStok.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStok.Name = "nudStok";
            nudStok.Size = new Size(198, 30);
            nudStok.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 132);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 34;
            label3.Text = "Stock Awal :";
            // 
            // textBoxNama
            // 
            textBoxNama.BorderStyle = BorderStyle.FixedSingle;
            textBoxNama.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNama.Location = new Point(124, 47);
            textBoxNama.Margin = new Padding(3, 4, 3, 4);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(197, 30);
            textBoxNama.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 171);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 18;
            label4.Text = "Harga :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(11, 48);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 15;
            label7.Text = "Nama Filter :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 39);
            panel2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(13, 5);
            label6.Name = "label6";
            label6.Size = new Size(163, 23);
            label6.TabIndex = 13;
            label6.Text = "Tambah Filter Baru";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(dataGridView2);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(366, 2);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(521, 255);
            panel5.TabIndex = 39;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dataGridViewStock);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(-1, -1);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(521, 255);
            panel3.TabIndex = 40;
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Location = new Point(3, 47);
            dataGridViewStock.Margin = new Padding(3, 4, 3, 4);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.RowHeadersWidth = 51;
            dataGridViewStock.RowTemplate.Height = 25;
            dataGridViewStock.Size = new Size(517, 203);
            dataGridViewStock.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(label8);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(520, 39);
            panel4.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(13, 5);
            label8.Name = "label8";
            label8.Size = new Size(102, 23);
            label8.TabIndex = 13;
            label8.Text = "Stock Filter";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 47);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(512, 203);
            dataGridView2.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Controls.Add(label9);
            panel6.Location = new Point(0, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(520, 39);
            panel6.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(13, 5);
            label9.Name = "label9";
            label9.Size = new Size(118, 23);
            label9.TabIndex = 13;
            label9.Text = "Stock Bakteri";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(dataGridViewMutasi);
            panel7.Location = new Point(0, 274);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(900, 278);
            panel7.TabIndex = 41;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Controls.Add(label13);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(899, 39);
            panel8.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(224, 224, 224);
            label13.Location = new Point(13, 5);
            label13.Name = "label13";
            label13.Size = new Size(111, 23);
            label13.TabIndex = 13;
            label13.Text = "Mutasi Filter";
            // 
            // dataGridViewMutasi
            // 
            dataGridViewMutasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMutasi.Location = new Point(3, 47);
            dataGridViewMutasi.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMutasi.Name = "dataGridViewMutasi";
            dataGridViewMutasi.RowHeadersWidth = 51;
            dataGridViewMutasi.RowTemplate.Height = 25;
            dataGridViewMutasi.Size = new Size(892, 230);
            dataGridViewMutasi.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(12, 559);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 29);
            btnBack.TabIndex = 42;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormTambahWTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 595);
            Controls.Add(btnBack);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "FormTambahWTP";
            Text = "FormTambahWTP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBerat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMutasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInput;
        private NumericUpDown nudHarga;
        private NumericUpDown nudStok;
        private Label label3;
        private TextBox textBoxNama;
        private Label label4;
        private Label label7;
        private Panel panel2;
        private Label label6;
        private Panel panel5;
        private DataGridView dataGridView2;
        private Panel panel6;
        private Label label9;
        private Panel panel3;
        private DataGridView dataGridViewStock;
        private Panel panel4;
        private Label label8;
        private Panel panel7;
        private Panel panel8;
        private Label label13;
        private DataGridView dataGridViewMutasi;
        private Button btnBack;
        private NumericUpDown nudBerat;
        private Label labelBerat;
    }
}