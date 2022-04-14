using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOO_CLIENT.ProductService;

namespace SOO_CLIENT
{
    public partial class SERVICE_ORCHESTRATION : Form
    {

        public SERVICE_ORCHESTRATION()
        {

            InitializeComponent();
        }

        private void pRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ProductForm productForm = new ProductForm();
            productForm.MdiParent = this;
            productForm.Show();
        }

        private void cUSTOMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.MdiParent = this;
            paymentForm.Show();
        }

        private void iNVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.MdiParent = this;
            invoiceForm.Show();
        }

        private void oRDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            OrderForm orderForm = new OrderForm();
            orderForm.MdiParent = this;
            orderForm.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // LOGOUT USING AUTH SERVICE
            Authenticate auth = new Authenticate();
            auth.LogOutUser(Program.userUuid);

            this.Close();
            LOGIN login = new LOGIN();
            login.Show();

        }

    }
}
