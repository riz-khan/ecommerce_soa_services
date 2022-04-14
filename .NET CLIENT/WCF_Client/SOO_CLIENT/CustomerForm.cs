using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOO_CLIENT.CustomerService;

namespace SOO_CLIENT
{
    public partial class CustomerForm : Form
    {
        CustomerService.CustomerService CustomerServiceClient = new CustomerService.CustomerService();

        public CustomerForm()
        {
            InitializeComponent();
            GetAllCustomers();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.name = CustomerName.Text;
            c.phone = Phone.Text;
            c.email = Email.Text;
            c.cardName = CardName.Text;
            c.cardNumber = CardNumber.Text;
            c.cardCvv = CardCvv.Text;
            c.cardExpiry = CardExpiry.Text;

            CustomerService.response res = CustomerServiceClient.addCustomer(c);
            GetAllCustomers();
            MessageBox.Show(res.message, "Response from service");
        }

        private void UpdateCustomerButton_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.customerID = CustomerId.Text;
            c.name = CustomerName.Text;
            c.phone = Phone.Text;
            c.email = Email.Text;
            c.cardName = CardName.Text;
            c.cardNumber = CardNumber.Text;
            c.cardCvv = CardCvv.Text;
            c.cardExpiry = CardExpiry.Text;

            CustomerService.response res = CustomerServiceClient.updateCustomer(c);
            GetAllCustomers();
            MessageBox.Show(res.message, "Response from service");
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerService.response res = CustomerServiceClient.deleteCustomer(CustomerId.Text);
            GetAllCustomers();
            MessageBox.Show(res.message, "Response from service");
        }

        private void GetCustomerByIdButton_Click(object sender, EventArgs e)
        {
            customer c = CustomerServiceClient.getCustomer(CustomerId.Text);

            if (c != null)
            {
                CustomerId.Text = c.customerID.ToString();
                CustomerName.Text = c.name.ToString();
                Phone.Text = c.phone.ToString();
                Email.Text = c.email.ToString();
                CardName.Text = c.cardName.ToString();
                CardNumber.Text = c.cardNumber.ToString();
                CardCvv.Text = c.cardCvv.ToString();
                CardExpiry.Text = c.cardExpiry.ToString();
                MessageBox.Show("Data Fetched", "Response from service");
            }
            else {
                MessageBox.Show("No Record Found", "Response from service");
            }
        }

        private void GetCustomerByName_Click(object sender, EventArgs e)
        {
            customer c = CustomerServiceClient.getCustomerName(CustomerName.Text);

            if (c != null)
            {
                CustomerId.Text = c.customerID.ToString();
                CustomerName.Text = c.name.ToString();
                Phone.Text = c.phone.ToString();
                Email.Text = c.email.ToString();
                CardName.Text = c.cardName.ToString();
                CardNumber.Text = c.cardNumber.ToString();
                CardCvv.Text = c.cardCvv.ToString();
                CardExpiry.Text = c.cardExpiry.ToString();
                MessageBox.Show("Data Fetched", "Response from service");
            }
            else
            {
                MessageBox.Show("No Record Found", "Response from service");
            }
        }

        private void GetAllCustomers() {
            List<customer> c = CustomerServiceClient.getAll().ToList<customer>();
            customers.DataSource = c;
        }
    }
}
