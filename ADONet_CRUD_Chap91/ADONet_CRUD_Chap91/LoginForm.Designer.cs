namespace ADONet_CRUD_Chap91
{
    partial class LoginForm
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
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblUser;
        private Label lblPass;
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblUser = new Label();
            lblPass = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(149, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(135, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(149, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(135, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(149, 123);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUser
            // 
            lblUser.Location = new Point(30, 30);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(100, 23);
            lblUser.TabIndex = 0;
            lblUser.Text = "Username:";
            // 
            // lblPass
            // 
            lblPass.Location = new Point(30, 70);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(100, 23);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password:";
            // 
            // LoginForm
            // 
            ClientSize = new Size(380, 180);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}