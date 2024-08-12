namespace Waterpediaa
{
    partial class FormDashboardSales
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
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Moccasin;
            button1.Location = new Point(637, 12);
            button1.Name = "button1";
            button1.Size = new Size(270, 240);
            button1.TabIndex = 0;
            button1.Text = "Sales Report";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Wheat;
            button2.Location = new Point(637, 303);
            button2.Name = "button2";
            button2.Size = new Size(270, 233);
            button2.TabIndex = 1;
            button2.Text = "Buat Invoice";
            button2.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(289, 12);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 12);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 4;
            label1.Text = "-";
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.Location = new Point(559, 12);
            button3.Name = "button3";
            button3.Size = new Size(59, 27);
            button3.TabIndex = 5;
            button3.Text = "Apply";
            button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-2, 58);
            label2.Name = "label2";
            label2.Size = new Size(249, 81);
            label2.TabIndex = 6;
            label2.Text = "Omset :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(30, 139);
            label3.Name = "label3";
            label3.Size = new Size(121, 81);
            label3.TabIndex = 7;
            label3.Text = "Rp.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 314);
            label4.Name = "label4";
            label4.Size = new Size(228, 81);
            label4.TabIndex = 8;
            label4.Text = "Profit :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(30, 395);
            label5.Name = "label5";
            label5.Size = new Size(121, 81);
            label5.TabIndex = 9;
            label5.Text = "Rp.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(289, 150);
            label6.Name = "label6";
            label6.Size = new Size(69, 81);
            label6.TabIndex = 10;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(289, 395);
            label7.Name = "label7";
            label7.Size = new Size(69, 81);
            label7.TabIndex = 11;
            label7.Text = "0";
            // 
            // FormDashboardSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 548);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormDashboardSales";
            Text = "FormDashboardSales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}