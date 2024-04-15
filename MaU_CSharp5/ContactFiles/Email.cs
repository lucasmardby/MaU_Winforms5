namespace MaU_CSharp5.ContactFiles
{
    /// <summary>
    /// Email class, containing information about the contact's email adresses
    /// </summary>
    public class Email
    {
        private string emailBusiness;
        private string emailPrivate;

        public Email(string emailBusiness, string emailPrivate)
        { 
            EmailBusiness = emailBusiness;
            EmailPrivate = emailPrivate;
        }

        public string EmailBusiness
        { 
            get { return emailBusiness; }
            set { emailBusiness = value; }
        }
        public string EmailPrivate
        { 
            get { return emailPrivate; } 
            set {  emailPrivate = value; } 
        }
    }
}
