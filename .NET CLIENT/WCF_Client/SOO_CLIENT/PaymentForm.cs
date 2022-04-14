using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SOO_CLIENT
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            GetAllPayments();
        }

        private void GetPaymentById_Click(object sender, EventArgs e)
        {
            string baseAddress = "http://cmp7038-pc:4444/PAYMENT-SERVICE/getPayment?paymentId="+PaymentId.Text;
            string body = "";
            string res = SendRequest(baseAddress, "GET", "text/xml", body);
            XDocument xdoc = XDocument.Parse(res);

            foreach (var item in xdoc.Descendants())
            {
                if (item.Name.LocalName == "CustomerId")
                {
                    CustomerId.Text = item.Value;
                }
                else if (item.Name.LocalName == "OrderId")
                {
                    OrderId.Text = item.Value;
                }
                else if (item.Name.LocalName == "PaymentDateTime")
                {
                    DateTime.Text = item.Value;
                }
                else if (item.Name.LocalName == "PaymentId")
                {
                    PaymentId.Text = item.Value;
                }
                else if (item.Name.LocalName == "PaymentMethod")
                {
                    Method.Text = item.Value;
                }
                else if (item.Name.LocalName == "TotalAmount")
                {
                    TotalAmount.Text = item.Value;
                }
            }

            if (xdoc.Descendants().Count() > 0)
            {
                MessageBox.Show("Data Fetched", "Response from service");
            }
            else {
                MessageBox.Show("No Data Found", "Response from service");
            }
            
        }

        private void ProcessPayment_Click(object sender, EventArgs e)
        {

        }

        private void GetAllPayments() {
            string baseAddress = "http://cmp7038-pc:4444/PAYMENT-SERVICE/getAllPayments";
            string body = "";
            string res = SendRequest(baseAddress, "GET", "text/xml", body);

            List<Payment> allPayments = new List<Payment>();

            XDocument xdoc = XDocument.Parse(res);
            foreach (XElement element in xdoc.Root.Elements())
            {
                Payment obj = new Payment();
                foreach(var abc in element.Descendants()){
                    if (abc.Name.LocalName == "CustomerId")
                    {
                        obj.CustomerId = abc.Value;
                    }
                    else if (abc.Name.LocalName == "OrderId")
                    {
                        obj.OrderId = abc.Value;
                    }
                    else if (abc.Name.LocalName == "PaymentDateTime")
                    {
                        obj.PaymentDateTime = abc.Value;
                    }
                    else if (abc.Name.LocalName == "PaymentId")
                    {
                        obj.PaymentId = abc.Value;
                    }
                    else if (abc.Name.LocalName == "PaymentMethod")
                    {
                        obj.PaymentMethod = abc.Value;
                    }
                    else if (abc.Name.LocalName == "TotalAmount")
                    {
                        obj.TotalAmount = Convert.ToDouble(abc.Value);
                    }
                }
                allPayments.Add(obj);
            }

            DataTable allPayments2 = new DataTable();
            allPayments2.TableName = "Payments";
            allPayments2.Columns.Add("CustomerId", typeof(string), null);
            allPayments2.Columns.Add("OrderId", typeof(string), null);
            allPayments2.Columns.Add("PaymentDateTime", typeof(string), null);
            allPayments2.Columns.Add("PaymentId", typeof(string), null);
            allPayments2.Columns.Add("PaymentMethod", typeof(string), null);
            allPayments2.Columns.Add("TotalAmount", typeof(double), null);

            foreach(Payment item in allPayments){
                allPayments2.Rows.Add(item.CustomerId, item.OrderId, item.PaymentDateTime, item.PaymentId, item.PaymentMethod, item.TotalAmount);
            }

            paymentsGridView.DataSource = allPayments2;

        }

        public string SendRequest(string uri, string method, string contentType, string body)
        {
            string responseBody = null;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(uri);
            req.Method = method;
            if (!String.IsNullOrEmpty(contentType))
            {
                req.ContentType = contentType;
            }
            if (!String.IsNullOrEmpty(body))
            {
                byte[] bodyBytes = Encoding.UTF8.GetBytes(body);
                req.GetRequestStream().Write(bodyBytes, 0, bodyBytes.Length);
                req.GetRequestStream().Close();
            }

            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException e)
            {
                resp = (HttpWebResponse)e.Response;
            }

            Stream respStream = resp.GetResponseStream();

            if (respStream != null)
            {
                responseBody = new StreamReader(respStream).ReadToEnd();
            }
            else
            {
                Console.WriteLine("HttpWebResponse.GetResponseStream returned null");
            }
            return responseBody;
        }

    }
}
