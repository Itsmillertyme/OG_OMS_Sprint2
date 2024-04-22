namespace OGOMS_Sprint2 {
    partial class ReviewOrder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewOrder));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            lblName = new Label();
            btnHome = new Button();
            btnProfile = new Button();
            lblOrderInfo = new Label();
            lblYourOrder = new Label();
            dgvOrderInfo = new DataGridView();
            dgvOrderCart = new DataGridView();
            rbnBack = new CustomControls.RoundedButton();
            rbnSubmit = new CustomControls.RoundedButton();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dgvOrderInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize) dgvOrderCart).BeginInit();
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
            pnlMenu.TabIndex = 6;
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
            // 
            // lblOrderInfo
            // 
            lblOrderInfo.AutoSize = true;
            lblOrderInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblOrderInfo.ForeColor = Color.FromArgb(  18,   47,   94);
            lblOrderInfo.Location = new Point(395, 47);
            lblOrderInfo.Name = "lblOrderInfo";
            lblOrderInfo.Size = new Size(194, 30);
            lblOrderInfo.TabIndex = 7;
            lblOrderInfo.Text = "Order Information";
            // 
            // lblYourOrder
            // 
            lblYourOrder.AutoSize = true;
            lblYourOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblYourOrder.ForeColor = Color.FromArgb(  18,   47,   94);
            lblYourOrder.Location = new Point(422, 163);
            lblYourOrder.Name = "lblYourOrder";
            lblYourOrder.Size = new Size(140, 32);
            lblYourOrder.TabIndex = 8;
            lblYourOrder.Text = "Your Order";
            // 
            // dgvOrderInfo
            // 
            dgvOrderInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderInfo.BackgroundColor = Color.FromArgb(  222,   235,   247);
            dgvOrderInfo.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(  47,   85,   151);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrderInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrderInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOrderInfo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderInfo.Location = new Point(167, 89);
            dgvOrderInfo.Name = "dgvOrderInfo";
            dgvOrderInfo.RowHeadersVisible = false;
            dgvOrderInfo.ScrollBars = ScrollBars.None;
            dgvOrderInfo.Size = new Size(650, 58);
            dgvOrderInfo.TabIndex = 9;
            dgvOrderInfo.SelectionChanged += dgvOrderInfo_SelectionChanged;
            // 
            // dgvOrderCart
            // 
            dgvOrderCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderCart.BackgroundColor = Color.FromArgb(  222,   235,   247);
            dgvOrderCart.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(  47,   85,   151);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOrderCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvOrderCart.DefaultCellStyle = dataGridViewCellStyle4;
            dgvOrderCart.Location = new Point(167, 209);
            dgvOrderCart.Name = "dgvOrderCart";
            dgvOrderCart.RowHeadersVisible = false;
            dgvOrderCart.ScrollBars = ScrollBars.Vertical;
            dgvOrderCart.Size = new Size(650, 222);
            dgvOrderCart.TabIndex = 10;
            dgvOrderCart.SelectionChanged += dgvOrderCart_SelectionChanged;
            // 
            // rbnBack
            // 
            rbnBack.BackColor = Color.FromArgb(  46,   117,   182);
            rbnBack.FlatAppearance.BorderSize = 0;
            rbnBack.FlatStyle = FlatStyle.Flat;
            rbnBack.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            rbnBack.ForeColor = Color.White;
            rbnBack.Location = new Point(167, 462);
            rbnBack.Name = "rbnBack";
            rbnBack.Size = new Size(148, 59);
            rbnBack.TabIndex = 27;
            rbnBack.Text = "Back";
            rbnBack.UseVisualStyleBackColor = false;
            rbnBack.Click += rbnBack_Click;
            // 
            // rbnSubmit
            // 
            rbnSubmit.BackColor = Color.FromArgb(  46,   117,   182);
            rbnSubmit.FlatAppearance.BorderSize = 0;
            rbnSubmit.FlatStyle = FlatStyle.Flat;
            rbnSubmit.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            rbnSubmit.ForeColor = Color.White;
            rbnSubmit.Location = new Point(669, 462);
            rbnSubmit.Name = "rbnSubmit";
            rbnSubmit.Size = new Size(148, 59);
            rbnSubmit.TabIndex = 28;
            rbnSubmit.Text = "Submit";
            rbnSubmit.UseVisualStyleBackColor = false;
            rbnSubmit.Click += rbnSubmit_Click;
            // 
            // ReviewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(rbnSubmit);
            Controls.Add(rbnBack);
            Controls.Add(dgvOrderCart);
            Controls.Add(dgvOrderInfo);
            Controls.Add(lblYourOrder);
            Controls.Add(lblOrderInfo);
            Controls.Add(pnlMenu);
            MaximizeBox = false;
            Name = "ReviewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OG OMS - Prototype, Sprint 2";
            Load += ReviewOrder_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) dgvOrderInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize) dgvOrderCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Label lblName;
        private Button btnHome;
        private Button btnProfile;
        private Label lblOrderInfo;
        private Label lblYourOrder;
        private DataGridView dgvOrderInfo;
        private DataGridView dgvOrderCart;
        private CustomControls.RoundedButton rbnBack;
        private CustomControls.RoundedButton rbnSubmit;
    }
}