﻿namespace Waterpediaa
{
    partial class FormEditWTP
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
            btnSave = new Button();
            numericUpDownHarga = new NumericUpDown();
            numericUpDownStok = new NumericUpDown();
            label3 = new Label();
            textBoxNamaFilter = new TextBox();
            label4 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStok).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(numericUpDownHarga);
            panel1.Controls.Add(numericUpDownStok);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxNamaFilter);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 242);
            panel1.TabIndex = 39;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Location = new Point(211, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 29);
            btnSave.TabIndex = 40;
            btnSave.Text = "Input";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // numericUpDownHarga
            // 
            numericUpDownHarga.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownHarga.Location = new Point(107, 124);
            numericUpDownHarga.Margin = new Padding(3, 4, 3, 4);
            numericUpDownHarga.Name = "numericUpDownHarga";
            numericUpDownHarga.Size = new Size(198, 30);
            numericUpDownHarga.TabIndex = 39;
            numericUpDownHarga.Maximum = 1000000;
            // 
            // numericUpDownStok
            // 
            numericUpDownStok.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownStok.Location = new Point(107, 82);
            numericUpDownStok.Margin = new Padding(3, 4, 3, 4);
            numericUpDownStok.Name = "numericUpDownStok";
            numericUpDownStok.Size = new Size(198, 30);
            numericUpDownStok.TabIndex = 37;
            numericUpDownStok.Maximum = 1000000;
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
            // textBoxNamaFilter
            // 
            textBoxNamaFilter.BorderStyle = BorderStyle.FixedSingle;
            textBoxNamaFilter.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNamaFilter.Location = new Point(107, 41);
            textBoxNamaFilter.Margin = new Padding(3, 4, 3, 4);
            textBoxNamaFilter.Name = "textBoxNamaFilter";
            textBoxNamaFilter.Size = new Size(197, 30);
            textBoxNamaFilter.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 124);
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
            panel2.Size = new Size(798, 39);
            panel2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(13, 5);
            label6.Name = "label6";
            label6.Size = new Size(89, 23);
            label6.TabIndex = 13;
            label6.Text = "Edit Filter";
            // 
            // FormEditWTP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 245);
            Controls.Add(panel1);
            Name = "FormEditWTP";
            Text = "FormEditWTP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHarga).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStok).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private NumericUpDown numericUpDownHarga;
        private NumericUpDown numericUpDownStok;
        private Label label3;
        private TextBox textBoxNamaFilter;
        private Label label4;
        private Label label7;
        private Panel panel2;
        private Label label6;
    }
}