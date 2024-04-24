namespace OGOMS_Sprint2 {
    public partial class CustomerManagement : Form {

        //**Fields**
        List<Customer> customers;
        string filePath;

        //**Contructors**
        public CustomerManagement() {
            customers = new List<Customer>();
            InitializeComponent();
        }
        //
        public CustomerManagement(List<Customer> customers) : this() {
            this.customers = customers;

        }

        //**Event Handlers**
        private void btnHome_Click(object sender, EventArgs e) {
            Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();

        }
        //
        private void rbnAddNewCust_Click(object sender, EventArgs e) {
            AddCustomer ac = new AddCustomer();
            ac.Show();
        }
        //
        private void dgvCustomerManagement_SelectionChanged(object sender, EventArgs e) {
            dgvCustomerManagement.ClearSelection();
        }
        //
        private void CustomerManagement_Load(object sender, EventArgs e) {

            string filePath = "MasterCustomerList.txt";

            customers = ReadCustomersFromFile(filePath);

            SetDGVFromList(GetEmployeeCustomers(Program.ActiveEmployee.SalesRepID));
        }

        //**Utility Methods**
        private void SetDGVFromList(List<Customer> customers) {
            List<TableEntry> entries = new List<TableEntry>();
            foreach (Customer customer in customers) {
                entries.Add(new TableEntry(customer.Name, customer.DeliveryAddress, customer.CustID));
            }
            dgvCustomerManagement.DataSource = entries;

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();


            btnCol.HeaderText = "";
            btnCol.Text = "Edit";
            btnCol.Name = "btnCol";
            btnCol.UseColumnTextForButtonValue = true;
            btnCol.FlatStyle = FlatStyle.Flat;
            //Needs work
            btnCol.DefaultCellStyle.BackColor = Color.FromArgb(255, 47, 85, 151);
            btnCol.DefaultCellStyle.ForeColor = Color.FromArgb(255, 47, 85, 151);


            dgvCustomerManagement.Columns.Add(btnCol);

            DataGridViewColumn col = dgvCustomerManagement.Columns[3];

            col.Width = 70;

        }
        //
        public static List<Customer> ReadCustomersFromFile(string filePath) {

            List<Customer> customers = new List<Customer>();
            try {
                using (StreamReader sr = new StreamReader(filePath)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        // Split the line by comma
                        string[] data = line.Split(", ");

                        // Extract fields for creating Customer
                        string fullName = data[0] + ", " + data[1];
                        string address = data[2] + ", " + data[3] + ", " + data[4];
                        string preferredDeliveryHours = data[5];
                        int customerId = int.Parse(data[6]);
                        string salesRepId = data[7];

                        // Create Customer and add to customers list
                        customers.Add(new Customer(fullName, address, preferredDeliveryHours, customerId, salesRepId));
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            return customers;

        }
        //
        public static List<Customer> GetEmployeeCustomers(string salesRepID) {
            List<Customer> validCustomers = new List<Customer>();

            foreach (Customer customer in ReadCustomersFromFile("MasterCustomerList.txt")) {
                if (customer.SalesRepID.Equals(salesRepID)) {
                    validCustomers.Add(customer);
                }
            }

            return validCustomers;

        }

        //**Struct**
        struct TableEntry {
            public string Name { get; set; }
            public int CustomerID { get; set; }
            public string Address { get; set; }


            public TableEntry(string name, string address, int custID) {
                Name = name;
                Address = address;
                CustomerID = custID;

            }

        }
    }
}
