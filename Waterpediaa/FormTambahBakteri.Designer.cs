namespace Waterpediaa
{
    partial class FormTambahBakteri
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
            panel5 = new Panel();
            dataGridViewStok = new DataGridView();
            panel6 = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            btnInputBakteriBaru = new Button();
            nudStokNewBakteri = new NumericUpDown();
            nudNewBakteri = new NumericUpDown();
            label3 = new Label();
            textBoxNewBakteri = new TextBox();
            label4 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            panel2 = new Panel();
            btnInputProcureBakteri = new Button();
            numericUpDown3 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            cBoxNamaBakteri = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            panel9 = new Panel();
            dataGridView3 = new DataGridView();
            panel10 = new Panel();
            label14 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStokNewBakteri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNewBakteri).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(14, 560);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 29);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridViewStok);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(354, 16);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(521, 255);
            panel5.TabIndex = 36;
            // 
            // dataGridViewStok
            // 
            dataGridViewStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStok.Location = new Point(3, 47);
            dataGridViewStok.Margin = new Padding(3, 4, 3, 4);
            dataGridViewStok.Name = "dataGridViewStok";
            dataGridViewStok.RowHeadersWidth = 51;
            dataGridViewStok.RowTemplate.Height = 25;
            dataGridViewStok.Size = new Size(512, 203);
            dataGridViewStok.TabIndex = 15;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnInputBakteriBaru);
            panel1.Controls.Add(nudStokNewBakteri);
            panel1.Controls.Add(nudNewBakteri);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNewBakteri);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 255);
            panel1.TabIndex = 37;
            // 
            // btnInputBakteriBaru
            // 
            btnInputBakteriBaru.Anchor = AnchorStyles.None;
            btnInputBakteriBaru.BackColor = Color.FromArgb(192, 255, 192);
            btnInputBakteriBaru.Location = new Point(176, 212);
            btnInputBakteriBaru.Name = "btnInputBakteriBaru";
            btnInputBakteriBaru.Size = new Size(143, 29);
            btnInputBakteriBaru.TabIndex = 40;
            btnInputBakteriBaru.Text = "Input";
            btnInputBakteriBaru.UseVisualStyleBackColor = false;
            btnInputBakteriBaru.Click += btnInputBakteriBaru_Click;
            // 
            // nudStokNewBakteri
            // 
            nudStokNewBakteri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudStokNewBakteri.Location = new Point(121, 176);
            nudStokNewBakteri.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudStokNewBakteri.Name = "nudStokNewBakteri";
            nudStokNewBakteri.Size = new Size(198, 30);
            nudStokNewBakteri.TabIndex = 39;
            // 
            // nudNewBakteri
            // 
            nudNewBakteri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudNewBakteri.Location = new Point(121, 140);
            nudNewBakteri.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudNewBakteri.Name = "nudNewBakteri";
            nudNewBakteri.Size = new Size(198, 30);
            nudNewBakteri.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 178);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 34;
            label3.Text = "Stock Awal :";
            // 
            // textBoxNewBakteri
            // 
            textBoxNewBakteri.BorderStyle = BorderStyle.FixedSingle;
            textBoxNewBakteri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewBakteri.Location = new Point(119, 104);
            textBoxNewBakteri.Name = "textBoxNewBakteri";
            textBoxNewBakteri.Size = new Size(197, 30);
            textBoxNewBakteri.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 142);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 18;
            label4.Text = "Harga/Liter :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(-4, 106);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 15;
            label7.Text = "Nama Bakteri :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(label8);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(486, 39);
            panel3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(13, 5);
            label8.Name = "label8";
            label8.Size = new Size(179, 23);
            label8.TabIndex = 13;
            label8.Text = "Tambah Bakteri Baru";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnInputProcureBakteri);
            panel2.Controls.Add(numericUpDown3);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(cBoxNamaBakteri);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(14, 280);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 243);
            panel2.TabIndex = 38;
            // 
            // btnInputProcureBakteri
            // 
            btnInputProcureBakteri.Anchor = AnchorStyles.None;
            btnInputProcureBakteri.BackColor = Color.FromArgb(192, 255, 192);
            btnInputProcureBakteri.Location = new Point(238, 174);
            btnInputProcureBakteri.Name = "btnInputProcureBakteri";
            btnInputProcureBakteri.Size = new Size(81, 34);
            btnInputProcureBakteri.TabIndex = 41;
            btnInputProcureBakteri.Text = "Input";
            btnInputProcureBakteri.UseVisualStyleBackColor = false;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(121, 137);
            numericUpDown3.Margin = new Padding(3, 4, 3, 4);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(198, 30);
            numericUpDown3.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 57);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 27);
            dateTimePicker1.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 57);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 30;
            label6.Text = "Tanggal :";
            // 
            // cBoxNamaBakteri
            // 
            cBoxNamaBakteri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxNamaBakteri.FormattingEnabled = true;
            cBoxNamaBakteri.Location = new Point(121, 96);
            cBoxNamaBakteri.Margin = new Padding(3, 4, 3, 4);
            cBoxNamaBakteri.Name = "cBoxNamaBakteri";
            cBoxNamaBakteri.Size = new Size(197, 31);
            cBoxNamaBakteri.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(47, 140);
            label10.Name = "label10";
            label10.Size = new Size(77, 23);
            label10.TabIndex = 18;
            label10.Text = "Volume :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(58, 100);
            label11.Name = "label11";
            label11.Size = new Size(65, 23);
            label11.TabIndex = 15;
            label11.Text = "Nama :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(label12);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 39);
            panel4.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(13, 5);
            label12.Name = "label12";
            label12.Size = new Size(176, 23);
            label12.TabIndex = 13;
            label12.Text = "Procurement Bakteri";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(dataGridView1);
            panel7.Location = new Point(354, 280);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(521, 305);
            panel7.TabIndex = 40;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Controls.Add(label13);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(520, 39);
            panel8.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(224, 224, 224);
            label13.Location = new Point(13, 5);
            label13.Name = "label13";
            label13.Size = new Size(146, 23);
            label13.TabIndex = 13;
            label13.Text = "Procurement List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 47);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(512, 191);
            dataGridView1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Control;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(dataGridView3);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(882, 17);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(276, 567);
            panel9.TabIndex = 37;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 47);
            dataGridView3.Margin = new Padding(3, 4, 3, 4);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(267, 512);
            dataGridView3.TabIndex = 15;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DarkBlue;
            panel10.Controls.Add(label14);
            panel10.Location = new Point(0, 0);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(520, 39);
            panel10.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(13, 5);
            label14.Name = "label14";
            label14.Size = new Size(127, 23);
            label14.TabIndex = 13;
            label14.Text = "Mutasi Bakteri";
            // 
            // FormTambahBakteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1175, 604);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(btnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTambahBakteri";
            Text = "FormTambahBakteri";
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStok).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStokNewBakteri).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNewBakteri).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack;
        private Panel panel5;
        private DataGridView dataGridViewStok;
        private Panel panel6;
        private Label label9;
        private Panel panel1;
        private Label label4;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private TextBox textBoxNewBakteri;
        private NumericUpDown nudNewBakteri;
        private Label label3;
        private NumericUpDown nudStokNewBakteri;
        private Button btnInputBakteriBaru;
        private Panel panel2;
        private NumericUpDown numericUpDown3;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox cBoxNamaBakteri;
        private Label label10;
        private Label label11;
        private Panel panel4;
        private Label label12;
        private Panel panel7;
        private Panel panel8;
        private Label label13;
        private DataGridView dataGridView1;
        private Button btnInputProcureBakteri;
        private Panel panel9;
        private DataGridView dataGridView3;
        private Panel panel10;
        private Label label14;
    }
}