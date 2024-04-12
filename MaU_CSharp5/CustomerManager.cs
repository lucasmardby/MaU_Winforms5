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
            Customers.Add(customer);
        }
        public Customer GetCustomer(int index)
        { 
            return Customers[index];
        }
        public string GetEmail(int index)
        {
            return Customers[index].Contact.Email.EmailBusiness;
        }
        public string GetPhone(int index)
        {
            return Customers[index].Contact.Phone.CellPhone;
        }
        public void ChangeCustomer(Customer customer, int index)
        {
            customers[index] = customer;
        }

        public void DeleteCustomer(int index)
        {
            Customers.Remove(GetCustomer(index));
        }
    }
}
