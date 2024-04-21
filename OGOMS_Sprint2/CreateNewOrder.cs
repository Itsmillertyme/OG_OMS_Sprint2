namespace OGOMS_Sprint2 {
    public partial class CreateNewOrder : Form {
        public CreateNewOrder() {
            InitializeComponent();
        }

        void InitProductDGV(List<InventoryItem> items) {
            List<ProductTableEntry> entries = new List<ProductTableEntry>();

            foreach (InventoryItem item in items) {
                entries.Add(new ProductTableEntry(item.description, item.supplierName, item.productID));
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

        private void CreateNewOrder_Load(object sender, EventArgs e) {
            //for testing, will load items from file
            InitProductDGV(new List<InventoryItem> {
                new InventoryItem(061010,197,0,"3D BLUE 12/16 CAN", "3D ENERGY", "3D ENERGY",17.99),
                new InventoryItem(061014,138,0,"3D PURPLE 12/16 CAN", "3D ENERGY","3D ENERGY",27.99),
                new InventoryItem(301995,208,0,"6/750  80 PROOF BLUELAVA TEQ", "80 PROOF IMPORTS", "80 PROOF IMPORTS",14.87),
                new InventoryItem(060098,0,0,"AE WITCHSBREW 4/6C", "ALANI", "ALANI ENERGY",32.99),
                new InventoryItem(060099,0,0,"AE KIMADE 4/6C", "ALANI","ALANI ENERGY",16.98),
                new InventoryItem(061000,141,1,"AE BLUE SLUSH 4/6 CAN", "ALANI", "ALANI ENERGY",19.99)
            });
        }

        private void dgvItemSearch_SelectionChanged(object sender, EventArgs e) {
            dgvItemSearch.ClearSelection();
        }

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
    }





}
