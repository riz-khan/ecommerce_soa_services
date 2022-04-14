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
    public partial class ProductForm : Form
    {
        ProductService.ProductService ProductServiceClient = new ProductService.ProductService();

        public ProductForm()
        {
            InitializeComponent();
            GetAllProducts();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.name = ProductName.Text;
            p.price = Convert.ToDouble(Price.Text);
            int t_quantity = Convert.ToInt32(Quantity.Text);
            p.quantity = t_quantity;
            p.barCode = Barcode.Text;
            if (isActive.Checked == true)
            {
                p.active = true;
            }
            else
            {
                p.active = false;
            }

            ProductService.response res = ProductServiceClient.add(p);
            GetAllProducts();
            MessageBox.Show(res.message, "Response from service");

        }

        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.id = ProductId.Text;
            p.name = ProductName.Text;
            p.price = Convert.ToDouble(Price.Text);
            p.quantity = Convert.ToInt32(Quantity.Text);
            p.barCode = Barcode.Text;
            if (isActive.Checked == true)
            {
                p.active = true;
            }
            else
            {
                p.active = false;
            }

            ProductService.response res = ProductServiceClient.update(p);
            GetAllProducts();
            MessageBox.Show(res.message, "Response from service");

        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            ProductService.response res = ProductServiceClient.delete(ProductId.Text);
            GetAllProducts();
            MessageBox.Show(res.message, "Response from service");
        }

        private void GetProductByIdButton_Click(object sender, EventArgs e)
        {
            product p = ProductServiceClient.get(ProductId.Text);
            if (p != null)
            {
                ProductId.Text = p.id;
                ProductName.Text = p.name;
                Price.Text = p.price.ToString();
                Quantity.Text = p.quantity.ToString();
                Barcode.Text = p.barCode;
                if (p.active == true)
                {
                    isActive.Checked = true;
                }
                else
                {
                    isActive.Checked = false;
                }
                MessageBox.Show("Data Fetched", "Response from service");
            }
            else
            {
                MessageBox.Show("No Record Found", "Response from service");
            }
        }

        private void GetProductByName_Click(object sender, EventArgs e)
        {
            product p = ProductServiceClient.getName(ProductName.Text);
            if (p != null)
            {
                ProductId.Text = p.id;
                ProductName.Text = p.name;
                Price.Text = p.price.ToString();
                Quantity.Text = p.quantity.ToString();
                Barcode.Text = p.barCode;
                if (p.active == true)
                {
                    isActive.Checked = true;
                }
                else
                {
                    isActive.Checked = false;
                }
                MessageBox.Show("Data Fetched", "Response from service");
            }
            else
            {
                MessageBox.Show("No Record Found", "Response from service");
            }
        }

        private void GetAllProducts()
        {
            List<product> p = ProductServiceClient.getAll().ToList<product>();
            products.DataSource = p;
        }

        private void StockIn_Click(object sender, EventArgs e)
        {
            ProductService.response res = ProductServiceClient.stockIn(ProductId.Text, Convert.ToInt32(Quantity.Text), true);
            GetAllProducts();
            MessageBox.Show(res.message, "Response from service");
        }

        private void StockOut_Click(object sender, EventArgs e)
        {
            ProductService.response res = ProductServiceClient.stockOut(ProductId.Text, Convert.ToInt32(Quantity.Text), true);
            GetAllProducts();
            MessageBox.Show(res.message, "Response from service");
        }

        private void CheckStockById_Click(object sender, EventArgs e)
        {
            int stock;
            bool temp;
            ProductServiceClient.checkStock(ProductId.Text, out stock, out temp);
            MessageBox.Show("Available stock is: "+stock, "Response from service");
        }

        private void CheckStockByName_Click(object sender, EventArgs e)
        {
            int stock;
            bool temp;
            ProductServiceClient.checkStockByName(ProductName.Text, out stock, out temp);
            MessageBox.Show("Available stock is: " + stock, "Response from service");
        }
    }
}
