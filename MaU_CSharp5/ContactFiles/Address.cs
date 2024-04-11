namespace MaU_CSharp5.ContactFiles
{
    public class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        public Address()
        { 
            
        }

        public string Street
        { 
            get { return street; }
            set { street = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public Countries Countries
        { 
            get { return country; } 
            set { country = value; }
        }

    }
}
