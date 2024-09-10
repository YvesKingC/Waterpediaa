namespace Waterpediaa
{
    partial class FormPaketBakteri
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
            panel5 = new Panel();
            dataGridViewPaket = new DataGridView();
            panel6 = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            buttonNewPaket = new Button();
            panel2 = new Panel();
            comboBoxPilihPaket = new ComboBox();
            label2 = new Label();
            comboBoxPackaging = new ComboBox();
            comboBoxBakteri = new ComboBox();
            buttonAdd = new Button();
            label1 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            buttonBuat = new Button();
            dataGridViewTemp = new DataGridView();
            textBoxNamaPaket = new TextBox();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            panel7 = new Panel();
            comboBoxDelete = new ComboBox();
            label3 = new Label();
            buttonDelete = new Button();
            panel8 = new Panel();
            label11 = new Label();
            btnBack = new Button();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaket).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTemp).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridViewPaket);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(264, 461);
            panel5.TabIndex = 37;
            // 
            // dataGridViewPaket
            // 
            dataGridViewPaket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPaket.Location = new Point(3, 35);
            dataGridViewPaket.Name = "dataGridViewPaket";
            dataGridViewPaket.RowHeadersWidth = 51;
            dataGridViewPaket.RowTemplate.Height = 25;
            dataGridViewPaket.Size = new Size(255, 421);
            dataGridViewPaket.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Controls.Add(label9);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(455, 29);
            panel6.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(11, 4);
            label9.Name = "label9";
            label9.Size = new Size(99, 19);
            label9.TabIndex = 13;
            label9.Text = "Paket Bakteri";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonNewPaket);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonBuat);
            panel1.Controls.Add(dataGridViewTemp);
            panel1.Controls.Add(textBoxNamaPaket);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(282, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 352);
            panel1.TabIndex = 38;
            // 
            // buttonNewPaket
            // 
            buttonNewPaket.BackColor = Color.FromArgb(192, 255, 192);
            buttonNewPaket.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNewPaket.Location = new Point(455, 314);
            buttonNewPaket.Name = "buttonNewPaket";
            buttonNewPaket.Size = new Size(113, 32);
            buttonNewPaket.TabIndex = 43;
            buttonNewPaket.Text = "Input Paket";
            buttonNewPaket.UseVisualStyleBackColor = false;
            buttonNewPaket.Click += buttonNewPaket_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboBoxPilihPaket);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxPackaging);
            panel2.Controls.Add(comboBoxBakteri);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(5, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 192);
            panel2.TabIndex = 42;
            // 
            // comboBoxPilihPaket
            // 
            comboBoxPilihPaket.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPilihPaket.FormattingEnabled = true;
            comboBoxPilihPaket.Location = new Point(100, 35);
            comboBoxPilihPaket.Name = "comboBoxPilihPaket";
            comboBoxPilihPaket.Size = new Size(173, 25);
            comboBoxPilihPaket.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 46;
            label2.Text = "Pilih Paket :";
            // 
            // comboBoxPackaging
            // 
            comboBoxPackaging.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPackaging.FormattingEnabled = true;
            comboBoxPackaging.Location = new Point(100, 97);
            comboBoxPackaging.Name = "comboBoxPackaging";
            comboBoxPackaging.Size = new Size(173, 25);
            comboBoxPackaging.TabIndex = 45;
            // 
            // comboBoxBakteri
            // 
            comboBoxBakteri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBakteri.FormattingEnabled = true;
            comboBoxBakteri.Location = new Point(100, 66);
            comboBoxBakteri.Name = "comboBoxBakteri";
            comboBoxBakteri.Size = new Size(173, 25);
            comboBoxBakteri.TabIndex = 44;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(158, 141);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(115, 32);
            buttonAdd.TabIndex = 43;
            buttonAdd.Text = "Tambah Bakteri";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 100);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 34;
            label1.Text = "Packaging :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 69);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 15;
            label5.Text = "Bakteri :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 29);
            panel4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(11, 4);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 13;
            label6.Text = "Isi Paket";
            // 
            // buttonBuat
            // 
            buttonBuat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuat.Location = new Point(193, 66);
            buttonBuat.Name = "buttonBuat";
            buttonBuat.Size = new Size(86, 32);
            buttonBuat.TabIndex = 41;
            buttonBuat.Text = "Buat Paket";
            buttonBuat.UseVisualStyleBackColor = true;
            buttonBuat.Click += buttonBuat_Click;
            // 
            // dataGridViewTemp
            // 
            dataGridViewTemp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTemp.Location = new Point(313, 35);
            dataGridViewTemp.Name = "dataGridViewTemp";
            dataGridViewTemp.RowHeadersWidth = 51;
            dataGridViewTemp.RowTemplate.Height = 25;
            dataGridViewTemp.Size = new Size(255, 273);
            dataGridViewTemp.TabIndex = 40;
            // 
            // textBoxNamaPaket
            // 
            textBoxNamaPaket.BorderStyle = BorderStyle.FixedSingle;
            textBoxNamaPaket.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNamaPaket.Location = new Point(106, 35);
            textBoxNamaPaket.Name = "textBoxNamaPaket";
            textBoxNamaPaket.Size = new Size(173, 25);
            textBoxNamaPaket.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 37);
            label7.Name = "label7";
            label7.Size = new Size(90, 19);
            label7.TabIndex = 15;
            label7.Text = "Nama Paket :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(label8);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(571, 29);
            panel3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(11, 4);
            label8.Name = "label8";
            label8.Size = new Size(139, 19);
            label8.TabIndex = 13;
            label8.Text = "Tambah Paket Baru";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btnBack);
            panel7.Controls.Add(comboBoxDelete);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(buttonDelete);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(282, 370);
            panel7.Name = "panel7";
            panel7.Size = new Size(573, 103);
            panel7.TabIndex = 48;
            // 
            // comboBoxDelete
            // 
            comboBoxDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDelete.FormattingEnabled = true;
            comboBoxDelete.Location = new Point(100, 35);
            comboBoxDelete.Name = "comboBoxDelete";
            comboBoxDelete.Size = new Size(468, 25);
            comboBoxDelete.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 38);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 46;
            label3.Text = "Pilih Paket :";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 192, 192);
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(453, 66);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(115, 32);
            buttonDelete.TabIndex = 43;
            buttonDelete.Text = "Hapus Paket";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkBlue;
            panel8.Controls.Add(label11);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(572, 29);
            panel8.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(11, 4);
            label11.Name = "label11";
            label11.Size = new Size(93, 19);
            label11.TabIndex = 13;
            label11.Text = "Hapus Paket";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(3, 71);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 27);
            btnBack.TabIndex = 49;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormPaketBakteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 488);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Name = "FormPaketBakteri";
            Text = "FormPaketBakteri";
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPaket).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTemp).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private DataGridView dataGridViewPaket;
        private Panel panel6;
        private Label label9;
        private Panel panel1;
        private TextBox textBoxNamaPaket;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private DataGridView dataGridViewTemp;
        private Button buttonBuat;
        private Panel panel2;
        private ComboBox comboBoxPackaging;
        private ComboBox comboBoxBakteri;
        private Button buttonAdd;
        private Label label1;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Button buttonNewPaket;
        private ComboBox comboBoxPilihPaket;
        private Label label2;
        private Panel panel7;
        private ComboBox comboBoxDelete;
        private Label label3;
        private Button buttonDelete;
        private Panel panel8;
        private Label label11;
        private Button btnBack;
    }
}