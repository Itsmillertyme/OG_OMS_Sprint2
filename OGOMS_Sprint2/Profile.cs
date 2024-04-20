namespace OGOMS_Sprint2 {
    public partial class Profile : Form {

        string empName;
        string empUsername;
        int empSalesID;
        int empSalesZone;
        string empEmail;

        public Profile() {
            InitializeComponent();
        }

        public Profile(string empName, string empUsername, int empSalesID, int empSalesZone, string empEmail) {

            InitializeComponent();
            this.empName = empName;
            this.empUsername = empUsername;
            this.empSalesID = empSalesID;
            this.empSalesZone = empSalesZone;
            this.empEmail = empEmail;

            UpdateLabels();

        }

        private void btnSignOut_Click(object sender, EventArgs e) {
            //hide profile form
            Hide();

            //get reference to 'home' form
            Home home = (Home) Application.OpenForms["Home"];
            //close home form
            home.Close();

            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private void UpdateLabels() {
            lblProfileName.Text = empName;
            lblUsername_Display.Text = empUsername;
            lblSalesID_Display.Text = empSalesID.ToString();
            lblSalesZone_Display.Text = empSalesZone.ToString();
            lblEmail_Display.Text = empEmail;
        }
    }
}
