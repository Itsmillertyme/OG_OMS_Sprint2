namespace OGOMS_Sprint2 {

    public class Customer {

        //Fields**
        string _name;
        string _deliveryAddress;
        string _deliveryHours;
        int _custID;
        string _salesRepID;

        //**Properties**
        public string Name { get => _name; set => _name = value; }
        public string DeliveryAddress { get => _deliveryAddress; set => _deliveryAddress = value; }
        public string DeliveryHours { get => _deliveryHours; set => _deliveryHours = value; }
        public int CustID { get => _custID; set => _custID = value; }
        public string SalesRepID { get => _salesRepID; set => _salesRepID = value; }

        //**Constructors**
        public Customer(string name, string deliverAddress, string deliveryHours, int custID, string salesRepID) {

            this.Name = name;
            this.DeliveryAddress = deliverAddress;
            this.DeliveryHours = deliveryHours;
            this.CustID = custID;
            this.SalesRepID = salesRepID;

        }

        public string ToDatabaseFileEntry() {

            return _name + ", " + _deliveryAddress + ", " + _deliveryHours + ", " + _custID + ", " + _salesRepID;

        }

    }
}
