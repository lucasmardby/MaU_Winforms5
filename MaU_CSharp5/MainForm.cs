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
            var count = customerManager.Customers.Count();

            for (var i = 0; i < customerManager.Customers.Count(); i++)
            {
                string listboxString = String.Format("{0,-15} {1,-9} {2,10}  ",
                    customerManager.GetEmail(i), customerManager.GetPhone(i));

                lstCustomers.Items.Add($"{customerManager.GetEmail(i)} {customerManager.GetPhone(i)}");
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
