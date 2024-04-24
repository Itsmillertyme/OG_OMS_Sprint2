namespace OGOMS_Sprint2 {
    partial class OrderSubmitted {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderSubmitted));
            pnlMenu = new Panel();
            lblName = new Label();
            btnHome = new Button();
            btnProfile = new Button();
            btnHomeBig = new Button();
            lblSubmittalText = new Label();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(  47,   85,   151);
            pnlMenu.Controls.Add(lblName);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(btnProfile);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(984, 44);
            pnlMenu.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Left;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 0);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 5, 0, 0);
            lblName.Size = new Size(223, 37);
            lblName.TabIndex = 4;
            lblName.Text = "Acme Distributing";
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
            btnHome.Click += btnHome_Click;
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
            // btnHomeBig
            // 
            btnHomeBig.Anchor = AnchorStyles.Top;
            btnHomeBig.BackColor = Color.Transparent;
            btnHomeBig.BackgroundImage = (Image) resources.GetObject("btnHomeBig.BackgroundImage");
            btnHomeBig.BackgroundImageLayout = ImageLayout.Stretch;
            btnHomeBig.FlatAppearance.BorderSize = 0;
            btnHomeBig.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHomeBig.FlatStyle = FlatStyle.Flat;
            btnHomeBig.Location = new Point(460, 337);
            btnHomeBig.Name = "btnHomeBig";
            btnHomeBig.Padding = new Padding(12, 0, 12, 0);
            btnHomeBig.Size = new Size(65, 65);
            btnHomeBig.TabIndex = 8;
            btnHomeBig.UseVisualStyleBackColor = false;
            btnHomeBig.Click += btnHomeBig_Click;
            // 
            // lblSubmittalText
            // 
            lblSubmittalText.Anchor = AnchorStyles.Top;
            lblSubmittalText.AutoSize = true;
            lblSubmittalText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblSubmittalText.ForeColor = Color.FromArgb(  18,   47,   94);
            lblSubmittalText.Location = new Point(317, 156);
            lblSubmittalText.MaximumSize = new Size(350, 0);
            lblSubmittalText.Name = "lblSubmittalText";
            lblSubmittalText.Size = new Size(350, 160);
            lblSubmittalText.TabIndex = 9;
            lblSubmittalText.Text = "Your order has been submitted, and an invoice has been sent to the email on file. Click the button below to return to the home page.​";
            lblSubmittalText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderSubmitted
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(lblSubmittalText);
            Controls.Add(btnHomeBig);
            Controls.Add(pnlMenu);
            Name = "OrderSubmitted";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OG OMS - Prototype, Sprint 2";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Label lblName;
        private Button btnHome;
        private Button btnProfile;
        private Button btnHomeBig;
        private Label lblSubmittalText;
    }
}