using MaU_CSharp5.ContactFiles;

namespace MaU_CSharp5
{
    public partial class ContactForm : Form
    {
        private Contact contact;
        private CustomerManager customerManager;

        public ContactForm(CustomerManager customerManager)
        {
            this.customerManager = customerManager;
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            Address address = new Address();
            Email email = new(txtEmailBusiness.Text, txtEmailPrivate.Text);
            Phone phone = new(txtHomePhone.Text, txtCellPhone.Text);

            Customer currentCustomer = new Customer(firstName, lastName, address, email, phone);

            customerManager.AddCustomer(currentCustomer);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
