namespace Waterpediaa
{
    partial class FormProcureBakteri
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            this.domainUpDownVolume = new DomainUpDown();
            this.cBoxNamaBakteri = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            btnInput = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            dataGridView2 = new DataGridView();
            btnProcure = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(477, 164);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnInput);
            panel1.Controls.Add(this.domainUpDownVolume);
            panel1.Controls.Add(this.cBoxNamaBakteri);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 205);
            panel1.TabIndex = 23;
            // 
            // domainUpDownVolume
            // 
            this.domainUpDownVolume.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.domainUpDownVolume.Location = new Point(88, 96);
            this.domainUpDownVolume.Name = "domainUpDownVolume";
            this.domainUpDownVolume.Size = new Size(179, 25);
            this.domainUpDownVolume.TabIndex = 23;
            // 
            // cBoxNamaBakteri
            // 
            this.cBoxNamaBakteri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.cBoxNamaBakteri.FormattingEnabled = true;
            this.cBoxNamaBakteri.Location = new Point(88, 65);
            this.cBoxNamaBakteri.Name = "cBoxNamaBakteri";
            this.cBoxNamaBakteri.Size = new Size(179, 25);
            this.cBoxNamaBakteri.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 96);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 18;
            label4.Text = "Volume :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 68);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 15;
            label7.Text = "Nama :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(label8);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(284, 29);
            panel3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(11, 4);
            label8.Name = "label8";
            label8.Size = new Size(148, 19);
            label8.TabIndex = 13;
            label8.Text = "Procurement Bakteri";
            // 
            // btnInput
            // 
            btnInput.BackColor = Color.FromArgb(192, 255, 192);
            btnInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnInput.Location = new Point(148, 148);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(119, 38);
            btnInput.TabIndex = 27;
            btnInput.Text = "Input";
            btnInput.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 30;
            label1.Text = "Tanggal :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 23);
            dateTimePicker1.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(303, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(485, 204);
            panel2.TabIndex = 32;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(484, 29);
            panel4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(11, 4);
            label6.Name = "label6";
            label6.Size = new Size(122, 19);
            label6.TabIndex = 13;
            label6.Text = "Procurement List";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView2);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(303, 222);
            panel5.Name = "panel5";
            panel5.Size = new Size(485, 217);
            panel5.TabIndex = 33;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkBlue;
            panel6.Controls.Add(label9);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(484, 29);
            panel6.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(11, 4);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 13;
            label9.Text = "Mutasi Bakteri";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(477, 177);
            dataGridView2.TabIndex = 15;
            // 
            // btnProcure
            // 
            btnProcure.BackColor = Color.FromArgb(192, 255, 192);
            btnProcure.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnProcure.Location = new Point(161, 401);
            btnProcure.Name = "btnProcure";
            btnProcure.Size = new Size(119, 38);
            btnProcure.TabIndex = 32;
            btnProcure.Text = "Procure";
            btnProcure.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(12, 401);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(119, 38);
            btnBack.TabIndex = 34;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // FormProcureBakteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnProcure);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormProcureBakteri";
            Text = "FormProcureBakteri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox tBoxHarga;
        private DomainUpDown domainUpDownQuantity;
        private ComboBox cBoxNamaProduk;
        private Label label10;
        private Label label4;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Button btnInput;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Label label6;
        private Panel panel5;
        private Panel panel6;
        private Label label9;
        private DataGridView dataGridView2;
        private Button btnProcure;
        private Button btnBack;
    }
}