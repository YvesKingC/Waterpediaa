namespace Waterpediaa
{
    partial class FormBuatReceipt
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
            panel4 = new Panel();
            cBoxCustomer = new ComboBox();
            label23 = new Label();
            dtpServiceOrder = new DateTimePicker();
            label17 = new Label();
            panel5 = new Panel();
            label18 = new Label();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(cBoxCustomer);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(dtpServiceOrder);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(337, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(1019, 97);
            panel4.TabIndex = 33;
            // 
            // cBoxCustomer
            // 
            cBoxCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxCustomer.FormattingEnabled = true;
            cBoxCustomer.Location = new Point(140, 49);
            cBoxCustomer.Name = "cBoxCustomer";
            cBoxCustomer.Size = new Size(280, 25);
            cBoxCustomer.TabIndex = 45;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(18, 52);
            label23.Name = "label23";
            label23.Size = new Size(116, 19);
            label23.TabIndex = 44;
            label23.Text = "Customer Name :";
            // 
            // dtpServiceOrder
            // 
            dtpServiceOrder.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpServiceOrder.Location = new Point(530, 52);
            dtpServiceOrder.Name = "dtpServiceOrder";
            dtpServiceOrder.Size = new Size(198, 23);
            dtpServiceOrder.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(479, 52);
            label17.Name = "label17";
            label17.Size = new Size(45, 19);
            label17.TabIndex = 15;
            label17.Text = "Date :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.Controls.Add(label18);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1018, 29);
            panel5.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(11, 4);
            label18.Name = "label18";
            label18.Size = new Size(159, 19);
            label18.TabIndex = 13;
            label18.Text = "Quotation Information";
            // 
            // FormBuatReceipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 728);
            Controls.Add(panel4);
            Name = "FormBuatReceipt";
            Text = "FormBuatReceipt";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private ComboBox cBoxCustomer;
        private Label label23;
        private DateTimePicker dtpServiceOrder;
        private Label label17;
        private Panel panel5;
        private Label label18;
    }
}