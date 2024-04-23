namespace OGOMS_Sprint2 {
    public partial class OrderSubmitted : Form {
        public OrderSubmitted() {
            InitializeComponent();
        }

        private void btnHomeBig_Click(object sender, EventArgs e) {

            btnHome_Click(sender, e);
        }

        private void btnHome_Click(object sender, EventArgs e) {
            Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e) {
            Hide();
            Profile profile = new Profile();
            profile.ShowDialog();
            Close();
        }
    }
}
