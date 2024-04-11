namespace MaU_CSharp5
{
    public class CustomerManager
    {
        private List<Customer> customers;

        public CustomerManager() 
        {
            customers = new List<Customer>();
        }

        public List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public Customer GetCustomer(int index)
        { 
            return customers[index];
        }
        public string GetEmail(int index)
        {
            return customers[index].Contact.Email.EmailBusiness;
        }
        public string GetPhone(int index)
        {
            return customers[index].Contact.Phone.CellPhone;
        }
    }
}
