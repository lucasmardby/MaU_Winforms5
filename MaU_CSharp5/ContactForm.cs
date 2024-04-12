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

            Customer currentCustomer = new Customer(firstName, lastName, address, email, phone);

            customerManager.AddCustomer(currentCustomer);

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
