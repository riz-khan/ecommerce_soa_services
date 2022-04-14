using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Payment_Service.InvoiceService;

namespace Payment_Service
{
    public class PaymentService : IPaymentService
    {
        string path = @"C:\Users\CMP7174User\Documents\Payment.txt";

        public int ProcessPayment(string orderId, string customerId, double totalAmount, string paymentMethod){
            
            // generate a new invoiceId using random numbers
            Random rnd = new Random();
            int num = rnd.Next(1000, 9999);
            string newPaymentId = "PMT" + num;

            // create a string array
            string[] lines = { newPaymentId+","+
                               orderId+","+
                               customerId+","+
                               totalAmount.ToString()+","+
                               DateTime.Now.ToString()+","+
                               paymentMethod
                             };

            // This is where we fetch the customer card details using customer id and 
            // make calls to external APIs to process payment

            //After payment has been processed and success is returned, we 
            // add an entry of the payment in our filesystem
            if (!File.Exists(path)) // file doesn't exist
            {
                File.WriteAllLines(path, lines);
                // once payment entry has been done, call invoice service
                InvoiceRegistryClient client = new InvoiceRegistryClient();
                bool res = client.GenerateInvoice(orderId, customerId, newPaymentId, totalAmount, paymentMethod);
                if(res == false){ // invoice generation failed
                    return 1;
                }
                return 0;
            }
            else if (File.Exists(path)) // file exist but id doesn't exist
            {
                if (!File.ReadLines(path).Any(line => line.Contains(newPaymentId)))
                {
                    File.AppendAllLines(path, lines);
                    // once payment entry has been done, call invoice service
                    InvoiceRegistryClient client = new InvoiceRegistryClient();
                    bool res = client.GenerateInvoice(orderId, customerId, newPaymentId, totalAmount, paymentMethod);
                    if (res == false){ // invoice generation failed
                        return 1;
                    }
                    return 0;
                }
            }
            else if (File.Exists(path)) // file and id both exist
            {
                if (File.ReadLines(path).Any(line => line.Contains(newPaymentId)))
                {
                    // since the newly generated payment id is already existing, we make a recursive 
                    // call to restart the process
                    ProcessPayment(orderId, customerId, totalAmount, paymentMethod);
                    return 0;
                }
            }
            else
            { // if there is some other issue
                return -1;
            }

            return -1;
        }

        public Payment GetPayment(string paymentId) {

            Payment value = new Payment();

            if (!File.Exists(path)) // file doesn't exist
            {
                return value = null;
            }
            else if (File.ReadLines(path).Any(line => line.Contains(paymentId))) // invoice exists
            {
                var payment = File.ReadLines(path).SkipWhile(line => !line.Contains(paymentId));
                string[] paymentArray = payment.First().Split(',');
                value.PaymentId = paymentArray[0];
                value.OrderId = paymentArray[1];
                value.CustomerId = paymentArray[2];
                value.TotalAmount = Convert.ToDouble(paymentArray[3]);
                value.PaymentDateTime = paymentArray[4];
                value.PaymentMethod = paymentArray[5];

                return value;
            }
            else
            {
                return value = null;
            }
        }

        public List<Payment> GetAllPayment() {

            List<Payment> payments = new List<Payment>();

            // check if file exists
            if (!File.Exists(path)) // file doesn't exist
            {
                return payments = null;
            }
            else
            {
                List<String> lines = File.ReadLines(path).ToList<string>();
                foreach (string payment in lines)
                {
                    string[] paymentArray = payment.Split(',');
                    Payment obj = new Payment();
                    obj.PaymentId = paymentArray[0];
                    obj.OrderId = paymentArray[1];
                    obj.CustomerId = paymentArray[2];
                    obj.TotalAmount = Convert.ToDouble(paymentArray[3]);
                    obj.PaymentDateTime = paymentArray[4];
                    obj.PaymentMethod = paymentArray[5];
                    payments.Add(obj);
                }
                return payments;
            }
        }

    }
}
