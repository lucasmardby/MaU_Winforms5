namespace MaU_CSharp5
{
    internal class CustomerManager
    {
        List<Customer> customers;

        public CustomerManager() 
        {
            customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
    }
}
