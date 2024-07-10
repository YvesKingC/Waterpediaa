namespace Waterpediaa
{
    partial class FormPilihDivisi
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
            lblWellcome = new Label();
            btnViewUser = new Button();
            btnLogout = new Button();
            btnWTP = new Button();
            btnBakteri = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWellcome
            // 
            lblWellcome.AutoSize = true;
            lblWellcome.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWellcome.Location = new Point(12, 13);
            lblWellcome.Name = "lblWellcome";
            lblWellcome.Size = new Size(134, 37);
            lblWellcome.TabIndex = 15;
            lblWellcome.Text = "Wellcome";
            // 
            // btnViewUser
            // 
            btnViewUser.AutoSize = true;
            btnViewUser.BackColor = Color.FromArgb(192, 255, 255);
            btnViewUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewUser.Location = new Point(256, 265);
            btnViewUser.Name = "btnViewUser";
            btnViewUser.Size = new Size(180, 48);
            btnViewUser.TabIndex = 14;
            btnViewUser.Text = "View User";
            btnViewUser.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(38, 282);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(72, 31);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnWTP
            // 
            btnWTP.AutoSize = true;
            btnWTP.BackColor = Color.FromArgb(192, 255, 255);
            btnWTP.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnWTP.Location = new Point(256, 95);
            btnWTP.Name = "btnWTP";
            btnWTP.Size = new Size(180, 158);
            btnWTP.TabIndex = 12;
            btnWTP.Text = "Divisi WTP";
            btnWTP.UseVisualStyleBackColor = false;
            // 
            // btnBakteri
            // 
            btnBakteri.AutoSize = true;
            btnBakteri.BackColor = Color.FromArgb(192, 255, 255);
            btnBakteri.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnBakteri.Location = new Point(38, 95);
            btnBakteri.Name = "btnBakteri";
            btnBakteri.Size = new Size(180, 158);
            btnBakteri.TabIndex = 11;
            btnBakteri.Text = "Divisi Bakteri";
            btnBakteri.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(lblWellcome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 65);
            panel1.TabIndex = 16;
            // 
            // FormPilihDivisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(476, 350);
            Controls.Add(panel1);
            Controls.Add(btnViewUser);
            Controls.Add(btnLogout);
            Controls.Add(btnWTP);
            Controls.Add(btnBakteri);
            Name = "FormPilihDivisi";
            Text = "FormPilihDivisi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWellcome;
        private Button btnViewUser;
        private Button btnLogout;
        private Button btnWTP;
        private Button btnBakteri;
        private Panel panel1;
    }
}