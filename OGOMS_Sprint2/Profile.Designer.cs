namespace OGOMS_Sprint2 {
    partial class Profile {
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
            lblProfileName = new Label();
            pnlMenu_Home = new Panel();
            btnEdit = new Button();
            btnSignOut = new Button();
            flpUserName = new FlowLayoutPanel();
            lblUsername_Label = new Label();
            lblUsername_Display = new Label();
            flpSalesID = new FlowLayoutPanel();
            lblSalesID_Label = new Label();
            lblSalesID_Display = new Label();
            flpSalesZone = new FlowLayoutPanel();
            lblSalesZone_Label = new Label();
            lblSalesZone_Display = new Label();
            flpEmail = new FlowLayoutPanel();
            lblEmail_Label = new Label();
            lblEmail_Display = new Label();
            pnlMenu_Home.SuspendLayout();
            flpUserName.SuspendLayout();
            flpSalesID.SuspendLayout();
            flpSalesZone.SuspendLayout();
            flpEmail.SuspendLayout();
            SuspendLayout();
            // 
            // lblProfileName
            // 
            lblProfileName.Dock = DockStyle.Fill;
            lblProfileName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblProfileName.ForeColor = Color.White;
            lblProfileName.Location = new Point(0, 0);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Padding = new Padding(0, 5, 0, 5);
            lblProfileName.Size = new Size(484, 44);
            lblProfileName.TabIndex = 4;
            lblProfileName.Text = "Employee Name";
            lblProfileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMenu_Home
            // 
            pnlMenu_Home.BackColor = Color.FromArgb(  47,   85,   151);
            pnlMenu_Home.Controls.Add(btnEdit);
            pnlMenu_Home.Controls.Add(lblProfileName);
            pnlMenu_Home.Dock = DockStyle.Top;
            pnlMenu_Home.Location = new Point(0, 0);
            pnlMenu_Home.Name = "pnlMenu_Home";
            pnlMenu_Home.Size = new Size(484, 44);
            pnlMenu_Home.TabIndex = 4;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(12, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(48, 28);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.Transparent;
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            btnSignOut.ForeColor = Color.FromArgb(  18,   47,   94);
            btnSignOut.Location = new Point(189, 321);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(106, 28);
            btnSignOut.TabIndex = 6;
            btnSignOut.Text = "Sign Out";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // flpUserName
            // 
            flpUserName.Controls.Add(lblUsername_Label);
            flpUserName.Controls.Add(lblUsername_Display);
            flpUserName.Location = new Point(70, 80);
            flpUserName.Name = "flpUserName";
            flpUserName.Size = new Size(345, 30);
            flpUserName.TabIndex = 14;
            // 
            // lblUsername_Label
            // 
            lblUsername_Label.AutoSize = true;
            lblUsername_Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblUsername_Label.ForeColor = Color.FromArgb(  18,   47,   94);
            lblUsername_Label.Location = new Point(0, 0);
            lblUsername_Label.Margin = new Padding(0);
            lblUsername_Label.Name = "lblUsername_Label";
            lblUsername_Label.Size = new Size(116, 30);
            lblUsername_Label.TabIndex = 13;
            lblUsername_Label.Text = "Username:";
            // 
            // lblUsername_Display
            // 
            lblUsername_Display.AutoSize = true;
            lblUsername_Display.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblUsername_Display.ForeColor = Color.FromArgb(  18,   47,   94);
            lblUsername_Display.Location = new Point(116, 0);
            lblUsername_Display.Margin = new Padding(0);
            lblUsername_Display.Name = "lblUsername_Display";
            lblUsername_Display.Size = new Size(211, 30);
            lblUsername_Display.TabIndex = 14;
            lblUsername_Display.Text = "Employee Username";
            // 
            // flpSalesID
            // 
            flpSalesID.Controls.Add(lblSalesID_Label);
            flpSalesID.Controls.Add(lblSalesID_Display);
            flpSalesID.Location = new Point(70, 140);
            flpSalesID.Name = "flpSalesID";
            flpSalesID.Size = new Size(345, 30);
            flpSalesID.TabIndex = 15;
            // 
            // lblSalesID_Label
            // 
            lblSalesID_Label.AutoSize = true;
            lblSalesID_Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblSalesID_Label.ForeColor = Color.FromArgb(  18,   47,   94);
            lblSalesID_Label.Location = new Point(0, 0);
            lblSalesID_Label.Margin = new Padding(0);
            lblSalesID_Label.Name = "lblSalesID_Label";
            lblSalesID_Label.Size = new Size(139, 30);
            lblSalesID_Label.TabIndex = 13;
            lblSalesID_Label.Text = "Sales Rep ID:";
            // 
            // lblSalesID_Display
            // 
            lblSalesID_Display.AutoSize = true;
            lblSalesID_Display.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblSalesID_Display.ForeColor = Color.FromArgb(  18,   47,   94);
            lblSalesID_Display.Location = new Point(139, 0);
            lblSalesID_Display.Margin = new Padding(0);
            lblSalesID_Display.Name = "lblSalesID_Display";
            lblSalesID_Display.Size = new Size(191, 30);
            lblSalesID_Display.TabIndex = 14;
            lblSalesID_Display.Text = "Employee Sales ID";
            // 
            // flpSalesZone
            // 
            flpSalesZone.Controls.Add(lblSalesZone_Label);
            flpSalesZone.Controls.Add(lblSalesZone_Display);
            flpSalesZone.Location = new Point(70, 200);
            flpSalesZone.Name = "flpSalesZone";
            flpSalesZone.Size = new Size(345, 30);
            flpSalesZone.TabIndex = 16;
            // 
            // lblSalesZone_Label
            // 
            lblSalesZone_Label.AutoSize = true;
            lblSalesZone_Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblSalesZone_Label.ForeColor = Color.FromArgb(  18,   47,   94);
            lblSalesZone_Label.Location = new Point(0, 0);
            lblSalesZone_Label.Margin = new Padding(0);
            lblSalesZone_Label.Name = "lblSalesZone_Label";
            lblSalesZone_Label.Size = new Size(124, 30);
            lblSalesZone_Label.TabIndex = 13;
            lblSalesZone_Label.Text = "Sales Zone:";
            // 
            // lblSalesZone_Display
            // 
            lblSalesZone_Display.AutoSize = true;
            lblSalesZone_Display.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblSalesZone_Display.ForeColor = Color.FromArgb(  18,   47,   94);
            lblSalesZone_Display.Location = new Point(124, 0);
            lblSalesZone_Display.Margin = new Padding(0);
            lblSalesZone_Display.Name = "lblSalesZone_Display";
            lblSalesZone_Display.Size = new Size(219, 30);
            lblSalesZone_Display.TabIndex = 14;
            lblSalesZone_Display.Text = "Employee Sales Zone";
            // 
            // flpEmail
            // 
            flpEmail.Controls.Add(lblEmail_Label);
            flpEmail.Controls.Add(lblEmail_Display);
            flpEmail.Location = new Point(70, 260);
            flpEmail.Name = "flpEmail";
            flpEmail.Size = new Size(345, 30);
            flpEmail.TabIndex = 17;
            // 
            // lblEmail_Label
            // 
            lblEmail_Label.AutoSize = true;
            lblEmail_Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblEmail_Label.ForeColor = Color.FromArgb(  18,   47,   94);
            lblEmail_Label.Location = new Point(0, 0);
            lblEmail_Label.Margin = new Padding(0);
            lblEmail_Label.Name = "lblEmail_Label";
            lblEmail_Label.Size = new Size(72, 30);
            lblEmail_Label.TabIndex = 13;
            lblEmail_Label.Text = "Email:";
            // 
            // lblEmail_Display
            // 
            lblEmail_Display.AutoSize = true;
            lblEmail_Display.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblEmail_Display.ForeColor = Color.FromArgb(  18,   47,   94);
            lblEmail_Display.Location = new Point(72, 0);
            lblEmail_Display.Margin = new Padding(0);
            lblEmail_Display.Name = "lblEmail_Display";
            lblEmail_Display.Size = new Size(167, 30);
            lblEmail_Display.TabIndex = 14;
            lblEmail_Display.Text = "Employee Email";
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(484, 361);
            Controls.Add(flpEmail);
            Controls.Add(flpSalesZone);
            Controls.Add(flpSalesID);
            Controls.Add(flpUserName);
            Controls.Add(btnSignOut);
            Controls.Add(pnlMenu_Home);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Profile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User Profile";
            pnlMenu_Home.ResumeLayout(false);
            flpUserName.ResumeLayout(false);
            flpUserName.PerformLayout();
            flpSalesID.ResumeLayout(false);
            flpSalesID.PerformLayout();
            flpSalesZone.ResumeLayout(false);
            flpSalesZone.PerformLayout();
            flpEmail.ResumeLayout(false);
            flpEmail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblProfileName;
        private Panel pnlMenu_Home;
        private Button btnEdit;
        private Button btnSignOut;
        private Label lblUsername_Label;
        private Label lblSalesZone_Label;
        private Label lblUsername_Display;
        private FlowLayoutPanel flpSalesID;
        private Label lblSalesID_Label;
        private Label lblSalesID_Display;
        private FlowLayoutPanel flpSalesZone;
        private Label lblSalesZone_Display;
        private FlowLayoutPanel flpEmail;
        private Label lblEmail_Label;
        private Label lblEmail_Display;
        private FlowLayoutPanel flpUserName;
        private Label label3;
    }
}