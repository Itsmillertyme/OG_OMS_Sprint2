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
            pnlMenu = new Panel();
            lblName = new Label();
            btnHome = new Button();
            btnProfile = new Button();
            lblCreateNewOrder = new Label();
            dgvItemSearch = new DataGridView();
            lblItemSearch = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) dgvItemSearch).BeginInit();
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
            // CreateNewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(984, 561);
            Controls.Add(lblItemSearch);
            Controls.Add(dgvItemSearch);
            Controls.Add(lblCreateNewOrder);
            Controls.Add(pnlMenu);
            MaximizeBox = false;
            Name = "CreateNewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateNewOrder";
            Load += CreateNewOrder_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) dgvItemSearch).EndInit();
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
    }
}