namespace OGOMS_Sprint2 {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblLogin = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            tbxUserName = new TextBox();
            tbxPassword = new TextBox();
            btnLoginContinue = new Button();
            lblName_Login = new Label();
            pnlMenu_Login = new Panel();
            lblError = new Label();
            pnlMenu_Login.SuspendLayout();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblLogin.ForeColor = Color.FromArgb(  18,   47,   94);
            lblLogin.Location = new Point(423, 71);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(138, 59);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblUsername.ForeColor = Color.FromArgb(  18,   47,   94);
            lblUsername.Location = new Point(370, 172);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 30);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblPassword.ForeColor = Color.FromArgb(  18,   47,   94);
            lblPassword.Location = new Point(370, 251);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(105, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // tbxUserName
            // 
            tbxUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxUserName.Location = new Point(370, 205);
            tbxUserName.MaxLength = 24;
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(245, 29);
            tbxUserName.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxPassword.Location = new Point(370, 284);
            tbxPassword.MaxLength = 24;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(245, 29);
            tbxPassword.TabIndex = 4;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLoginContinue
            // 
            btnLoginContinue.BackColor = Color.FromArgb(  61,   128,   186);
            btnLoginContinue.Font = new Font("Segoe UI", 9F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            btnLoginContinue.ForeColor = Color.White;
            btnLoginContinue.Location = new Point(449, 344);
            btnLoginContinue.Name = "btnLoginContinue";
            btnLoginContinue.Size = new Size(86, 31);
            btnLoginContinue.TabIndex = 5;
            btnLoginContinue.Text = "Continue";
            btnLoginContinue.UseVisualStyleBackColor = false;
            btnLoginContinue.Click += btnLoginContinue_Click;
            // 
            // lblName_Login
            // 
            lblName_Login.AutoSize = true;
            lblName_Login.Dock = DockStyle.Left;
            lblName_Login.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblName_Login.ForeColor = Color.White;
            lblName_Login.Location = new Point(0, 0);
            lblName_Login.Name = "lblName_Login";
            lblName_Login.Padding = new Padding(0, 5, 0, 0);
            lblName_Login.Size = new Size(223, 37);
            lblName_Login.TabIndex = 4;
            lblName_Login.Text = "Acme Distributing";
            // 
            // pnlMenu_Login
            // 
            pnlMenu_Login.BackColor = Color.FromArgb(  47,   85,   151);
            pnlMenu_Login.Controls.Add(lblName_Login);
            pnlMenu_Login.Dock = DockStyle.Top;
            pnlMenu_Login.Location = new Point(0, 0);
            pnlMenu_Login.Name = "pnlMenu_Login";
            pnlMenu_Login.Size = new Size(984, 44);
            pnlMenu_Login.TabIndex = 11;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(335, 407);
            lblError.Name = "lblError";
            lblError.Size = new Size(314, 30);
            lblError.TabIndex = 12;
            lblError.Text = "Invalid username or password!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(lblError);
            Controls.Add(pnlMenu_Login);
            Controls.Add(btnLoginContinue);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLogin);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OG OMS - Prototype, Sprint 2";
            Load += Login_Load;
            pnlMenu_Login.ResumeLayout(false);
            pnlMenu_Login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbxUserName;
        private TextBox tbxPassword;
        private Button btnLoginContinue;
        private Label lblName_Login;
        private Panel pnlMenu_Login;
        private Label lblError;
    }
}