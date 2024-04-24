namespace OGOMS_Sprint2 {
    public partial class Login : Form {

        //**Variables**
        string filePath = "MasterEmployeeList.txt";
        List<Employee> employees = new List<Employee>();

        //**Constructors**
        public Login() {
            InitializeComponent();

            //hide error message
            lblError.Visible = false;
        }

        //**Event Handlers**
        private void btnLoginContinue_Click(object sender, EventArgs e) {

            //test credentials
            Employee potentialEmp = ValidateCredentials();
            if (potentialEmp != null) {

                //set global
                Program.ActiveEmployee = potentialEmp;

                //change forms
                Hide();
                _2FA _2fa = new _2FA();
                _2fa.ShowDialog();
                Close();
            }
            else {
                //flash error message
                lblError.Visible = true;
                wait(1000);
                lblError.Visible = false;

            }


        }
        //
        private void Login_Load(object sender, EventArgs e) {

            //"log out" flag
            Program.EmployeeLoggedIn = false;

            //load employee data from file
            try {
                using (StreamReader sr = new StreamReader(filePath)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        // Split the line by comma
                        string[] data = line.Split(',');
                        // Create Employee object and add to list
                        employees.Add(new Employee(int.Parse(data[0]), data[1], data[2], data[3], data[4], data[5], data[6]));
                    }
                }

                //DEV ONLY
                //foreach (Employee employee in employees) {
                //    Debug.WriteLine(employee);
                //}

            }
            catch (Exception ex) {
                // Handle exception, maybe show error message
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        //**Utility Methods**
        private Employee ValidateCredentials() {

            //grab text box text
            string username = tbxUserName.Text;
            string password = tbxPassword.Text;

            //loop through every employee
            foreach (Employee emp in employees) {
                //test username and password for match
                if (username == emp.Username && password == emp.Password) {
                    //return the employee
                    return emp;
                }
            }

            return null;
        }
        //
        private void wait(int milliseconds) {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) => {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled) {
                Application.DoEvents();
            }
        }
    }
}
