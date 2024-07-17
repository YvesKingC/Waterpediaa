namespace Waterpediaa
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
            comboBox1 = new ComboBox();
            button2 = new Button();
            labelfilter = new Label();
            button3 = new Button();
            button4 = new Button();
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
            button1.Text = "button1";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(676, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(676, 125);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 4;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelfilter
            // 
            labelfilter.AutoSize = true;
            labelfilter.Location = new Point(676, 68);
            labelfilter.Name = "labelfilter";
            labelfilter.Size = new Size(53, 20);
            labelfilter.TabIndex = 5;
            labelfilter.Text = "Filter : ";
            // 
            // button3
            // 
            button3.Location = new Point(676, 194);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 6;
            button3.Text = "Edit Item";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(676, 229);
            button4.Name = "button4";
            button4.Size = new Size(151, 29);
            button4.TabIndex = 7;
            button4.Text = "Item Baru";
            button4.UseVisualStyleBackColor = true;
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
            button8.Location = new Point(676, 264);
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
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(labelfilter);
            Controls.Add(button2);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Button button2;
        private Label labelfilter;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button8;
    }
}