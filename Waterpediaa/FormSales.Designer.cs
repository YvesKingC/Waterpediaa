namespace Waterpediaa
{
    partial class FormSales
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
            buttonApply = new Button();
            dataGridViewSales = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            buttonReset = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // buttonApply
            // 
            buttonApply.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonApply.Location = new Point(922, 204);
            buttonApply.Margin = new Padding(3, 2, 3, 2);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(131, 33);
            buttonApply.TabIndex = 1;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(12, 11);
            dataGridViewSales.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 51;
            dataGridViewSales.RowTemplate.Height = 29;
            dataGridViewSales.Size = new Size(886, 771);
            dataGridViewSales.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(922, 102);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 32);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(922, 168);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(312, 32);
            dateTimePicker2.TabIndex = 4;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(1103, 204);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(131, 33);
            buttonReset.TabIndex = 5;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(922, 68);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 6;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(922, 136);
            label2.Name = "label2";
            label2.Size = new Size(36, 30);
            label2.TabIndex = 7;
            label2.Text = "To";
            // 
            // FormSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 793);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonReset);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridViewSales);
            Controls.Add(buttonApply);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSales";
            Text = "FormSales";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonApply;
        private DataGridView dataGridViewSales;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button buttonReset;
        private Label label1;
        private Label label2;
    }
}