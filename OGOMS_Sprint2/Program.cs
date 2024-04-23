namespace OGOMS_Sprint2 {
    internal static class Program {

        //**Fields**
        static Employee activeEmployee;
        static bool employeeLoggedIn;

        //**Properties**
        public static Employee ActiveEmployee { get => activeEmployee; set => activeEmployee = value; }
        public static bool EmployeeLoggedIn { get => employeeLoggedIn; set => employeeLoggedIn = value; }



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            //Initialize global variables
            employeeLoggedIn = false;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}