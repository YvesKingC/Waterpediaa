namespace Waterpediaa
{
    partial class FormLogin
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
            btnLogin = new Button();
            cBoxShowPass = new CheckBox();
            cBoxRememberUser = new CheckBox();
            tBoxPassword = new TextBox();
            tBoxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(184, 169);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 38);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cBoxShowPass
            // 
            cBoxShowPass.AutoSize = true;
            cBoxShowPass.Location = new Point(172, 144);
            cBoxShowPass.Name = "cBoxShowPass";
            cBoxShowPass.Size = new Size(108, 19);
            cBoxShowPass.TabIndex = 14;
            cBoxShowPass.Text = "Show Password";
            cBoxShowPass.UseVisualStyleBackColor = true;
            cBoxShowPass.CheckedChanged += cBoxShowPass_CheckedChanged;
            // 
            // cBoxRememberUser
            // 
            cBoxRememberUser.AutoSize = true;
            cBoxRememberUser.Location = new Point(172, 63);
            cBoxRememberUser.Name = "cBoxRememberUser";
            cBoxRememberUser.Size = new Size(140, 19);
            cBoxRememberUser.TabIndex = 13;
            cBoxRememberUser.Text = "Remember Username";
            cBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // tBoxPassword
            // 
            tBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            tBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(172, 102);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(299, 36);
            tBoxPassword.TabIndex = 12;
            // 
            // tBoxUsername
            // 
            tBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            tBoxUsername.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(172, 21);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.Size = new Size(299, 36);
            tBoxUsername.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 105);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 24);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Logo_Waterpedia_PNG;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(277, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tBoxUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cBoxShowPass);
            panel1.Controls.Add(tBoxPassword);
            panel1.Controls.Add(cBoxRememberUser);
            panel1.Location = new Point(143, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 226);
            panel1.TabIndex = 18;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 531);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private CheckBox cBoxShowPass;
        private CheckBox cBoxRememberUser;
        private TextBox tBoxPassword;
        private TextBox tBoxUsername;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}