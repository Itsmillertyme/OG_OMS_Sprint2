namespace OGOMS_Sprint2 {
    partial class CustomerManagement {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagement));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            lblName = new Label();
            btnHome = new Button();
            btnProfile = new Button();
            lblCustomerManagement = new Label();
            dgvCustomerManagement = new DataGridView();
            rbnAddNewCust = new CustomControls.RoundedButton();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dgvCustomerManagement).BeginInit();
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
            pnlMenu.TabIndex = 4;
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
            // lblCustomerManagement
            // 
            lblCustomerManagement.Anchor = AnchorStyles.Top;
            lblCustomerManagement.AutoSize = true;
            lblCustomerManagement.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCustomerManagement.ForeColor = Color.FromArgb(  18,   47,   94);
            lblCustomerManagement.Location = new Point(307, 62);
            lblCustomerManagement.Name = "lblCustomerManagement";
            lblCustomerManagement.Size = new Size(371, 45);
            lblCustomerManagement.TabIndex = 5;
            lblCustomerManagement.Text = "Customer Management";
            // 
            // dgvCustomerManagement
            // 
            dgvCustomerManagement.AllowUserToAddRows = false;
            dgvCustomerManagement.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomerManagement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomerManagement.Anchor =  AnchorStyles.Top | AnchorStyles.Bottom;
            dgvCustomerManagement.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomerManagement.BackgroundColor = Color.FromArgb(  222,   235,   247);
            dgvCustomerManagement.BorderStyle = BorderStyle.None;
            dgvCustomerManagement.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(  47,   85,   151);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomerManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomerManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCustomerManagement.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCustomerManagement.EnableHeadersVisualStyles = false;
            dgvCustomerManagement.Location = new Point(132, 215);
            dgvCustomerManagement.Name = "dgvCustomerManagement";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCustomerManagement.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomerManagement.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvCustomerManagement.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomerManagement.RowTemplate.Height = 40;
            dgvCustomerManagement.Size = new Size(720, 240);
            dgvCustomerManagement.TabIndex = 6;
            dgvCustomerManagement.SelectionChanged += dgvCustomerManagement_SelectionChanged;
            // 
            // rbnAddNewCust
            // 
            rbnAddNewCust.Anchor = AnchorStyles.Top;
            rbnAddNewCust.BackColor = Color.FromArgb(  46,   117,   182);
            rbnAddNewCust.FlatAppearance.BorderSize = 0;
            rbnAddNewCust.FlatStyle = FlatStyle.Flat;
            rbnAddNewCust.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            rbnAddNewCust.ForeColor = Color.White;
            rbnAddNewCust.Location = new Point(727, 123);
            rbnAddNewCust.Name = "rbnAddNewCust";
            rbnAddNewCust.Size = new Size(100, 59);
            rbnAddNewCust.TabIndex = 25;
            rbnAddNewCust.Text = "Add New\r\nCustomer\r\n";
            rbnAddNewCust.UseVisualStyleBackColor = false;
            rbnAddNewCust.Click += rbnAddNewCust_Click;
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(rbnAddNewCust);
            Controls.Add(dgvCustomerManagement);
            Controls.Add(lblCustomerManagement);
            Controls.Add(pnlMenu);
            Name = "CustomerManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OG OMS - Prototype, Sprint 2";
            Load += CustomerManagement_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) dgvCustomerManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Label lblName;
        private Button btnHome;
        private Button btnProfile;
        private Label lblCustomerManagement;
        private DataGridView dgvCustomerManagement;
        private CustomControls.RoundedButton rbnAddNewCust;
    }
}