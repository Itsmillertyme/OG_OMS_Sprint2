namespace OGOMS_Sprint2 {

    public class Customer {

        string _name;
        string _deliveryAddress;
        string _deliveryHours;
        int _custID;
        int _salesRepID;

        public string name { get; set; }
        public string deliveryAddress { get; set; }
        public string deliveryHours { get; set; }
        public int custID { get; set; }
        public int salesRepID { get; set; }

        public Customer(string name, string deliverAddress, string deliveryHours, int custID, int salesRepID) {

            this.name = name;
            this.deliveryAddress = deliverAddress;
            this.deliveryHours = deliveryHours;
            this.custID = custID;
            this.salesRepID = salesRepID;

        }



    }
}
