namespace OGOMS_Sprint2 {
    public partial class AddCustomer : Form {
        public AddCustomer() {
            InitializeComponent();
        }

        //Event Handlers**
        private void rbnAddCust_Click(object sender, EventArgs e) {
            //Code to add customer to 'Database' File
            AppendCustomerToFile(CreateNewCustomer());

            Hide();

            //get reference to old 'Customermanagement' form
            CustomerManagement oldCM = (CustomerManagement) Application.OpenForms["CustomerManagement"];

            //create new form
            CustomerManagement newCM = new CustomerManagement();

            //window logic
            if (oldCM.WindowState == FormWindowState.Maximized) {
                newCM.WindowState = FormWindowState.Maximized;
            }
            else {
                newCM.Size = oldCM.Size;
            }

            oldCM.Hide();
            oldCM.Close();
            oldCM.Dispose();

            newCM.ShowDialog();
            Close();
        }
        //
        private void btnBack_Click(object sender, EventArgs e) {
            Hide();
            Close();
        }

        //**Utility Methods**
        private Customer CreateNewCustomer() {
            string[] names = tbxCustName.Text.Split(' ');
            string name = names[1] + ", " + names[0];

            string address = tbxCustStreet.Text + ", " + tbxCustCity.Text + ", " + tbxCustState.Text;

            string deliveryHours = FormatTimeString(dtpDeliveryStart.Value.TimeOfDay.ToString()) + "-" + FormatTimeString(dtpDeliveryEnd.Value.TimeOfDay.ToString());

            //Random for testing purposes
            int custID = new Random().Next(10000000, 99999999);

            string salesID = Program.ActiveEmployee.SalesRepID;

            Customer newCust = new Customer(name, address, deliveryHours, custID, salesID);

            return newCust;
        }
        //
        private void AppendCustomerToFile(Customer customer) {
            string filePath = "MasterCustomerList.txt";
            try {
                using (StreamWriter sw = new StreamWriter(filePath, true)) {
                    sw.WriteLine(customer.ToDatabaseFileEntry());
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //
        private string FormatTimeString(string timeString) {
            string output = "";

            string[] strings = timeString.Split(":");
            if (int.Parse(strings[0]) == 0) {

                output = 12 + ":" + strings[1] + "am";

            }
            else if (int.Parse(strings[0]) == 12) {
                output = 12 + ":" + strings[1] + "pm";
            }
            else if (int.Parse(strings[0]) > 12) {
                output = (int.Parse(strings[0]) - 12).ToString() + ":" + strings[1] + "pm";
            }
            else {
                output = int.Parse(strings[0]) + ":" + strings[1] + "am";
            }

            return output;
        }
    }
}
