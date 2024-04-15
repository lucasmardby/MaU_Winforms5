using System.Text;

namespace MaU_CSharp5
{
    public partial class MainForm : Form
    {
        private CustomerManager customerManager = new CustomerManager();

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

                string listboxString = string.Format("{0,-5} {1,-10} {2,20} {3,20}",
                                                     tempID,
                                                     $"{customerManager.GetFullName(i)[1].ToUpper()}, {customerManager.GetFullName(i)[0]}",
                                                     customerManager.GetPhoneOffice(i),
                                                     customerManager.GetEmailBusiness(i));

                lstCustomers.Items.Add(listboxString);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(customerManager);
            DialogResult contFormResult = contactForm.ShowDialog();

            if (contFormResult == DialogResult.OK)
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
                builder.AppendLine(string.Format("{0,-10} {1,-9}", " Office", customer.Contact.Email.EmailBusiness));
                builder.AppendLine(string.Format("{0,-10} {1,-9}", " Private", customer.Contact.Email.EmailPrivate));

                //Phone
                builder.AppendLine();
                builder.AppendLine("Phone Numbers");
                builder.AppendLine(string.Format("{0,-10} {1,-9}", " Office", customer.Contact.Phone.CellPhone));
                builder.AppendLine(string.Format("{0,-10} {1,-9}", " Private", customer.Contact.Phone.HomePhone));

                lblCustomerInfo.Text = builder.ToString();
            }
        }
    }
}
