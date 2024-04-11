using MaU_CSharp5.ContactFiles;

namespace MaU_CSharp5
{
    public class Customer
    {
        private Contact contact;

        public Customer(string firstName, string lastName, Address address, Email email, Phone phone) 
        {
            Contact = new Contact(firstName, lastName, address, email, phone);
        }

        public Contact Contact
        { 
            get { return contact; } 
            set { contact = value; }
        }
    }
}
