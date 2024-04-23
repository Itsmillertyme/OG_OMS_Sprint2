namespace OGOMS_Sprint2 {
    public class Employee {

        //**Fields**
        int _empID;
        string _firstName;
        string _lastName;
        string _email;
        string _username;
        string _password; //Will be a hash in final database
        string _salesRepID;

        //**Properties**
        public int EmpID { get => _empID; set => _empID = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string SalesRepID { get => _salesRepID; set => _salesRepID = value; }

        public Employee(int empID, string firstName, string lastName, string email, string username, string password, string salesRepID) {

            _empID = empID;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _username = username;
            _password = password;
            _salesRepID = salesRepID;

        }

        // ToString Override designed for testing purposes; Displays all attributes in a neat format. 
        public override string ToString() {
            return (_firstName + " " + _lastName + ":" + "\n  EmpID: " + _empID + "\n  Sale Rep ID: " + _salesRepID + "\n  Email: " + _email + "\n  Username: " + _username + "\n  Password: " + _password);
        }



    }
}
