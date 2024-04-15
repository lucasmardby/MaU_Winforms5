namespace MaU_CSharp5
{
    /// <summary>
    /// Customer Manager class, creating a List of Customers to be saved
    /// </summary>
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
        /// <summary>
        /// Adds a new customer
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        /// <summary>
        /// Gets a customer at the given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Customer</returns>
        public Customer GetCustomer(int index)
        { 
            return Customers[index];
        }
        /// <summary>
        /// Gets the first and last name of a customer at the given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>A string array with the two names</returns>
        public string[] GetFullName(int index)
        {
            string firstName = Customers[index].Contact.FirstName;
            string lastName = Customers[index].Contact.LastName;

            string[] fullName = [firstName, lastName];

            return fullName;
        }
        /// <summary>
        /// Gets the business email for the MainForm listbox, of the customer at the selected index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Business email</returns>
        public string GetEmailBusiness(int index)
        {
            return Customers[index].Contact.Email.EmailBusiness;
        }
        /// <summary>
        /// Gets the office phone for the MainForm listbox, of the customer at the selected index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Office cellphone</returns>
        public string GetPhoneOffice(int index)
        {
            return Customers[index].Contact.Phone.CellPhone;
        }
        /// <summary>
        /// Changes the selected customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="index"></param>
        public void ChangeCustomer(Customer customer, int index)
        {
            customers[index] = customer;
        }
        /// <summary>
        /// Deletes the selected customer
        /// </summary>
        /// <param name="index"></param>
        public void DeleteCustomer(int index)
        {
            Customers.Remove(GetCustomer(index));
        }
    }
}
