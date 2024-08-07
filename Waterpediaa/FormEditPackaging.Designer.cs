namespace Waterpediaa
{
    partial class FormEditPackaging
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
            btnInput = new Button();
            nudHargaPerBarang = new NumericUpDown();
            nudJumlah = new NumericUpDown();
            label3 = new Label();
            textBoxNamaBarang = new TextBox();
            label4 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHargaPerBarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnInput);
            panel1.Controls.Add(nudHargaPerBarang);
            panel1.Controls.Add(nudJumlah);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNamaBarang);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 245);
            panel1.TabIndex = 41;
            // 
            // btnInput
            // 
            btnInput.Anchor = AnchorStyles.None;
            btnInput.BackColor = Color.FromArgb(192, 255, 192);
            btnInput.Location = new Point(162, 161);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(143, 29);
            btnInput.TabIndex = 40;
            btnInput.Text = "Input";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // nudHargaPerBarang
            // 
            nudHargaPerBarang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudHargaPerBarang.Location = new Point(107, 124);
            nudHargaPerBarang.Margin = new Padding(3, 4, 3, 4);
            nudHargaPerBarang.Name = "nudHargaPerBarang";
            nudHargaPerBarang.Size = new Size(198, 30);
            nudHargaPerBarang.TabIndex = 39;
            nudHargaPerBarang.Maximum = 1000000;
            // 
            // nudJumlah
            // 
            nudJumlah.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nudJumlah.Location = new Point(107, 82);
            nudJumlah.Margin = new Padding(3, 4, 3, 4);
            nudJumlah.Name = "nudJumlah";
            nudJumlah.Size = new Size(198, 30);
            nudJumlah.TabIndex = 37;
            nudJumlah.Maximum = 1000000;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 85);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 34;
            label3.Text = "Stock Awal :";
            // 
            // textBoxNamaBarang
            // 
            textBoxNamaBarang.BorderStyle = BorderStyle.FixedSingle;
            textBoxNamaBarang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNamaBarang.Location = new Point(139, 41);
            textBoxNamaBarang.Margin = new Padding(3, 4, 3, 4);
            textBoxNamaBarang.Name = "textBoxNamaBarang";
            textBoxNamaBarang.Size = new Size(165, 30);
            textBoxNamaBarang.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 126);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 18;
            label4.Text = "Harga :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 43);
            label7.Name = "label7";
            label7.Size = new Size(139, 23);
            label7.TabIndex = 15;
            label7.Text = "Nama Pakaging :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Controls.Add(label6);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 39);
            panel2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(13, 5);
            label6.Name = "label6";
            label6.Size = new Size(105, 23);
            label6.TabIndex = 13;
            label6.Text = "Edit Bakteri";
            // 
            // FormEditPackaging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 246);
            Controls.Add(panel1);
            Name = "FormEditPackaging";
            Text = "FormEditPackaging";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHargaPerBarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudJumlah).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInput;
        private NumericUpDown nudHargaPerBarang;
        private NumericUpDown nudJumlah;
        private Label label3;
        private TextBox textBoxNamaBarang;
        private Label label4;
        private Label label7;
        private Panel panel2;
        private Label label6;
    }
}