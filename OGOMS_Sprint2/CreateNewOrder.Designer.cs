namespace OGOMS_Sprint2 {
    partial class CreateNewOrder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewOrder));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            lblName = new Label();
            btnHome = new Button();
            btnProfile = new Button();
            lblCreateNewOrder = new Label();
            dgvItemSearch = new DataGridView();
            lblItemSearch = new Label();
            dgvCart = new DataGridView();
            pnlCartHeader = new Panel();
            lblCartLabel = new Label();
            rbnSubmit = new CustomControls.RoundedButton();
            tbxAcctID = new TextBox();
            lblAccountID = new Label();
            tbxSalesID = new TextBox();
            lblSalesID = new Label();
            tbxDeliveryID = new TextBox();
            lblDeliveryID = new Label();
            dtpDeliveryDate = new DateTimePicker();
            lblDeliveryDate = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dgvItemSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize) dgvCart).BeginInit();
            pnlCartHeader.SuspendLayout();
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
            pnlMenu.TabIndex = 5;
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
            // lblCreateNewOrder
            // 
            lblCreateNewOrder.AutoSize = true;
            lblCreateNewOrder.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCreateNewOrder.ForeColor = Color.FromArgb(  18,   47,   94);
            lblCreateNewOrder.Location = new Point(344, 47);
            lblCreateNewOrder.Name = "lblCreateNewOrder";
            lblCreateNewOrder.Size = new Size(297, 30);
            lblCreateNewOrder.TabIndex = 6;
            lblCreateNewOrder.Text = "Submit New Customer Order";
            // 
            // dgvItemSearch
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(  224,   224,   224);
            dgvItemSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItemSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItemSearch.BackgroundColor = Color.FromArgb(  222,   235,   247);
            dgvItemSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemSearch.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItemSearch.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItemSearch.Location = new Point(95, 121);
            dgvItemSearch.Name = "dgvItemSearch";
            dgvItemSearch.RowHeadersVisible = false;
            dgvItemSearch.Size = new Size(347, 130);
            dgvItemSearch.TabIndex = 7;
            dgvItemSearch.CellClick += dgvItemSearch_CellClick;
            dgvItemSearch.SelectionChanged += dgvItemSearch_SelectionChanged;
            // 
            // lblItemSearch
            // 
            lblItemSearch.AutoSize = true;
            lblItemSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblItemSearch.ForeColor = Color.FromArgb(  18,   47,   94);
            lblItemSearch.Location = new Point(95, 97);
            lblItemSearch.Name = "lblItemSearch";
            lblItemSearch.Size = new Size(100, 21);
            lblItemSearch.TabIndex = 8;
            lblItemSearch.Text = "Item Search";
            // 
            // dgvCart
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(  224,   224,   224);
            dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.FromArgb(  222,   235,   247);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCart.Location = new Point(12, 345);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.Size = new Size(500, 130);
            dgvCart.TabIndex = 9;
            dgvCart.CellClick += dgvCart_CellClick;
            dgvCart.SelectionChanged += dgvCart_SelectionChanged;
            // 
            // pnlCartHeader
            // 
            pnlCartHeader.BackColor = Color.FromArgb(  47,   85,   151);
            pnlCartHeader.Controls.Add(lblCartLabel);
            pnlCartHeader.Location = new Point(12, 310);
            pnlCartHeader.Name = "pnlCartHeader";
            pnlCartHeader.Size = new Size(500, 35);
            pnlCartHeader.TabIndex = 10;
            // 
            // lblCartLabel
            // 
            lblCartLabel.AutoSize = true;
            lblCartLabel.Dock = DockStyle.Left;
            lblCartLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCartLabel.ForeColor = Color.White;
            lblCartLabel.Location = new Point(0, 0);
            lblCartLabel.Name = "lblCartLabel";
            lblCartLabel.Padding = new Padding(15, 5, 0, 0);
            lblCartLabel.Size = new Size(112, 30);
            lblCartLabel.TabIndex = 5;
            lblCartLabel.Text = "Your Cart";
            // 
            // rbnSubmit
            // 
            rbnSubmit.BackColor = Color.FromArgb(  46,   117,   182);
            rbnSubmit.FlatAppearance.BorderSize = 0;
            rbnSubmit.FlatStyle = FlatStyle.Flat;
            rbnSubmit.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            rbnSubmit.ForeColor = Color.White;
            rbnSubmit.Location = new Point(824, 471);
            rbnSubmit.Name = "rbnSubmit";
            rbnSubmit.Size = new Size(148, 59);
            rbnSubmit.TabIndex = 26;
            rbnSubmit.Text = "Review/Submit";
            rbnSubmit.UseVisualStyleBackColor = false;
            rbnSubmit.Click += rbnSubmit_Click;
            // 
            // tbxAcctID
            // 
            tbxAcctID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxAcctID.Location = new Point(641, 130);
            tbxAcctID.MaxLength = 55;
            tbxAcctID.Name = "tbxAcctID";
            tbxAcctID.Size = new Size(286, 29);
            tbxAcctID.TabIndex = 28;
            // 
            // lblAccountID
            // 
            lblAccountID.AutoSize = true;
            lblAccountID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblAccountID.ForeColor = Color.FromArgb(  18,   47,   94);
            lblAccountID.Location = new Point(641, 97);
            lblAccountID.Name = "lblAccountID";
            lblAccountID.Size = new Size(123, 30);
            lblAccountID.TabIndex = 27;
            lblAccountID.Text = "Account ID";
            // 
            // tbxSalesID
            // 
            tbxSalesID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxSalesID.Location = new Point(641, 216);
            tbxSalesID.MaxLength = 55;
            tbxSalesID.Name = "tbxSalesID";
            tbxSalesID.Size = new Size(286, 29);
            tbxSalesID.TabIndex = 30;
            // 
            // lblSalesID
            // 
            lblSalesID.AutoSize = true;
            lblSalesID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblSalesID.ForeColor = Color.FromArgb(  18,   47,   94);
            lblSalesID.Location = new Point(641, 183);
            lblSalesID.Name = "lblSalesID";
            lblSalesID.Size = new Size(133, 30);
            lblSalesID.TabIndex = 29;
            lblSalesID.Text = "Sales Rep ID";
            // 
            // tbxDeliveryID
            // 
            tbxDeliveryID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxDeliveryID.Location = new Point(641, 302);
            tbxDeliveryID.MaxLength = 55;
            tbxDeliveryID.Name = "tbxDeliveryID";
            tbxDeliveryID.Size = new Size(286, 29);
            tbxDeliveryID.TabIndex = 32;
            // 
            // lblDeliveryID
            // 
            lblDeliveryID.AutoSize = true;
            lblDeliveryID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblDeliveryID.ForeColor = Color.FromArgb(  18,   47,   94);
            lblDeliveryID.Location = new Point(641, 269);
            lblDeliveryID.Name = "lblDeliveryID";
            lblDeliveryID.Size = new Size(164, 30);
            lblDeliveryID.TabIndex = 31;
            lblDeliveryID.Text = "Delivery Rep ID";
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dtpDeliveryDate.Location = new Point(641, 388);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(228, 23);
            dtpDeliveryDate.TabIndex = 33;
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblDeliveryDate.ForeColor = Color.FromArgb(  18,   47,   94);
            lblDeliveryDate.Location = new Point(641, 355);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(144, 30);
            lblDeliveryDate.TabIndex = 34;
            lblDeliveryDate.Text = "Delivery Date";
            // 
            // CreateNewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(lblDeliveryDate);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(tbxDeliveryID);
            Controls.Add(lblDeliveryID);
            Controls.Add(tbxSalesID);
            Controls.Add(lblSalesID);
            Controls.Add(tbxAcctID);
            Controls.Add(lblAccountID);
            Controls.Add(rbnSubmit);
            Controls.Add(pnlCartHeader);
            Controls.Add(dgvCart);
            Controls.Add(lblItemSearch);
            Controls.Add(dgvItemSearch);
            Controls.Add(lblCreateNewOrder);
            Controls.Add(pnlMenu);
            MaximizeBox = false;
            Name = "CreateNewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OG OMS - Prototype, Sprint 2";
            Load += CreateNewOrder_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) dgvItemSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize) dgvCart).EndInit();
            pnlCartHeader.ResumeLayout(false);
            pnlCartHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Label lblName;
        private Button btnHome;
        private Button btnProfile;
        private Label lblCreateNewOrder;
        private DataGridView dgvItemSearch;
        private Label lblItemSearch;
        private DataGridView dgvCart;
        private Panel pnlCartHeader;
        private Label lblCartLabel;
        private CustomControls.RoundedButton rbnSubmit;
        private TextBox tbxAcctID;
        private Label lblAccountID;
        private TextBox tbxSalesID;
        private Label lblSalesID;
        private TextBox tbxDeliveryID;
        private Label lblDeliveryID;
        private DateTimePicker dtpDeliveryDate;
        private Label lblDeliveryDate;
    }
}