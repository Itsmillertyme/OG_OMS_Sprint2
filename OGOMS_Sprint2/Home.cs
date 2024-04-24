namespace OGOMS_Sprint2 {
    public partial class Home : Form {

        //**Constructors**
        public Home() {
            InitializeComponent();
        }

        //**Event Handlers**
        private void rbnSubmitOrder_Click(object sender, EventArgs e) {
            Hide();
            CreateNewOrder cno = new CreateNewOrder();
            if (WindowState == FormWindowState.Maximized) {
                cno.WindowState = FormWindowState.Maximized;
            }
            else {
                cno.Size = Size;
            }
            cno.ShowDialog();
            Close();
        }
        //
        private void btnProfile_Click(object sender, EventArgs e) {

            Profile profile = new Profile(Program.ActiveEmployee, this);
            profile.Show();
        }
        //
        private void rbnCustMng_Click(object sender, EventArgs e) {
            Hide();
            CustomerManagement customerManagement = new CustomerManagement();
            if (WindowState == FormWindowState.Maximized) {
                customerManagement.WindowState = FormWindowState.Maximized;
            }
            else {
                customerManagement.Size = Size;
            }
            customerManagement.ShowDialog();
            Close();

        }

    }
}
