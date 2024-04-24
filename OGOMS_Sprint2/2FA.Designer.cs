namespace OGOMS_Sprint2 {
    partial class _2FA {
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
            btn2FAContinue = new Button();
            tbx2FA = new TextBox();
            lbl2FA = new Label();
            lblLogin = new Label();
            lblName_2FA = new Label();
            pnlMenu_2FA = new Panel();
            pnlMenu_2FA.SuspendLayout();
            SuspendLayout();
            // 
            // btn2FAContinue
            // 
            btn2FAContinue.Anchor = AnchorStyles.Top;
            btn2FAContinue.BackColor = Color.FromArgb(  61,   128,   186);
            btn2FAContinue.Font = new Font("Segoe UI", 9F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            btn2FAContinue.ForeColor = Color.White;
            btn2FAContinue.Location = new Point(449, 310);
            btn2FAContinue.Name = "btn2FAContinue";
            btn2FAContinue.Size = new Size(86, 31);
            btn2FAContinue.TabIndex = 9;
            btn2FAContinue.Text = "Continue";
            btn2FAContinue.UseVisualStyleBackColor = false;
            btn2FAContinue.Click += btn2FAContinue_Click;
            // 
            // tbx2FA
            // 
            tbx2FA.Anchor = AnchorStyles.Top;
            tbx2FA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbx2FA.Location = new Point(370, 229);
            tbx2FA.MaxLength = 24;
            tbx2FA.Name = "tbx2FA";
            tbx2FA.Size = new Size(245, 29);
            tbx2FA.TabIndex = 8;
            // 
            // lbl2FA
            // 
            lbl2FA.Anchor = AnchorStyles.Top;
            lbl2FA.AutoSize = true;
            lbl2FA.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lbl2FA.ForeColor = Color.FromArgb(  18,   47,   94);
            lbl2FA.Location = new Point(370, 196);
            lbl2FA.Name = "lbl2FA";
            lbl2FA.Size = new Size(106, 30);
            lbl2FA.TabIndex = 7;
            lbl2FA.Text = "2FA Code";
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblLogin.ForeColor = Color.FromArgb(  18,   47,   94);
            lblLogin.Location = new Point(423, 71);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(138, 59);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login";
            // 
            // lblName_2FA
            // 
            lblName_2FA.AutoSize = true;
            lblName_2FA.Dock = DockStyle.Left;
            lblName_2FA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblName_2FA.ForeColor = Color.White;
            lblName_2FA.Location = new Point(0, 0);
            lblName_2FA.Name = "lblName_2FA";
            lblName_2FA.Padding = new Padding(0, 5, 0, 0);
            lblName_2FA.Size = new Size(223, 37);
            lblName_2FA.TabIndex = 4;
            lblName_2FA.Text = "Acme Distributing";
            // 
            // pnlMenu_2FA
            // 
            pnlMenu_2FA.BackColor = Color.FromArgb(  47,   85,   151);
            pnlMenu_2FA.Controls.Add(lblName_2FA);
            pnlMenu_2FA.Dock = DockStyle.Top;
            pnlMenu_2FA.Location = new Point(0, 0);
            pnlMenu_2FA.Name = "pnlMenu_2FA";
            pnlMenu_2FA.Size = new Size(984, 44);
            pnlMenu_2FA.TabIndex = 10;
            // 
            // _2FA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(pnlMenu_2FA);
            Controls.Add(btn2FAContinue);
            Controls.Add(tbx2FA);
            Controls.Add(lbl2FA);
            Controls.Add(lblLogin);
            Name = "_2FA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OG OMS - Prototype, Sprint 2";
            pnlMenu_2FA.ResumeLayout(false);
            pnlMenu_2FA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn2FAContinue;
        private TextBox tbx2FA;
        private Label lbl2FA;
        private Label lblLogin;
        private Label lblName_2FA;
        private Panel pnlMenu_2FA;
    }
}