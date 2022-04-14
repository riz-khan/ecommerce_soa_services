using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOO_CLIENT.OrderService2;
using SOO_CLIENT.CustomerService;

namespace SOO_CLIENT
{
    public partial class OrderForm : Form
    {
        OrderRegistryClient orderServiceClient = new OrderRegistryClient();
        CustomerService.CustomerService customerServiceClient = new CustomerService.CustomerService();

        public OrderForm()
        {
            InitializeComponent();
            GetAllOrders();
            GetAllFeedbacks();
            GetCurrentCart();
        }

        private void GetAllOrders(){
            List<Order> allOrders = orderServiceClient.GetAllOrders().ToList<Order>();
            ordersGridView.DataSource = allOrders;
        }

        private void GetAllFeedbacks(){
            List<Feedback> allOrders = orderServiceClient.GetAllFeedbacks().ToList<Feedback>();
            feedbacksGridView.DataSource = allOrders;
        }

        private void getOrderByIdButton_Click(object sender, EventArgs e)
        {
            Order ord = orderServiceClient.GetOrder(OrderId.Text);

            if (ord != null)
            {
                OrderId.Text = ord.OrderId.ToString();
                CustomerId.Text = ord.CustomerId.ToString();
                CartId.Text = ord.CartId.ToString();
                OrderDateTime.Text = ord.OrderDateTime.ToString();
                MessageBox.Show("Data Fetched", "Response from service");
            }
            else
            {
                MessageBox.Show("No Record Found", "Response from service");
            }
        }

        private void GiveFeedbackButton_Click(object sender, EventArgs e)
        {
            bool res = orderServiceClient.GiveFeedback(feedbackOrderId.Text, feedback.Text);
            if (res == true)
            {
                ClearAllFields();
                MessageBox.Show("Feedback Saved", "Response from service");
                GetAllFeedbacks();
            }
            else {
                ClearAllFields();
                MessageBox.Show("No Record Found", "Response from service");
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int t_quantity = Convert.ToInt32(Quantity.Text);
                bool res = orderServiceClient.AddToCart(ProductId.Text, t_quantity);
                if (res == true)
                {
                    this.GetCurrentCart();
                    MessageBox.Show("item added", "Response from service");
                    ProductId.Text = "";
                    Quantity.Text = "";
                }
                else
                {
                    MessageBox.Show("Product Id incorrent or item out of stock", "Response from service");
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void RemoveFromCart_Click(object sender, EventArgs e)
        {
            int t_quantity = Convert.ToInt32(Quantity.Text);
            bool res = orderServiceClient.RemoveFromCart(ProductId.Text, t_quantity);
            if (res == true)
            {
                this.GetCurrentCart();
                MessageBox.Show("item removed", "Response from service");
                ProductId.Text = "";
                Quantity.Text = "";
            }
            else
            {
                MessageBox.Show("item could not be removed", "Response from service");
            }
        }

        private void GetCurrentCart() {
            Dictionary<string,int> currentCart = orderServiceClient.GetCurrentCart();
            var _currentCartArray = from row in currentCart select new { Product = row.Key, Quantity = row.Value };
            cartGridView.DataSource = _currentCartArray.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CartItem> cart = orderServiceClient.GetCartDetails(CartId.Text).ToList<CartItem>();
            cartGridView.DataSource = cart;
        }

        private void ProcessOrderButton_Click(object sender, EventArgs e)
        {
            // check if customer id is valid
            customer cst = customerServiceClient.getCustomer(CustomerId.Text);

            if (cst == null)
            {
                MessageBox.Show("Customer Id is invalid", "Response from service");
            }
            else 
            {
                int res = orderServiceClient.ProcessOrder(CustomerId.Text);

                if (res == -1)
                { // some error
                    MessageBox.Show("There was some error in transaction. Order was not placed.", "Response from service");
                }
                else if (res == 0)
                { // success
                    MessageBox.Show("Order Placed", "Response from service");
                    GetAllOrders();
                    ClearAllFields();
                }
                else if (res == 1)
                { // invoice creation failed but payment was done
                    MessageBox.Show("Order was placed, payment was successfull but invoice was not generated", "Response from service");
                    GetAllOrders();
                    ClearAllFields();
                }
                else if (res == 2)
                { // cart is empty
                    MessageBox.Show("Cart is empty, can not process order", "Response from service");
                }
            }

        }

        private void ClearAllFields() {
            OrderId.Text = "";
            CustomerId.Text = "";
            CartId.Text = "";
            OrderDateTime.Text = "";
            feedbackOrderId.Text = "";
            feedback.Text = "";
            ProductId.Text = "";
            Quantity.Text = "";
            cartGridView.DataSource = null;
        }
    }
}
