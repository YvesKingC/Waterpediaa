namespace Waterpediaa
{
    partial class FormViewUser
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
            dataGridViewUser = new DataGridView();
            btnBack = new Button();
            panel2 = new Panel();
            cBoxIzinAkses = new ComboBox();
            label3 = new Label();
            tBoxPassword = new TextBox();
            tBoxUsername = new TextBox();
            tBoxNama = new TextBox();
            label2 = new Label();
            btnInput = new Button();
            label1 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            cBoxRemoveUser = new ComboBox();
            label7 = new Label();
            btnRemove = new Button();
            panel3 = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(12, 12);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowTemplate.Height = 25;
            dataGridViewUser.Size = new Size(231, 352);
            dataGridViewUser.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Location = new Point(655, 344);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 22);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cBoxIzinAkses);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tBoxPassword);
            panel2.Controls.Add(tBoxUsername);
            panel2.Controls.Add(tBoxNama);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnInput);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(249, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 180);
            panel2.TabIndex = 43;
            // 
            // cBoxIzinAkses
            // 
            cBoxIzinAkses.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxIzinAkses.FormattingEnabled = true;
            cBoxIzinAkses.Location = new Point(92, 130);
            cBoxIzinAkses.Name = "cBoxIzinAkses";
            cBoxIzinAkses.Size = new Size(233, 25);
            cBoxIzinAkses.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 133);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 50;
            label3.Text = "Izin Akses :";
            // 
            // tBoxPassword
            // 
            tBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            tBoxPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(92, 99);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(233, 25);
            tBoxPassword.TabIndex = 49;
            // 
            // tBoxUsername
            // 
            tBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            tBoxUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(92, 68);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.Size = new Size(233, 25);
            tBoxUsername.TabIndex = 48;
            // 
            // tBoxNama
            // 
            tBoxNama.BorderStyle = BorderStyle.FixedSingle;
            tBoxNama.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxNama.Location = new Point(92, 37);
            tBoxNama.Name = "tBoxNama";
            tBoxNama.Size = new Size(233, 25);
            tBoxNama.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 40);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 46;
            label2.Text = "Nama :";
            // 
            // btnInput
            // 
            btnInput.BackColor = Color.FromArgb(192, 255, 192);
            btnInput.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnInput.Location = new Point(405, 133);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(115, 32);
            btnInput.TabIndex = 43;
            btnInput.Text = "Input";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += btnInput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 101);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 34;
            label1.Text = "Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(8, 70);
            label5.Name = "label5";
            label5.Size = new Size(78, 19);
            label5.TabIndex = 15;
            label5.Text = "Username :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(538, 29);
            panel4.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(11, 4);
            label6.Name = "label6";
            label6.Size = new Size(131, 19);
            label6.TabIndex = 13;
            label6.Text = "Tambah User Baru";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cBoxRemoveUser);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(249, 198);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 120);
            panel1.TabIndex = 56;
            // 
            // cBoxRemoveUser
            // 
            cBoxRemoveUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxRemoveUser.FormattingEnabled = true;
            cBoxRemoveUser.Location = new Point(92, 37);
            cBoxRemoveUser.Name = "cBoxRemoveUser";
            cBoxRemoveUser.Size = new Size(408, 25);
            cBoxRemoveUser.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(34, 40);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 46;
            label7.Text = "Nama :";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 192, 192);
            btnRemove.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(405, 68);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(115, 32);
            btnRemove.TabIndex = 43;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(label10);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(538, 29);
            panel3.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(11, 4);
            label10.Name = "label10";
            label10.Size = new Size(131, 19);
            label10.TabIndex = 13;
            label10.Text = "Tambah User Baru";
            // 
            // FormViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 377);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnBack);
            Controls.Add(dataGridViewUser);
            Name = "FormViewUser";
            Text = "FormViewUser";
            Load += FormViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUser;
        private Button btnBack;
        private Panel panel2;
        private Label label2;
        private Button btnInput;
        private Label label1;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private Label label3;
        private TextBox tBoxPassword;
        private TextBox tBoxUsername;
        private TextBox tBoxNama;
        private Panel panel1;
        private ComboBox cBoxRemoveUser;
        private Label label7;
        private Button btnRemove;
        private Panel panel3;
        private Label label10;
        private ComboBox cBoxIzinAkses;
    }
}