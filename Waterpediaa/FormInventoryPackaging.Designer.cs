﻿namespace Waterpediaa
{
    partial class FormInventoryPackaging
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            buttonEditInventory = new Button();
            buttonItemPack = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(669, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(676, 3);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(669, 402);
            dataGridView1.TabIndex = 2;
            // 
            // buttonEditInventory
            // 
            buttonEditInventory.Location = new Point(676, 159);
            buttonEditInventory.Name = "buttonEditInventory";
            buttonEditInventory.Size = new Size(151, 29);
            buttonEditInventory.TabIndex = 6;
            buttonEditInventory.Text = "Edit Item";
            buttonEditInventory.UseVisualStyleBackColor = true;
            // 
            // buttonItemPack
            // 
            buttonItemPack.Location = new Point(676, 194);
            buttonItemPack.Name = "buttonItemPack";
            buttonItemPack.Size = new Size(151, 29);
            buttonItemPack.TabIndex = 7;
            buttonItemPack.Text = "Item Baru";
            buttonItemPack.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.Salmon;
            button7.Location = new Point(676, 409);
            button7.Name = "button7";
            button7.Size = new Size(151, 29);
            button7.TabIndex = 10;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(128, 255, 128);
            button8.Location = new Point(676, 229);
            button8.Name = "button8";
            button8.Size = new Size(151, 29);
            button8.TabIndex = 11;
            button8.Text = "Item Keluar";
            button8.UseVisualStyleBackColor = false;
            // 
            // FormInventoryPackaging
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(buttonItemPack);
            Controls.Add(buttonEditInventory);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "FormInventoryPackaging";
            Text = "FormInventoryPackaging";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button buttonEditInventory;
        private Button buttonItemPack;
        private Button button7;
        private Button button8;
    }
}