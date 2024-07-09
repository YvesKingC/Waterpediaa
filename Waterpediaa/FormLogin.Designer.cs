namespace Waterpedia2
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tBoxUsername = new TextBox();
            tBoxPassword = new TextBox();
            cBoxRememberUser = new CheckBox();
            cBoxShowPass = new CheckBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(280, 30);
            label1.Name = "label1";
            label1.Size = new Size(241, 59);
            label1.TabIndex = 0;
            label1.Text = "Waterpedia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(177, 154);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(185, 235);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tBoxUsername
            // 
            tBoxUsername.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(323, 151);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.Size = new Size(299, 36);
            tBoxUsername.TabIndex = 3;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(323, 232);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(299, 36);
            tBoxPassword.TabIndex = 4;
            // 
            // cBoxRememberUser
            // 
            cBoxRememberUser.AutoSize = true;
            cBoxRememberUser.Location = new Point(323, 193);
            cBoxRememberUser.Name = "cBoxRememberUser";
            cBoxRememberUser.Size = new Size(140, 19);
            cBoxRememberUser.TabIndex = 5;
            cBoxRememberUser.Text = "Remember Username";
            cBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // cBoxShowPass
            // 
            cBoxShowPass.AutoSize = true;
            cBoxShowPass.Location = new Point(323, 274);
            cBoxShowPass.Name = "cBoxShowPass";
            cBoxShowPass.Size = new Size(108, 19);
            cBoxShowPass.TabIndex = 6;
            cBoxShowPass.Text = "Show Password";
            cBoxShowPass.UseVisualStyleBackColor = true;
            cBoxShowPass.CheckedChanged += cBoxShowPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(335, 299);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 38);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(btnLogin);
            Controls.Add(cBoxShowPass);
            Controls.Add(cBoxRememberUser);
            Controls.Add(tBoxPassword);
            Controls.Add(tBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tBoxUsername;
        private TextBox tBoxPassword;
        private CheckBox cBoxRememberUser;
        private CheckBox cBoxShowPass;
        private Button btnLogin;
    }
}