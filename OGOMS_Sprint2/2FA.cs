﻿namespace OGOMS_Sprint2 {
    public partial class _2FA : Form {

        //**Contructors**
        public _2FA() {
            InitializeComponent();
        }

        //**Event Handlers**
        private void btn2FAContinue_Click(object sender, EventArgs e) {
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
    }
}
