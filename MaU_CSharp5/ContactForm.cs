using MaU_CSharp5.ContactFiles;

namespace MaU_CSharp5
{
    public partial class ContactForm : Form
    {
        private Customer currentCustomer;
        private CustomerManager customerManager;
        private int index;

        public ContactForm(CustomerManager customerManager)
        {
            this.customerManager = customerManager;
            InitializeComponent();
            InitializeGUI();
        }
        public ContactForm(CustomerManager customerManager, int index)
        {
            this.customerManager = customerManager;
            this.index = index;
            currentCustomer = customerManager.GetCustomer(index);
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            cmbCountry.DataSource = Enum.GetValues(typeof(Countries));

            if (currentCustomer != null)
            {
                txtFirstName.Text = currentCustomer.Contact.FirstName;
                txtLastName.Text = currentCustomer.Contact.LastName;

                txtHomePhone.Text = currentCustomer.Contact.Phone.HomePhone;
                txtCellPhone.Text = currentCustomer.Contact.Phone.CellPhone;
                txtEmailBusiness.Text = currentCustomer.Contact.Email.EmailBusiness;
                txtEmailPrivate.Text = currentCustomer.Contact.Email.EmailPrivate;

                txtCity.Text = currentCustomer.Contact.Address.City;
                cmbCountry.SelectedItem = currentCustomer.Contact.Address.Country;
                txtStreet.Text = currentCustomer.Contact.Address.Street;
                txtZipCode.Text = currentCustomer.Contact.Address.ZipCode;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (currentCustomer != null)
            {
                EditCustomer();
                Close();
                return;
            }

            bool streetInputted = !string.IsNullOrEmpty(txtStreet.Text);
            bool zipInputted = !string.IsNullOrEmpty(txtZipCode.Text);

            if (zipInputted && !streetInputted)
            {
                MessageBox.Show("No street specified", "Error");
                return;
            }

            Address address;

            if (streetInputted)
            {
                if (zipInputted)
                {
                    address = new Address(txtCity.Text, (Countries)cmbCountry.SelectedItem, txtStreet.Text, txtZipCode.Text);
                }
                else
                {
                    address = new Address(txtCity.Text, (Countries)cmbCountry.SelectedItem, txtStreet.Text);
                }
            }
            else 
            {
                address = new Address(txtCity.Text, (Countries)cmbCountry.SelectedItem);
            }

            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();

            Email email = new(txtEmailBusiness.Text, txtEmailPrivate.Text);
            Phone phone = new(txtHomePhone.Text, txtCellPhone.Text);

            currentCustomer = new Customer(firstName, lastName, address, email, phone);

            customerManager.AddCustomer(currentCustomer);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditCustomer()
        {
            currentCustomer.Contact.FirstName = txtFirstName.Text;
            currentCustomer.Contact.LastName = txtLastName.Text;

            currentCustomer.Contact.Phone.HomePhone = txtHomePhone.Text;
            currentCustomer.Contact.Phone.CellPhone = txtCellPhone.Text;
            currentCustomer.Contact.Email.EmailBusiness = txtEmailBusiness.Text;
            currentCustomer.Contact.Email.EmailPrivate = txtEmailPrivate.Text;

            currentCustomer.Contact.Address.City = txtCity.Text;
            currentCustomer.Contact.Address.Country = (Countries)cmbCountry.SelectedItem;
            currentCustomer.Contact.Address.Street = txtStreet.Text;
            currentCustomer.Contact.Address.ZipCode = txtZipCode.Text;

            customerManager.ChangeCustomer(currentCustomer, index);
        }
    }
}
