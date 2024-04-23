namespace OGOMS_Sprint2 {
    partial class AddCustomer {
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
            lblAddCust = new Label();
            pnlMenu_AaddCust = new Panel();
            tbxCustName = new TextBox();
            lblCustName = new Label();
            tbxCustStreet = new TextBox();
            lblCustStreet = new Label();
            tbxCustCity = new TextBox();
            lblCustCity = new Label();
            tbxCustZip = new TextBox();
            lblCustZip = new Label();
            tbxCustState = new TextBox();
            lblCustState = new Label();
            tbxPOCEmail = new TextBox();
            lblPOCEmail = new Label();
            tbxDeliveryPOCName = new TextBox();
            lblDeliveryPOCName = new Label();
            tbxDeliveryHours = new TextBox();
            lblDeliveryHours = new Label();
            tbxPOCPhone = new TextBox();
            lblPOCPhone = new Label();
            rbnAddCust = new CustomControls.RoundedButton();
            btnBack = new Button();
            pnlMenu_AaddCust.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddCust
            // 
            lblAddCust.Dock = DockStyle.Fill;
            lblAddCust.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblAddCust.ForeColor = Color.White;
            lblAddCust.Location = new Point(0, 0);
            lblAddCust.Name = "lblAddCust";
            lblAddCust.Padding = new Padding(0, 5, 0, 5);
            lblAddCust.Size = new Size(534, 44);
            lblAddCust.TabIndex = 4;
            lblAddCust.Text = "Add New Customer";
            lblAddCust.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMenu_AaddCust
            // 
            pnlMenu_AaddCust.BackColor = Color.FromArgb(  47,   85,   151);
            pnlMenu_AaddCust.Controls.Add(btnBack);
            pnlMenu_AaddCust.Controls.Add(lblAddCust);
            pnlMenu_AaddCust.Dock = DockStyle.Top;
            pnlMenu_AaddCust.Location = new Point(0, 0);
            pnlMenu_AaddCust.Name = "pnlMenu_AaddCust";
            pnlMenu_AaddCust.Size = new Size(534, 44);
            pnlMenu_AaddCust.TabIndex = 5;
            // 
            // tbxCustName
            // 
            tbxCustName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxCustName.Location = new Point(15, 80);
            tbxCustName.MaxLength = 55;
            tbxCustName.Name = "tbxCustName";
            tbxCustName.Size = new Size(245, 29);
            tbxCustName.TabIndex = 7;
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCustName.ForeColor = Color.FromArgb(  18,   47,   94);
            lblCustName.Location = new Point(15, 47);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(171, 30);
            lblCustName.TabIndex = 6;
            lblCustName.Text = "Customer Name";
            // 
            // tbxCustStreet
            // 
            tbxCustStreet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxCustStreet.Location = new Point(15, 145);
            tbxCustStreet.MaxLength = 55;
            tbxCustStreet.Name = "tbxCustStreet";
            tbxCustStreet.Size = new Size(245, 29);
            tbxCustStreet.TabIndex = 9;
            // 
            // lblCustStreet
            // 
            lblCustStreet.AutoSize = true;
            lblCustStreet.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCustStreet.ForeColor = Color.FromArgb(  18,   47,   94);
            lblCustStreet.Location = new Point(15, 112);
            lblCustStreet.Name = "lblCustStreet";
            lblCustStreet.Size = new Size(170, 30);
            lblCustStreet.TabIndex = 8;
            lblCustStreet.Text = "Customer Street";
            // 
            // tbxCustCity
            // 
            tbxCustCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxCustCity.Location = new Point(275, 145);
            tbxCustCity.MaxLength = 55;
            tbxCustCity.Name = "tbxCustCity";
            tbxCustCity.Size = new Size(245, 29);
            tbxCustCity.TabIndex = 11;
            // 
            // lblCustCity
            // 
            lblCustCity.AutoSize = true;
            lblCustCity.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCustCity.ForeColor = Color.FromArgb(  18,   47,   94);
            lblCustCity.Location = new Point(275, 112);
            lblCustCity.Name = "lblCustCity";
            lblCustCity.Size = new Size(151, 30);
            lblCustCity.TabIndex = 10;
            lblCustCity.Text = "Customer City";
            // 
            // tbxCustZip
            // 
            tbxCustZip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxCustZip.Location = new Point(275, 210);
            tbxCustZip.MaxLength = 55;
            tbxCustZip.Name = "tbxCustZip";
            tbxCustZip.Size = new Size(245, 29);
            tbxCustZip.TabIndex = 15;
            // 
            // lblCustZip
            // 
            lblCustZip.AutoSize = true;
            lblCustZip.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCustZip.ForeColor = Color.FromArgb(  18,   47,   94);
            lblCustZip.Location = new Point(275, 177);
            lblCustZip.Name = "lblCustZip";
            lblCustZip.Size = new Size(201, 30);
            lblCustZip.TabIndex = 14;
            lblCustZip.Text = "Customer Zip Code";
            // 
            // tbxCustState
            // 
            tbxCustState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxCustState.Location = new Point(15, 210);
            tbxCustState.MaxLength = 55;
            tbxCustState.Name = "tbxCustState";
            tbxCustState.Size = new Size(245, 29);
            tbxCustState.TabIndex = 13;
            // 
            // lblCustState
            // 
            lblCustState.AutoSize = true;
            lblCustState.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblCustState.ForeColor = Color.FromArgb(  18,   47,   94);
            lblCustState.Location = new Point(15, 177);
            lblCustState.Name = "lblCustState";
            lblCustState.Size = new Size(162, 30);
            lblCustState.TabIndex = 12;
            lblCustState.Text = "Customer State";
            // 
            // tbxPOCEmail
            // 
            tbxPOCEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxPOCEmail.Location = new Point(275, 275);
            tbxPOCEmail.MaxLength = 55;
            tbxPOCEmail.Name = "tbxPOCEmail";
            tbxPOCEmail.Size = new Size(245, 29);
            tbxPOCEmail.TabIndex = 19;
            // 
            // lblPOCEmail
            // 
            lblPOCEmail.AutoSize = true;
            lblPOCEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblPOCEmail.ForeColor = Color.FromArgb(  18,   47,   94);
            lblPOCEmail.Location = new Point(275, 242);
            lblPOCEmail.Name = "lblPOCEmail";
            lblPOCEmail.Size = new Size(114, 30);
            lblPOCEmail.TabIndex = 18;
            lblPOCEmail.Text = "POC Email";
            // 
            // tbxDeliveryPOCName
            // 
            tbxDeliveryPOCName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxDeliveryPOCName.Location = new Point(15, 275);
            tbxDeliveryPOCName.MaxLength = 55;
            tbxDeliveryPOCName.Name = "tbxDeliveryPOCName";
            tbxDeliveryPOCName.Size = new Size(245, 29);
            tbxDeliveryPOCName.TabIndex = 17;
            // 
            // lblDeliveryPOCName
            // 
            lblDeliveryPOCName.AutoSize = true;
            lblDeliveryPOCName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblDeliveryPOCName.ForeColor = Color.FromArgb(  18,   47,   94);
            lblDeliveryPOCName.Location = new Point(15, 242);
            lblDeliveryPOCName.Name = "lblDeliveryPOCName";
            lblDeliveryPOCName.Size = new Size(205, 30);
            lblDeliveryPOCName.TabIndex = 16;
            lblDeliveryPOCName.Text = "Delivery POC Name";
            // 
            // tbxDeliveryHours
            // 
            tbxDeliveryHours.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxDeliveryHours.Location = new Point(277, 340);
            tbxDeliveryHours.MaxLength = 55;
            tbxDeliveryHours.Name = "tbxDeliveryHours";
            tbxDeliveryHours.PlaceholderText = "HH:MM-HH:MM";
            tbxDeliveryHours.Size = new Size(245, 29);
            tbxDeliveryHours.TabIndex = 23;
            // 
            // lblDeliveryHours
            // 
            lblDeliveryHours.AutoSize = true;
            lblDeliveryHours.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblDeliveryHours.ForeColor = Color.FromArgb(  18,   47,   94);
            lblDeliveryHours.Location = new Point(275, 307);
            lblDeliveryHours.Name = "lblDeliveryHours";
            lblDeliveryHours.Size = new Size(255, 30);
            lblDeliveryHours.TabIndex = 22;
            lblDeliveryHours.Text = "Preferred Delivery Hours";
            // 
            // tbxPOCPhone
            // 
            tbxPOCPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxPOCPhone.Location = new Point(15, 340);
            tbxPOCPhone.MaxLength = 55;
            tbxPOCPhone.Name = "tbxPOCPhone";
            tbxPOCPhone.Size = new Size(245, 29);
            tbxPOCPhone.TabIndex = 21;
            // 
            // lblPOCPhone
            // 
            lblPOCPhone.AutoSize = true;
            lblPOCPhone.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblPOCPhone.ForeColor = Color.FromArgb(  18,   47,   94);
            lblPOCPhone.Location = new Point(15, 307);
            lblPOCPhone.Name = "lblPOCPhone";
            lblPOCPhone.Size = new Size(211, 30);
            lblPOCPhone.TabIndex = 20;
            lblPOCPhone.Text = "POC Phone Number";
            // 
            // rbnAddCust
            // 
            rbnAddCust.BackColor = Color.FromArgb(  46,   117,   182);
            rbnAddCust.FlatAppearance.BorderSize = 0;
            rbnAddCust.FlatStyle = FlatStyle.Flat;
            rbnAddCust.Font = new Font("Segoe UI", 12F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            rbnAddCust.ForeColor = Color.White;
            rbnAddCust.Location = new Point(225, 380);
            rbnAddCust.Name = "rbnAddCust";
            rbnAddCust.Size = new Size(100, 59);
            rbnAddCust.TabIndex = 24;
            rbnAddCust.Text = "Add\r\nCustomer\r\n";
            rbnAddCust.UseVisualStyleBackColor = false;
            rbnAddCust.Click += rbnAddCust_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Dock = DockStyle.Left;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point,  0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(0, 0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(55, 44);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(534, 447);
            Controls.Add(rbnAddCust);
            Controls.Add(tbxDeliveryHours);
            Controls.Add(lblDeliveryHours);
            Controls.Add(tbxPOCPhone);
            Controls.Add(lblPOCPhone);
            Controls.Add(tbxPOCEmail);
            Controls.Add(lblPOCEmail);
            Controls.Add(tbxDeliveryPOCName);
            Controls.Add(lblDeliveryPOCName);
            Controls.Add(tbxCustZip);
            Controls.Add(lblCustZip);
            Controls.Add(tbxCustState);
            Controls.Add(lblCustState);
            Controls.Add(tbxCustCity);
            Controls.Add(lblCustCity);
            Controls.Add(tbxCustStreet);
            Controls.Add(lblCustStreet);
            Controls.Add(tbxCustName);
            Controls.Add(lblCustName);
            Controls.Add(pnlMenu_AaddCust);
            MaximizeBox = false;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCustomer";
            pnlMenu_AaddCust.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddCust;
        private Panel pnlMenu_AaddCust;
        private TextBox tbxCustName;
        private Label lblCustName;
        private TextBox tbxCustStreet;
        private Label lblCustStreet;
        private TextBox tbxCustCity;
        private Label lblCustCity;
        private TextBox tbxCustZip;
        private Label lblCustZip;
        private TextBox tbxCustState;
        private Label lblCustState;
        private TextBox tbxPOCEmail;
        private Label lblPOCEmail;
        private TextBox tbxDeliveryPOCName;
        private Label lblDeliveryPOCName;
        private TextBox tbxDeliveryHours;
        private Label lblDeliveryHours;
        private TextBox tbxPOCPhone;
        private Label lblPOCPhone;
        private CustomControls.RoundedButton rbnAddCust;
        private Button btnBack;
    }
}