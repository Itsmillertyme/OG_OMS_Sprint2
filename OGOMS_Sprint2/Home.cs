﻿namespace OGOMS_Sprint2 {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void rbnSubmitOrder_Click(object sender, EventArgs e) {

        }

        private void btnProfile_Click(object sender, EventArgs e) {
            //Testing sending a customer to profile constructor
            Profile profile = new Profile("Jacob Miller", "ItsMillerTyme", 12345, 1, "MyEmail@gmail.com");
            profile.ShowDialog();
        }

        private void rbnCustMng_Click(object sender, EventArgs e) {

            List<Customer> customers = new List<Customer> { new Customer("Buemi, Alease", "4 Webbs Chapel Rd", "12:00pm-4:00pm", 12345678, 12345),
                new Customer("Vanausdal, Jamal", "53075 Sw 152nd Ter #615", "8:00am-1:00pm", 87654321, 12345),
                new Customer("Greenbush, Shonda", "82 Us Highway 46", "8:00am-1:00pm", 87654321, 12345),
            new Customer("Gibes, Cory", "82 Us Highway 46", "6:00pm-2:00am", 98765432, 12345)};
            Hide();
            CustomerManagement customerManagement = new CustomerManagement(customers);
            customerManagement.ShowDialog();
            Close();
        }
    }
}
