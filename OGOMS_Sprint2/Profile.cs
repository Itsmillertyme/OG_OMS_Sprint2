namespace OGOMS_Sprint2 {
    public partial class Profile : Form {

        string empName;
        string empUsername;
        string empSalesID;
        int empSalesZone;
        string empEmail;
        //
        Form prevForm;

        public Profile() {
            InitializeComponent();
        }

        public Profile(Employee loggedInEmp, Form prevForm) {

            InitializeComponent();
            this.empName = loggedInEmp.FirstName + " " + loggedInEmp.LastName;
            this.empUsername = loggedInEmp.Username;
            this.empSalesID = loggedInEmp.SalesRepID;
            this.empSalesZone = new Random().Next(1, 100);
            this.empEmail = loggedInEmp.Email;
            this.prevForm = prevForm;

            UpdateLabels();

        }

        //**Event Handlers**
        private void btnSignOut_Click(object sender, EventArgs e) {
            //hide profile form
            Hide();

            //get reference to 'home' form
            //Home home = (Home) Application.OpenForms["Home"];

            Login newLogin = new Login();

            if (prevForm.WindowState == FormWindowState.Maximized) {
                newLogin.WindowState = FormWindowState.Maximized;
            }
            else {
                newLogin.Size = prevForm.Size;
            }

            prevForm.Hide();
            prevForm.Close();
            prevForm.Dispose();

            newLogin.ShowDialog();

            Close();




        }
        //
        private void btnBack_Click(object sender, EventArgs e) {

            Hide();
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
