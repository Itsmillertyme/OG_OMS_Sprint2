namespace OGOMS_Sprint2 {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        //**Event Handlers**
        private void rbnSubmitOrder_Click(object sender, EventArgs e) {
            Hide();
            CreateNewOrder cno = new CreateNewOrder();
            cno.ShowDialog();
            Close();
        }
        //
        private void btnProfile_Click(object sender, EventArgs e) {
            //Testing sending a customer to profile constructor
            Profile profile = new Profile(Program.ActiveEmployee);
            profile.Show();
        }
        //
        private List<Customer> ReadCustomersFromFile(string filePath)
        {
            List<Customer> customers = new List<Customer>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Split the line by comma
                    string[] data = line.Split(',');

                    // Extract fields for creating Customer
                    string fullName = data[0] + ", " + data[1];
                    string address = data[2] + ", " + data[3] + ", " + data[4];
                    string preferredDeliveryHours = data[5];
                    int customerId = int.Parse(data[6]);
                    int salesRepId = int.Parse(data[7]);

                    // Create Customer and add to customers list
                    customers.Add(new Customer(fullName, address, preferredDeliveryHours, customerId, salesRepId));
                }
            }

            return customers;
        }
        //
        private void rbnCustMng_Click(object sender, EventArgs e)
        {
            // Read data from the file and populate customers
            string filePath = "MasterCustomerList.txt";
            try
            {
                List<Customer> customers = ReadCustomersFromFile(filePath);

                //Hide();
                CustomerManagement customerManagement = new CustomerManagement(customers);
                customerManagement.ShowDialog();
                //Close();
            }
            catch (Exception ex)
            {
                // Handle exception, maybe show error message
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }
    }
}
