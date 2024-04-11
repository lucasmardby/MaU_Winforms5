namespace MaU_CSharp5.ContactFiles
{
    public class Phone
    {
        private string homePhone;
        private string cellPhone;

        public Phone(string homePhone, string cellPhone)
        { 
            HomePhone = homePhone;
            CellPhone = cellPhone;
        }

        public string HomePhone
        { 
            get { return homePhone; }
            set { homePhone = value; }
        }
        public string CellPhone
        {
            get { return cellPhone; }
            set { cellPhone = value; }
        }
    }
}
