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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(341, 295);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(119, 38);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // cBoxShowPass
            // 
            cBoxShowPass.AutoSize = true;
            cBoxShowPass.Location = new Point(329, 270);
            cBoxShowPass.Name = "cBoxShowPass";
            cBoxShowPass.Size = new Size(108, 19);
            cBoxShowPass.TabIndex = 14;
            cBoxShowPass.Text = "Show Password";
            cBoxShowPass.UseVisualStyleBackColor = true;
            // 
            // cBoxRememberUser
            // 
            cBoxRememberUser.AutoSize = true;
            cBoxRememberUser.Location = new Point(329, 189);
            cBoxRememberUser.Name = "cBoxRememberUser";
            cBoxRememberUser.Size = new Size(140, 19);
            cBoxRememberUser.TabIndex = 13;
            cBoxRememberUser.Text = "Remember Username";
            cBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // tBoxPassword
            // 
            tBoxPassword.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxPassword.Location = new Point(329, 228);
            tBoxPassword.Name = "tBoxPassword";
            tBoxPassword.Size = new Size(299, 36);
            tBoxPassword.TabIndex = 12;
            // 
            // tBoxUsername
            // 
            tBoxUsername.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxUsername.Location = new Point(329, 147);
            tBoxUsername.Name = "tBoxUsername";
            tBoxUsername.Size = new Size(299, 36);
            tBoxUsername.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(191, 231);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(183, 150);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(286, 26);
            label1.Name = "label1";
            label1.Size = new Size(241, 59);
            label1.TabIndex = 8;
            label1.Text = "Waterpedia";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 374);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private CheckBox cBoxShowPass;
        private CheckBox cBoxRememberUser;
        private TextBox tBoxPassword;
        private TextBox tBoxUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}