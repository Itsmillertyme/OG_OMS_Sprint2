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

        private void rbnCustMng_Click(object sender, EventArgs e) {
            Hide();
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.ShowDialog();
            Close();

        }

        //**Utility Methods**

    }
}
