﻿using System.Diagnostics;

namespace OGOMS_Sprint2 {
    public partial class CustomerManagement : Form {

        List<Customer> customers;
        public CustomerManagement() {
            customers = new List<Customer>();
            InitializeComponent();
        }

        public CustomerManagement(List<Customer> customers) : this() {
            this.customers = customers;
            Debug.WriteLine(customers);
            SetDGVFromList(customers);

        }

        void SetDGVFromList(List<Customer> customers) {
            List<TableEntry> entries = new List<TableEntry>();
            foreach (Customer customer in customers) {
                entries.Add(new TableEntry(customer.name, customer.deliveryAddress, customer.custID));
            }
            dgvCustomerManagement.DataSource = entries;

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();


            btnCol.HeaderText = "";
            btnCol.Text = "Edit";
            btnCol.Name = "btnCol";
            btnCol.UseColumnTextForButtonValue = true;
            btnCol.FlatStyle = FlatStyle.Flat;
            //Needs work
            btnCol.DefaultCellStyle.BackColor = Color.FromArgb(255, 47, 85, 151);
            btnCol.DefaultCellStyle.ForeColor = Color.FromArgb(255, 47, 85, 151);


            dgvCustomerManagement.Columns.Add(btnCol);

            DataGridViewColumn col = dgvCustomerManagement.Columns[3];

            col.Width = 70;

        }

        private void btnHome_Click(object sender, EventArgs e) {
            Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();
        }

        struct TableEntry {
            public string Name { get; set; }
            public int CustomerID { get; set; }
            public string Address { get; set; }


            public TableEntry(string name, string address, int custID) {
                Name = name;
                Address = address;
                CustomerID = custID;

            }

        }
    }
}
