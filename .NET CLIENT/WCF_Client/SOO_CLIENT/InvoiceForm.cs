using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOO_CLIENT.InvoiceService;

namespace SOO_CLIENT
{
    public partial class InvoiceForm : Form
    {
        InvoiceRegistryClient invoiceClient = new InvoiceRegistryClient();

        public InvoiceForm()
        {

            InitializeComponent();
            GetAllInvoices();
        }

        private void GetInvoiceByIdButton_Click(object sender, EventArgs e)
        {
            Invoice inv = invoiceClient.GetInvoice(InvoiceId.Text);

            if (inv != null)
            {
                InvoiceId.Text = inv.InvoiceId.ToString();
                CustomerId.Text = inv.CustomerId.ToString();
                PaymentId.Text = inv.PaymentId.ToString();
                PaymentMethod.Text = inv.PaymentMethod.ToString();
                TotalAmount.Text = inv.TotalAmount.ToString();
                OrderId.Text = inv.OrderId.ToString();
                InvoiceDateTime.Text = inv.InvoiceDateTime.ToString();
                MessageBox.Show("Data Fetched", "Response from service");
            }
            else
            {
                MessageBox.Show("No Record Found", "Response from service");
            }
        }

        private void GenerateInvoiceButton_Click(object sender, EventArgs e)
        {
            
        }

        private void GetAllInvoices() 
        {
            List<Invoice> allInvoices = invoiceClient.GetAllInvoices().ToList<Invoice>();
            invoices.DataSource = allInvoices;
        }
    }
}
