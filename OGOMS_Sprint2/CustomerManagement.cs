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

        //**Event Handlers**
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
        //
        private void btnProfile_Click(object sender, EventArgs e) {
            Profile profile = new Profile(Program.ActiveEmployee, this);
            profile.Show();
        }

        //**Utility Methods**
        /// <summary>
        /// Updates the Customer Data Grid View from a given list
        /// </summary>
        /// <param name="customers">List of Customer objects</param>
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
        /// <summary>
        /// Reads in customer information from 'database' file
        /// </summary>
        /// <param name="filePath">File path to file</param>
        /// <returns>List of Customer objects</returns>
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
        /// <summary>
        /// Creates a list of customers that are assigned to a sales employee given a Sales Rep ID
        /// </summary>
        /// <param name="salesRepID">Sales Rep ID</param>
        /// <returns>List of customer objects</returns>
        public static List<Customer> GetEmployeeCustomers(string salesRepID) {
            List<Customer> validCustomers = new List<Customer>();

            foreach (Customer customer in ReadCustomersFromFile("MasterCustomerList.txt")) {
                if (customer.SalesRepID.Equals(salesRepID)) {
                    validCustomers.Add(customer);
                }
            }

            return validCustomers;

        }


        /// <summary>
        /// Struct representing a Customer entry in the data grid view
        /// </summary>
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
