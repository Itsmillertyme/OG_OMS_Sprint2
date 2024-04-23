﻿namespace OGOMS_Sprint2 {
    public partial class ReviewOrder : Form {

        //**Fields**
        string acctID;
        string salesID;
        string deliveryID;
        DateTime deliveryDate;

        //**Constructors**
        public ReviewOrder() {
            InitializeComponent();
        }
        //
        public ReviewOrder(string acctID, string salesID, string deliveryID, DateTime deliveryDate) {

            this.acctID = acctID;
            this.salesID = salesID;
            this.deliveryID = deliveryID;
            this.deliveryDate = deliveryDate;

            InitializeComponent();
        }

        //**Event Handlers**
        private void btnHome_Click(object sender, EventArgs e) {
            Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();
        }
        //        
        private void ReviewOrder_Load(object sender, EventArgs e) {
            InitOrderInfoDGV(acctID, salesID, deliveryID, deliveryDate);

            CreateNewOrder cno = (CreateNewOrder) Application.OpenForms["CreateNewOrder"];

            InitOrderCartDGV(cno.cartItems);

        }
        //
        private void dgvOrderInfo_SelectionChanged(object sender, EventArgs e) {
            dgvOrderInfo.ClearSelection();
        }
        //
        private void dgvOrderCart_SelectionChanged(object sender, EventArgs e) {
            dgvOrderCart.ClearSelection();
        }
        //
        private void rbnBack_Click(object sender, EventArgs e) {
            Hide();
            CreateNewOrder cno = (CreateNewOrder) Application.OpenForms["CreateNewOrder"];
            cno.Show();
            Close();
        }
        //
        private void rbnSubmit_Click(object sender, EventArgs e) {
            Hide();
            CreateNewOrder cno = (CreateNewOrder) Application.OpenForms["CreateNewOrder"];
            cno.Close();
            OrderSubmitted os = new OrderSubmitted();
            os.ShowDialog();
            Close();
        }

        //**Utility Methods**
        void InitOrderInfoDGV(string acctID, string salesID, string deliveryID, DateTime deliveryDate) {



            DataGridViewTextBoxColumn acctIDCol = new DataGridViewTextBoxColumn();
            acctIDCol.HeaderText = "Account ID";
            dgvOrderInfo.Columns.Add(acctIDCol);
            DataGridViewTextBoxColumn salesIDCol = new DataGridViewTextBoxColumn();
            salesIDCol.HeaderText = "Sales ID";
            dgvOrderInfo.Columns.Add(salesIDCol);
            DataGridViewTextBoxColumn deliveryIDCol = new DataGridViewTextBoxColumn();
            deliveryIDCol.HeaderText = "Delivery Rep ID";
            dgvOrderInfo.Columns.Add(deliveryIDCol);
            DataGridViewTextBoxColumn deliveryDateCol = new DataGridViewTextBoxColumn();
            deliveryDateCol.HeaderText = "Delivery Date";
            dgvOrderInfo.Columns.Add(deliveryDateCol);

            dgvOrderInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 47, 85, 151);
            dgvOrderInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrderInfo.EnableHeadersVisualStyles = false;

            string[] row = { acctID, salesID, deliveryID, deliveryDate.ToShortDateString() };

            dgvOrderInfo.Rows.Add(row);
            dgvOrderInfo.AllowUserToAddRows = false;
        }
        //
        void InitOrderCartDGV(List<InventoryItem> cartItems) {

            List<string[]> entries = new List<string[]>();

            foreach (InventoryItem item in cartItems) {

                bool prevEntry = false;

                for (int i = 0; i < entries.Count; i++) {
                    if (entries[i][0] == item.description) {
                        int quant = int.Parse(entries[i][2]) + 1;
                        entries[i][2] = quant.ToString();
                        prevEntry = true;
                        break;
                    }
                }
                if (!prevEntry) {
                    string[] entry = { item.description, item.brandName, "1", "" };

                    //formatting
                    int count = 0;
                    int tempID = item.productID;
                    while (tempID != 0) {
                        tempID = tempID / 10;
                        ++count;
                    }
                    if (count < 6) {
                        entry[3] = "0" + item.productID.ToString();
                    }
                    else {
                        entry[3] = item.productID.ToString();
                    }

                    entries.Add(entry);
                }
            }

            DataGridViewTextBoxColumn itemDescCol = new DataGridViewTextBoxColumn();
            itemDescCol.HeaderText = "Item Description";
            dgvOrderCart.Columns.Add(itemDescCol);
            DataGridViewTextBoxColumn brandCol = new DataGridViewTextBoxColumn();
            brandCol.HeaderText = "Brand Name";
            dgvOrderCart.Columns.Add(brandCol);
            DataGridViewTextBoxColumn QuantCol = new DataGridViewTextBoxColumn();
            QuantCol.HeaderText = "Quantity";
            dgvOrderCart.Columns.Add(QuantCol);
            DataGridViewTextBoxColumn prodIDCol = new DataGridViewTextBoxColumn();
            prodIDCol.HeaderText = "Product ID";
            dgvOrderCart.Columns.Add(prodIDCol);

            dgvOrderCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 47, 85, 151);
            dgvOrderCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrderCart.EnableHeadersVisualStyles = false;



            foreach (string[] entry in entries) {
                string[] row = { entry[0], entry[1], entry[2], entry[3] };

                dgvOrderCart.Rows.Add(row);

            }

            dgvOrderCart.AllowUserToAddRows = false;
        }

        //**Struct**
        struct OrderInfoEntry {
            public string acctID;
            public string salesID;
            public string deliveryID;
            public DateTime deliveryDate;

            public OrderInfoEntry(string acctID, string salesID, string deliveryID, DateTime deliveryDate) {
                this.acctID = acctID;
                this.salesID = salesID;
                this.deliveryID = deliveryID;
                this.deliveryDate = deliveryDate;
            }
        }
    }
}