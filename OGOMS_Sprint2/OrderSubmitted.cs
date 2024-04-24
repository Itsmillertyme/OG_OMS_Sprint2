namespace OGOMS_Sprint2 {
    public partial class OrderSubmitted : Form {

        //**Constructors**
        public OrderSubmitted() {
            InitializeComponent();
        }

        //**Event Handlers**
        private void btnHomeBig_Click(object sender, EventArgs e) {

            btnHome_Click(sender, e);
        }
        //
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
        private void btnProfile_Click(object sender, EventArgs e) {
            Profile profile = new Profile(Program.ActiveEmployee, this);
            profile.Show();
        }
    }
}
