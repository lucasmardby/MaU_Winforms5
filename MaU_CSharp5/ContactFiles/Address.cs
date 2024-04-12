namespace MaU_CSharp5.ContactFiles
{
    public class Address
    {
        private string city;
        private Countries country;
        private string street;
        private string zipCode;

        public Address(string city, Countries country) : this(city, country, "Unknown")
        { 
            
        }
        public Address(string city, Countries country, string street) : this(city, country, street, "000 00")
        {

        }
        public Address(string city, Countries country, string street, string zipCode)
        {
            City = city;
            Country = country;
            Street = street;
            ZipCode = zipCode;
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
        public Countries Country
        { 
            get { return country; } 
            set { country = value; }
        }

    }
}
