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
            label2 = new Label();
            btnInput = new Button();
            label1 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            tBoxNamaUser = new TextBox();
            tBoxUsername = new TextBox();
            tBoxPassword = new TextBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            rBtnFinance = new RadioButton();
            rBtnBakteri = new RadioButton();
            rBtnTraining = new RadioButton();
            rBtnWTP = new RadioButton();
            panel1 = new Panel();
            label7 = new Label();
            btnRemove = new Button();
            panel3 = new Panel();
            label10 = new Label();
            cBoxRemoveUser = new ComboBox();
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
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rBtnWTP);
            panel2.Controls.Add(rBtnTraining);
            panel2.Controls.Add(rBtnBakteri);
            panel2.Controls.Add(rBtnFinance);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tBoxPassword);
            panel2.Controls.Add(tBoxUsername);
            panel2.Controls.Add(tBoxNamaUser);
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
            // tBoxNamaUser
            // 
            tBoxNamaUser.BorderStyle = BorderStyle.FixedSingle;
            tBoxNamaUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxNamaUser.Location = new Point(92, 37);
            tBoxNamaUser.Name = "tBoxNamaUser";
            tBoxNamaUser.Size = new Size(124, 25);
            tBoxNamaUser.TabIndex = 47;
            // 
            // tBoxUsername
            // 
            tBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            tBoxUsername.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(92, 68);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.Size = new Size(124, 25);
            tBoxUsername.TabIndex = 48;
            // 
            // tBoxPassword
            // 
            tBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            tBoxPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(92, 99);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(124, 25);
            tBoxPassword.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(253, 40);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 50;
            label3.Text = "Izin Akses :";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(335, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 23);
            radioButton1.TabIndex = 51;
            radioButton1.TabStop = true;
            radioButton1.Text = "Admin";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rBtnFinance
            // 
            rBtnFinance.AutoSize = true;
            rBtnFinance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnFinance.Location = new Point(335, 66);
            rBtnFinance.Name = "rBtnFinance";
            rBtnFinance.Size = new Size(73, 23);
            rBtnFinance.TabIndex = 52;
            rBtnFinance.TabStop = true;
            rBtnFinance.Text = "Finance";
            rBtnFinance.UseVisualStyleBackColor = true;
            // 
            // rBtnBakteri
            // 
            rBtnBakteri.AutoSize = true;
            rBtnBakteri.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnBakteri.Location = new Point(335, 95);
            rBtnBakteri.Name = "rBtnBakteri";
            rBtnBakteri.Size = new Size(69, 23);
            rBtnBakteri.TabIndex = 53;
            rBtnBakteri.TabStop = true;
            rBtnBakteri.Text = "Bakteri";
            rBtnBakteri.UseVisualStyleBackColor = true;
            // 
            // rBtnTraining
            // 
            rBtnTraining.AutoSize = true;
            rBtnTraining.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnTraining.Location = new Point(445, 66);
            rBtnTraining.Name = "rBtnTraining";
            rBtnTraining.Size = new Size(75, 23);
            rBtnTraining.TabIndex = 54;
            rBtnTraining.TabStop = true;
            rBtnTraining.Text = "Training";
            rBtnTraining.UseVisualStyleBackColor = true;
            // 
            // rBtnWTP
            // 
            rBtnWTP.AutoSize = true;
            rBtnWTP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rBtnWTP.Location = new Point(445, 40);
            rBtnWTP.Name = "rBtnWTP";
            rBtnWTP.Size = new Size(55, 23);
            rBtnWTP.TabIndex = 55;
            rBtnWTP.TabStop = true;
            rBtnWTP.Text = "WTP";
            rBtnWTP.UseVisualStyleBackColor = true;
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
            // cBoxRemoveUser
            // 
            cBoxRemoveUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxRemoveUser.FormattingEnabled = true;
            cBoxRemoveUser.Location = new Point(92, 37);
            cBoxRemoveUser.Name = "cBoxRemoveUser";
            cBoxRemoveUser.Size = new Size(408, 25);
            cBoxRemoveUser.TabIndex = 47;
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
        private RadioButton rBtnWTP;
        private RadioButton rBtnTraining;
        private RadioButton rBtnBakteri;
        private RadioButton rBtnFinance;
        private RadioButton radioButton1;
        private Label label3;
        private TextBox tBoxPassword;
        private TextBox tBoxUsername;
        private TextBox tBoxNamaUser;
        private Panel panel1;
        private ComboBox cBoxRemoveUser;
        private Label label7;
        private Button btnRemove;
        private Panel panel3;
        private Label label10;
    }
}