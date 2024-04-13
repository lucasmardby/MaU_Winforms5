using System.Text;

namespace MaU_CSharp5
{
    public partial class MainForm : Form
    {
        private CustomerManager customerManager = new CustomerManager();
        private const string tabSpace = "     ";

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lblCustomerInfo.Text = string.Empty;
        }
        private void UpdateCustomerList()
        {
            lstCustomers.Items.Clear();

            for (var i = 0; i < customerManager.Customers.Count(); i++)
            {
                int tempID = 101 + i;

                string listboxString = string.Format("{0,-5} {1,-9} {2,10} {3,10}", //adjust distances later
                                                     tempID,
                                                     $"{customerManager.GetFullName(i)[1].ToUpper()}, {customerManager.GetFullName(i)[0]}",
                                                     customerManager.GetEmailBusiness(i),
                                                     customerManager.GetPhoneOffice(i));

                lstCustomers.Items.Add(listboxString);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactForm dlg = new ContactForm(customerManager);
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                UpdateCustomerList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex >= 0)
            {
                ContactForm dlg = new ContactForm(customerManager, lstCustomers.SelectedIndex);
                DialogResult dlgResult = dlg.ShowDialog();

                if (dlgResult == DialogResult.OK)
                {
                    UpdateCustomerList();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex >= 0)
            {
                customerManager.DeleteCustomer(lstCustomers.SelectedIndex);
                lstCustomers.Items.Remove(lstCustomers.SelectedItem);
                lblCustomerInfo.Text = string.Empty;
            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex >= 0)
            {
                Customer customer = customerManager.GetCustomer(lstCustomers.SelectedIndex);

                StringBuilder builder = new StringBuilder();

                //Full Name
                builder.AppendLine($"{customer.Contact.FirstName} {customer.Contact.LastName}");

                //Address
                builder.AppendLine(customer.Contact.Address.Street);
                builder.AppendLine($"{customer.Contact.Address.ZipCode} {customer.Contact.Address.City}");
                builder.AppendLine(customer.Contact.Address.Country.ToString());

                //Emails
                builder.AppendLine();
                builder.AppendLine("Emails");
                builder.AppendLine($" Office{tabSpace}{customer.Contact.Email.EmailBusiness}");
                builder.AppendLine($" Private{tabSpace}{customer.Contact.Email.EmailPrivate}");

                //Phone
                builder.AppendLine();
                builder.AppendLine("Phone Numbers");
                builder.AppendLine($" Office{tabSpace}{customer.Contact.Phone.CellPhone}");
                builder.AppendLine($" Private{tabSpace}{customer.Contact.Phone.HomePhone}");

                lblCustomerInfo.Text = builder.ToString();
            }
        }
    }
}
