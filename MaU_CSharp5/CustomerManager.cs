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
        public string[] GetFullName(int index)
        {
            string firstName = Customers[index].Contact.FirstName;
            string lastName = Customers[index].Contact.LastName;

            string[] fullName = [firstName, lastName];

            return fullName;
        }
        public string GetEmailBusiness(int index)
        {
            return Customers[index].Contact.Email.EmailBusiness;
        }
        public string GetPhoneOffice(int index)
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
