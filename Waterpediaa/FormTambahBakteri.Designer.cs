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
            dgvTambahBakteriBaru = new DataGridView();
            btnBack = new Button();
            buttonAdd = new Button();
            label1 = new Label();
            labelHarga = new Label();
            labelJumlah = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelBakteri = new Label();
            comboBox1 = new ComboBox();
            labelSelectPackaging = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTambahBakteriBaru).BeginInit();
            SuspendLayout();
            // 
            // dgvTambahBakteriBaru
            // 
            dgvTambahBakteriBaru.Anchor = AnchorStyles.None;
            dgvTambahBakteriBaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTambahBakteriBaru.Location = new Point(292, 63);
            dgvTambahBakteriBaru.Name = "dgvTambahBakteriBaru";
            dgvTambahBakteriBaru.RowTemplate.Height = 25;
            dgvTambahBakteriBaru.Size = new Size(470, 283);
            dgvTambahBakteriBaru.TabIndex = 36;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(24, 324);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 22);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.Location = new Point(129, 232);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(104, 22);
            buttonAdd.TabIndex = 34;
            buttonAdd.Text = "Add Bakteri";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 14);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 33;
            label1.Text = "TAMBAH BAKTERI BARU";
            // 
            // labelHarga
            // 
            labelHarga.Anchor = AnchorStyles.None;
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(24, 177);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(48, 15);
            labelHarga.TabIndex = 32;
            labelHarga.Text = "Harga : ";
            // 
            // labelJumlah
            // 
            labelJumlah.Anchor = AnchorStyles.None;
            labelJumlah.AutoSize = true;
            labelJumlah.Location = new Point(24, 132);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(54, 15);
            labelJumlah.TabIndex = 31;
            labelJumlah.Text = "Jumlah : ";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(24, 194);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 30;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(24, 149);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(24, 105);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 28;
            // 
            // labelBakteri
            // 
            labelBakteri.Anchor = AnchorStyles.None;
            labelBakteri.AutoSize = true;
            labelBakteri.Location = new Point(24, 88);
            labelBakteri.Name = "labelBakteri";
            labelBakteri.Size = new Size(80, 15);
            labelBakteri.TabIndex = 27;
            labelBakteri.Text = "Jenis Bakteri : ";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 63);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 26;
            // 
            // labelSelectPackaging
            // 
            labelSelectPackaging.Anchor = AnchorStyles.None;
            labelSelectPackaging.AutoSize = true;
            labelSelectPackaging.Location = new Point(24, 45);
            labelSelectPackaging.Name = "labelSelectPackaging";
            labelSelectPackaging.Size = new Size(71, 15);
            labelSelectPackaging.TabIndex = 25;
            labelSelectPackaging.Text = "Packaging : ";
            // 
            // FormTambahBakteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 361);
            Controls.Add(dgvTambahBakteriBaru);
            Controls.Add(btnBack);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(labelHarga);
            Controls.Add(labelJumlah);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelBakteri);
            Controls.Add(comboBox1);
            Controls.Add(labelSelectPackaging);
            Name = "FormTambahBakteri";
            Text = "FormTambahBakteri";
            ((System.ComponentModel.ISupportInitialize)dgvTambahBakteriBaru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTambahBakteriBaru;
        private Button btnBack;
        private Button buttonAdd;
        private Label label1;
        private Label labelHarga;
        private Label labelJumlah;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label labelBakteri;
        private ComboBox comboBox1;
        private Label labelSelectPackaging;
    }
}