namespace OGOMS_Sprint2 {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void btnLoginContinue_Click(object sender, EventArgs e) {
            Hide();
            _2FA _2fa = new _2FA();
            _2fa.ShowDialog();
            Close();
        }

        private void Login_Load(object sender, EventArgs e) {

        }

    }
}
