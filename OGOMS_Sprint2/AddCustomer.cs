namespace OGOMS_Sprint2 {
    public partial class AddCustomer : Form {
        public AddCustomer() {
            InitializeComponent();
        }

        //Event Handlers**
        private void rbnAddCust_Click(object sender, EventArgs e) {
            //Code to add customer to 'Database' File

            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Show();
        }
        //
        private void btnBack_Click(object sender, EventArgs e) {
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Show();
        }
    }
}
