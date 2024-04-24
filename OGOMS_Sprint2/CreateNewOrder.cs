using System.Diagnostics;

namespace OGOMS_Sprint2 {
    public partial class CreateNewOrder : Form {

        //**Fields**
        public List<InventoryItem> cartItems { get; } = new List<InventoryItem>();
        List<InventoryItem> fullProductList = new List<InventoryItem>();
        List<InventoryItem> currentProductList = new List<InventoryItem>();

        List<Customer> customerList = new List<Customer>();

        public CreateNewOrder() {
            InitializeComponent();
        }

        //**Event Handlers*
        private void CreateNewOrder_Load(object sender, EventArgs e) {

            // Initialize productList
            fullProductList = new List<InventoryItem>();

            //Initialize customers for employee
            customerList = CustomerManagement.GetEmployeeCustomers(Program.ActiveEmployee.SalesRepID);

            // Initialize some form controls
            tbxSalesID.Text = Program.ActiveEmployee.SalesRepID;
            tbxDeliveryID.Text = "JohnsonT_223451"; //hardcoded for prototype  
            Debug.WriteLine(customerList.Count);
            foreach (Customer customer in customerList) {
                cbxCustAccounts.Items.Add(customer.Name + "; " + customer.CustID);
            }


            // Read data from the file and populate productList
            string filePath = "MasterProductList.txt";
            try {
                using (StreamReader sr = new StreamReader(filePath)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        // Split the line by comma
                        string[] data = line.Split(',');

                        // Extract required fields for creating InventoryItem
                        int productId = int.Parse(data[1]);
                        int onHand = int.Parse(data[11]);
                        string itemDescription = data[2];
                        string supplierName = data[3];
                        string brandName = data[4];

                        // Create InventoryItem and add to productList
                        fullProductList.Add(new InventoryItem(productId, onHand, 0, itemDescription, supplierName, brandName));
                    }
                }

                currentProductList = fullProductList;

                // Initialize product DataGridView
                UpdateProductDGV(currentProductList);
            }
            catch (Exception ex) {
                // Handle exception, maybe show error message
                MessageBox.Show("Error reading file: " + ex.Message);
            }
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
            if (WindowState == FormWindowState.Maximized) {
                home.WindowState = FormWindowState.Maximized;
            }
            else {
                home.Size = Size;
            }
            home.ShowDialog();
            Close();

        }
        //
        private void btnProfile_Click(object sender, EventArgs e) {
            Profile profile = new Profile(Program.ActiveEmployee, this);
            profile.Show();
        }
        //
        private void dgvItemSearch_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 0) {
                cartItems.Add(currentProductList[e.RowIndex]);

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

            //ensure customer account is selected
            if (cbxCustAccounts.SelectedIndex == -1) {
                return;
            }

            Hide();
            ReviewOrder ro = new ReviewOrder(customerList[cbxCustAccounts.SelectedIndex].CustID.ToString(), tbxSalesID.Text, tbxDeliveryID.Text, dtpDeliveryDate.Value);
            if (WindowState == FormWindowState.Maximized) {
                ro.WindowState = FormWindowState.Maximized;
            }
            else {
                ro.Size = Size;
            }
            ro.ShowDialog();
            Close();
            //Close this form after order submission
        }
        //
        private void tbxItemSearch_TextChanged(object sender, EventArgs e) {

            if (tbxItemSearch.Text == "") {
                currentProductList = fullProductList;

                UpdateProductDGV(currentProductList);
            }
            else {
                //make new list that is filtered
                List<InventoryItem> filteredItems = new List<InventoryItem>();

                //loop through each item in product list
                foreach (InventoryItem item in fullProductList) {
                    //test if item description contains search string
                    Debug.WriteLine("testing: " + item.description + ", against " + tbxItemSearch.Text);

                    //Debug.WriteLine();
                    if (item.description.Contains(tbxItemSearch.Text.ToUpper())) {
                        Debug.WriteLine("item desc contains: " + tbxItemSearch.Text);
                        filteredItems.Add(item);
                    }
                }

                currentProductList = filteredItems;
                UpdateProductDGV(currentProductList);

            }

        }

        //**Utility Methods**
        void UpdateProductDGV(List<InventoryItem> items) {
            dgvItemSearch.DataSource = null;
            dgvItemSearch.Columns.Clear();
            dgvItemSearch.Rows.Clear();
            dgvItemSearch.Refresh();

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
        //
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
