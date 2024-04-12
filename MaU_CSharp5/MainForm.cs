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
                lstCustomers.Items.Add($"{customerManager.GetEmail(i)}, {customerManager.GetPhone(i)}");
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
                Customer currentCustomer = customerManager.GetCustomer(lstCustomers.SelectedIndex);





                ContactForm dlg = new ContactForm(customerManager);
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
            }
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCustomers.SelectedIndex >= 0)
            {
                Customer customer = customerManager.GetCustomer(lstCustomers.SelectedIndex);

                lblCustomerInfo.Text = $"{customer.Contact.FirstName} {customer.Contact.LastName}";
            }
        }
    }
}
