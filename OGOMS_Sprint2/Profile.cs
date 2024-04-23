namespace OGOMS_Sprint2 {
    public partial class Profile : Form {

        string empName;
        string empUsername;
        string empSalesID;
        int empSalesZone;
        string empEmail;

        public Profile() {
            InitializeComponent();
        }

        public Profile(Employee loggedInEmp) {

            InitializeComponent();
            this.empName = loggedInEmp.FirstName + " " + loggedInEmp.LastName;
            this.empUsername = loggedInEmp.Username;
            this.empSalesID = loggedInEmp.SalesRepID;
            this.empSalesZone = new Random().Next(1, 100);
            this.empEmail = loggedInEmp.Email;

            UpdateLabels();

        }

        //**Event Handlers**
        private void btnSignOut_Click(object sender, EventArgs e) {
            //hide profile form
            Hide();

            Login newLogin = new Login();
            newLogin.ShowDialog();

            //get reference to 'home' form
            //Home home = (Home) Application.OpenForms["Home"];
            for (int i = 0; i < Application.OpenForms.Count; i++) {

                if (Application.OpenForms[i].Name != "Profile") {
                    Application.OpenForms[i].Close();
                    Application.OpenForms[i].Dispose();
                }
            }

        }
        //
        private void btnBack_Click(object sender, EventArgs e) {

            Hide();
            Home home = new Home();
            home.Show();
            Close();
        }

        //**Utility Methods**
        private void UpdateLabels() {
            lblProfileName.Text = empName;
            lblUsername_Display.Text = empUsername;
            lblSalesID_Display.Text = empSalesID.ToString();
            lblSalesZone_Display.Text = empSalesZone.ToString();
            lblEmail_Display.Text = empEmail;
        }
    }
}
