﻿using System.Diagnostics;

namespace OGOMS_Sprint2 {
    public partial class CreateNewOrder : Form {

        //**Fields**
        public List<InventoryItem> cartItems { get; } = new List<InventoryItem>();
        List<InventoryItem> productList = new List<InventoryItem>();

        public CreateNewOrder() {
            InitializeComponent();
        }

        //**Event Handlers*
        private void CreateNewOrder_Load(object sender, EventArgs e) {

            //TESTING DATA
            //productList = new List<InventoryItem> {
            //    new InventoryItem(061010,197,0,"3D BLUE 12/16 CAN", "3D ENERGY", "3D ENERGY"),
            //    new InventoryItem(061014,138,0,"3D PURPLE 12/16 CAN", "3D ENERGY","3D ENERGY"),
            //    new InventoryItem(301995,208,0,"6/750  80 PROOF BLUELAVA TEQ", "80 PROOF IMPORTS", "80 PROOF IMPORTS"),
            //    new InventoryItem(060098,0,0,"AE WITCHSBREW 4/6C", "ALANI", "ALANI ENERGY"),
            //    new InventoryItem(060099,0,0,"AE KIMADE 4/6C", "ALANI","ALANI ENERGY"),
            //    new InventoryItem(061000,141,1,"AE BLUE SLUSH 4/6 CAN", "ALANI", "ALANI ENERGY")
            //};

            //Create product reader
            ProductReader reader = new ProductReader();
            productList = reader.GetInventory();

            InitProductDGV(productList);
        }
        //
        private void dgvItemSearch_SelectionChanged(object sender, EventArgs e) {

            dgvItemSearch.ClearSelection();

        }
        //
        private void dgvCart_SelectionChanged(object sender, EventArgs e) {
            dgvCart.ClearSelection();
        }
        //
        private void btnHome_Click(object sender, EventArgs e) {
            Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();

        }
        //
        private void btnProfile_Click(object sender, EventArgs e) {
            Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
            Close();
        }
        //
        private void dgvItemSearch_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 0) {
                cartItems.Add(productList[e.RowIndex]);

                //foreach (InventoryItem item in cartItems) {
                //    Debug.WriteLine(item);
                //}

                UpdateCartDGV(cartItems);
            }
        }
        //
        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e) {
            Debug.WriteLine("Cart cell clicked");

            if (e.ColumnIndex == 3) {
                Debug.WriteLine("button clicked");
                cartItems.RemoveAt(e.RowIndex);

                UpdateCartDGV(cartItems);

            }
        }
        //
        private void rbnSubmit_Click(object sender, EventArgs e) {
            Hide();
            ReviewOrder ro = new ReviewOrder(tbxAcctID.Text, tbxSalesID.Text, tbxDeliveryID.Text, dtpDeliveryDate.Value);
            ro.ShowDialog();
            Close();
            //Close this form after order submission
        }

        //**Utility Methods**
        void InitProductDGV(List<InventoryItem> items) {
            List<ProductTableEntry> entries = new List<ProductTableEntry>();

            foreach (InventoryItem item in items) {
                entries.Add(new ProductTableEntry(item.description, item.brandName, item.productID));
            }

            dgvItemSearch.DataSource = entries;

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();


            btnCol.HeaderText = "";
            btnCol.Text = "Add";
            btnCol.Name = "btnCol";
            btnCol.UseColumnTextForButtonValue = true;
            btnCol.FlatStyle = FlatStyle.Flat;
            //Needs work
            btnCol.DefaultCellStyle.BackColor = Color.White;
            btnCol.DefaultCellStyle.ForeColor = Color.FromArgb(255, 47, 85, 151);


            dgvItemSearch.Columns.Insert(0, btnCol);

            DataGridViewColumn col = dgvItemSearch.Columns[0];
            col.Width = 40;
            col = dgvItemSearch.Columns[3];
            col.Width = 70;

        }

        void UpdateCartDGV(List<InventoryItem> cartItems) {

            dgvCart.DataSource = null;
            dgvCart.Columns.Clear();
            dgvCart.Rows.Clear();
            dgvCart.Refresh();

            List<CartTableEntry> entries = new List<CartTableEntry>();

            foreach (InventoryItem item in cartItems) {

                bool prevEntry = false;

                for (int i = 0; i < entries.Count; i++) {
                    if (int.Parse(entries[i].productID) == item.productID) {

                        CartTableEntry tempEntry = entries[i];
                        tempEntry.quantity++;
                        entries[i] = tempEntry;
                        prevEntry = true;
                        break;
                    }
                }
                if (!prevEntry) {
                    entries.Add(new CartTableEntry(item.description, 1, item.productID));
                }
            }


            dgvCart.DataSource = entries;

            if (dgvCart.Columns.Count < 4) {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();

                btnCol.HeaderText = "";
                btnCol.Text = "Remove";
                btnCol.Name = "btnCol";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.FlatStyle = FlatStyle.Flat;

                btnCol.DefaultCellStyle.BackColor = Color.White;
                btnCol.DefaultCellStyle.ForeColor = Color.FromArgb(255, 47, 85, 151);


                dgvCart.Columns.Insert(3, btnCol);

                DataGridViewColumn col = dgvCart.Columns[0];
                col.Width = 200;
                col = dgvCart.Columns[2];
                col.Width = 65;
                col = dgvCart.Columns[3];
                col.Width = 70;
            }

            DataGridViewTextBoxColumn tbCol = (DataGridViewTextBoxColumn) dgvCart.Columns[0];
            tbCol.HeaderText = "Item Description";
            tbCol = (DataGridViewTextBoxColumn) dgvCart.Columns[1];
            tbCol.HeaderText = "Product ID";
            tbCol = (DataGridViewTextBoxColumn) dgvCart.Columns[2];
            tbCol.HeaderText = "Quantity";


        }

        private void tbxItemSearch_TextChanged(object sender, EventArgs e) {

            if (tbxItemSearch.Text == "") {
                dgvItemSearch.DataSource = productList;
            }
            else {
                //make new list that is filtered
                List<InventoryItem> filteredItems = new List<InventoryItem>();

                //loop through each item in product list
                foreach (InventoryItem item in productList) {
                    //test if item description contains search string
                    if (item.description.Contains(tbxItemSearch.Text)) {
                        filteredItems.Add(item);
                    }
                }
                dgvItemSearch.DataSource = filteredItems;

            }

        }



        //**Structs**
        struct ProductTableEntry {
            public string productDesc { get; set; }
            public string brand { get; set; }
            public string productID { get; set; }

            public ProductTableEntry(string productDesc, string brand, int productID) {
                this.productDesc = productDesc;
                this.brand = brand;

                //formatting
                int count = 0;
                int temp = productID;
                while (temp != 0) {
                    temp = temp / 10;
                    ++count;
                }
                if (count < 6) {
                    this.productID = "0" + productID.ToString();
                }
                else {
                    this.productID = productID.ToString();
                }

            }

        }
        struct CartTableEntry {
            public string productDesc { get; set; }
            public string productID { get; set; }
            public int quantity { get; set; }

            public CartTableEntry(string productDesc, int quantity, int productID) {
                this.productDesc = productDesc;
                this.quantity = quantity;

                //formatting
                int count = 0;
                int temp = productID;
                while (temp != 0) {
                    temp = temp / 10;
                    ++count;
                }
                if (count < 6) {
                    this.productID = "0" + productID.ToString();
                }
                else {
                    this.productID = productID.ToString();
                }

            }

            public void IncrementQuant() {
                Debug.WriteLine("Quantity increased");
                quantity++;
            }

        }
    }





}
