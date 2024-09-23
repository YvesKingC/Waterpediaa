namespace Waterpediaa
{
    partial class FormLihatQuotation
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
            dataGridViewQuotation = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            buttonReset = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            buttonApply = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuotation).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewQuotation
            // 
            dataGridViewQuotation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQuotation.Location = new Point(12, 12);
            dataGridViewQuotation.Name = "dataGridViewQuotation";
            dataGridViewQuotation.RowHeadersWidth = 51;
            dataGridViewQuotation.RowTemplate.Height = 29;
            dataGridViewQuotation.Size = new Size(950, 646);
            dataGridViewQuotation.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(968, 105);
            label2.Name = "label2";
            label2.Size = new Size(44, 37);
            label2.TabIndex = 13;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(968, 15);
            label1.Name = "label1";
            label1.Size = new Size(78, 37);
            label1.TabIndex = 12;
            label1.Text = "From";
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(1175, 196);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(150, 44);
            buttonReset.TabIndex = 11;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(968, 148);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(356, 39);
            dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(968, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 39);
            dateTimePicker1.TabIndex = 9;
            // 
            // buttonApply
            // 
            buttonApply.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonApply.Location = new Point(968, 196);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(150, 44);
            buttonApply.TabIndex = 8;
            buttonApply.Text = "Apply";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1189, 613);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(136, 45);
            btnBack.TabIndex = 40;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FormLihatQuotation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 670);
            Controls.Add(btnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonReset);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonApply);
            Controls.Add(dataGridViewQuotation);
            Name = "FormLihatQuotation";
            Text = "FormLihatQuotation";
            Load += FormLihatQuotation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuotation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewQuotation;
        private Label label2;
        private Label label1;
        private Button buttonReset;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button buttonApply;
        private Button btnBack;
    }
}