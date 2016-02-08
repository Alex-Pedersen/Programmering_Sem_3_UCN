namespace ConsoleApplication1
{

    class Customer
    {
        public string fName, lName;

        public Customer(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string printCustomer(Customer customer)
        {
            return string.Format("Customer first and last name : {0} {1}", customer.fName, customer.lName);
        }
    }
}
