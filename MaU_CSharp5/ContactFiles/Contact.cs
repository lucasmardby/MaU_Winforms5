namespace MaU_CSharp5.ContactFiles
{
    internal class Contact
    {
        private string firstName;
        private string lastName;
        private Address address;
        private Email email;
        private Phone phone;

        public string FirstName
        { 
            get 
            { 
                return firstName;
            } 
            set 
            {  
                firstName = value;
            } 
        }
        public string LastName 
        { 
            get 
            { 
                return lastName;
            } 
            set 
            { 
                lastName = value;
            } 
        }
        public Address Address
        {
            get 
            { 
                return address;
            }
            set
            { 
                address = value;
            }
        }
        public Email Email
        { 
            get 
            {
                return email;
            }
            set 
            { 
                email = value;
            }
        }
        public Phone Phone
        { 
            get 
            { 
                return phone;
            }
            set 
            { 
                phone = value;
            }
        }

        public Contact()
        {

        }
        public Contact(string firstName, string lastName, Address address, Email email, Phone phone)
        {
            firstName = FirstName;
            lastName = LastName;
            address = Address;
            email = Email;
            phone = Phone;
        }

    }
}
