namespace OGOMS_Sprint2 {
    partial class Home {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnHome = new Button();
            btnProfile = new Button();
            pnlMenu_Home = new Panel();
            lblName_Home = new Label();
            rbnSubmitOrder = new CustomControls.RoundedButton();
            lblSubmitOrder = new Label();
            lblCustMng = new Label();
            rbnCustMng = new CustomControls.RoundedButton();
            lblRoutePlan = new Label();
            rbnRoutePlan = new CustomControls.RoundedButton();
            pnlMenu_Home.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Dock = DockStyle.Right;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = (Image) resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(896, 0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(12, 0, 12, 0);
            btnHome.Size = new Size(44, 44);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Dock = DockStyle.Right;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = (Image) resources.GetObject("btnProfile.Image");
            btnProfile.Location = new Point(940, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(0, 0, 8, 0);
            btnProfile.Size = new Size(44, 44);
            btnProfile.TabIndex = 1;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pnlMenu_Home
            // 
            pnlMenu_Home.BackColor = Color.FromArgb(  47,   85,   151);
            pnlMenu_Home.Controls.Add(lblName_Home);
            pnlMenu_Home.Controls.Add(btnHome);
            pnlMenu_Home.Controls.Add(btnProfile);
            pnlMenu_Home.Dock = DockStyle.Top;
            pnlMenu_Home.Location = new Point(0, 0);
            pnlMenu_Home.Name = "pnlMenu_Home";
            pnlMenu_Home.Size = new Size(984, 44);
            pnlMenu_Home.TabIndex = 3;
            // 
            // lblName_Home
            // 
            lblName_Home.AutoSize = true;
            lblName_Home.Dock = DockStyle.Left;
            lblName_Home.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblName_Home.ForeColor = Color.White;
            lblName_Home.Location = new Point(0, 0);
            lblName_Home.Name = "lblName_Home";
            lblName_Home.Padding = new Padding(0, 5, 0, 0);
            lblName_Home.Size = new Size(223, 37);
            lblName_Home.TabIndex = 4;
            lblName_Home.Text = "Acme Distributing";
            // 
            // rbnSubmitOrder
            // 
            rbnSubmitOrder.BackColor = Color.FromArgb(  46,   117,   182);
            rbnSubmitOrder.FlatAppearance.BorderSize = 0;
            rbnSubmitOrder.FlatStyle = FlatStyle.Flat;
            rbnSubmitOrder.ForeColor = Color.White;
            rbnSubmitOrder.Image = (Image) resources.GetObject("rbnSubmitOrder.Image");
            rbnSubmitOrder.Location = new Point(56, 102);
            rbnSubmitOrder.Name = "rbnSubmitOrder";
            rbnSubmitOrder.Size = new Size(120, 120);
            rbnSubmitOrder.TabIndex = 5;
            rbnSubmitOrder.UseVisualStyleBackColor = false;
            rbnSubmitOrder.Click += rbnSubmitOrder_Click;
            // 
            // lblSubmitOrder
            // 
            lblSubmitOrder.AutoSize = true;
            lblSubmitOrder.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            lblSubmitOrder.Location = new Point(71, 225);
            lblSubmitOrder.Name = "lblSubmitOrder";
            lblSubmitOrder.Size = new Size(92, 42);
            lblSubmitOrder.TabIndex = 6;
            lblSubmitOrder.Text = "Submit a \r\nNew Order";
            lblSubmitOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCustMng
            // 
            lblCustMng.AutoSize = true;
            lblCustMng.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            lblCustMng.Location = new Point(236, 225);
            lblCustMng.Name = "lblCustMng";
            lblCustMng.Size = new Size(112, 42);
            lblCustMng.TabIndex = 8;
            lblCustMng.Text = "Customer\r\nManagement\r\n";
            lblCustMng.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbnCustMng
            // 
            rbnCustMng.BackColor = Color.FromArgb(  46,   117,   182);
            rbnCustMng.BackgroundImage = (Image) resources.GetObject("rbnCustMng.BackgroundImage");
            rbnCustMng.BackgroundImageLayout = ImageLayout.Center;
            rbnCustMng.FlatAppearance.BorderSize = 0;
            rbnCustMng.FlatStyle = FlatStyle.Flat;
            rbnCustMng.ForeColor = Color.White;
            rbnCustMng.Location = new Point(232, 102);
            rbnCustMng.Name = "rbnCustMng";
            rbnCustMng.Size = new Size(120, 120);
            rbnCustMng.TabIndex = 7;
            rbnCustMng.UseVisualStyleBackColor = false;
            rbnCustMng.Click += rbnCustMng_Click;
            // 
            // lblRoutePlan
            // 
            lblRoutePlan.AutoSize = true;
            lblRoutePlan.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            lblRoutePlan.Location = new Point(428, 225);
            lblRoutePlan.Name = "lblRoutePlan";
            lblRoutePlan.Size = new Size(79, 63);
            lblRoutePlan.TabIndex = 10;
            lblRoutePlan.Text = "Route\r\nPlanning\r\n\r\n";
            lblRoutePlan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbnRoutePlan
            // 
            rbnRoutePlan.BackColor = Color.FromArgb(  46,   117,   182);
            rbnRoutePlan.BackgroundImage = (Image) resources.GetObject("rbnRoutePlan.BackgroundImage");
            rbnRoutePlan.BackgroundImageLayout = ImageLayout.Center;
            rbnRoutePlan.FlatAppearance.BorderSize = 0;
            rbnRoutePlan.FlatStyle = FlatStyle.Flat;
            rbnRoutePlan.ForeColor = Color.White;
            rbnRoutePlan.Location = new Point(408, 102);
            rbnRoutePlan.Name = "rbnRoutePlan";
            rbnRoutePlan.Size = new Size(120, 120);
            rbnRoutePlan.TabIndex = 9;
            rbnRoutePlan.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(lblRoutePlan);
            Controls.Add(rbnRoutePlan);
            Controls.Add(lblCustMng);
            Controls.Add(rbnCustMng);
            Controls.Add(lblSubmitOrder);
            Controls.Add(rbnSubmitOrder);
            Controls.Add(pnlMenu_Home);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OG OMS - Prototype, Sprint 2";
            pnlMenu_Home.ResumeLayout(false);
            pnlMenu_Home.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Button btnProfile;
        private Panel pnlMenu_Home;
        private Label lblName_Home;
        private CustomControls.RoundedButton rbnSubmitOrder;
        private Label lblSubmitOrder;
        private Label lblCustMng;
        private CustomControls.RoundedButton rbnCustMng;
        private Label lblRoutePlan;
        private CustomControls.RoundedButton rbnRoutePlan;
    }
}