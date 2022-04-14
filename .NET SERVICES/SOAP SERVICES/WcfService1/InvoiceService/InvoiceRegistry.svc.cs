using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InvoiceService
{
    public class InvoiceRegistry : IInvoiceRegistry
    {
        string path = @"C:\Users\CMP7174User\Documents\Invoice.txt";

        public bool GenerateInvoice(string orderId, string customerId, string paymentId, double totalAmount, string paymentMethod){

            // generate a new invoiceId using random numbers
            Random rnd = new Random();
            int num  = rnd.Next(1000, 9999);
            string newInvoiceId = "INV" + num;

            // create a string array
            string[] lines = { newInvoiceId+","+
                               orderId+","+
                               customerId+","+
                               paymentId+","+
                               totalAmount.ToString()+","+
                               paymentMethod+","+
                               DateTime.Now.ToString()
                             };

            if (!File.Exists(path)) // file doesn't exist
            {
                File.WriteAllLines(path, lines);
                return true;
            }
            else if (File.Exists(path)) // file exist but id doesn't exist
            {
                if (!File.ReadLines(path).Any(line => line.Contains(newInvoiceId)))
                {
                    File.AppendAllLines(path, lines);
                    return true;
                }
            }
            else if (File.Exists(path)) // file and id both exist
            {
                if (File.ReadLines(path).Any(line => line.Contains(newInvoiceId)))
                {
                    // since the newly generated invoice id is already existing, we make a recursive 
                    // call to restart the process
                    GenerateInvoice(orderId, customerId, paymentId, totalAmount, paymentMethod);
                    return true;
                }
            }
            else
            { // if there is some other issue
                return false;
            }

            return false;

        }
        
        public Invoice GetInvoice(string invoiceId){

            Invoice value = new Invoice();
            if (!File.Exists(path)) // file doesn't exist
            {
                return value = null;
            }
            else if (File.ReadLines(path).Any(line => line.Contains(invoiceId))) // invoice exists
            {
                var invoice = File.ReadLines(path).SkipWhile(line => !line.Contains(invoiceId));
                string[] invoiceArray = invoice.First().Split(',');
                value.InvoiceId = invoiceArray[0]; 
                value.OrderId = invoiceArray[1];
                value.CustomerId = invoiceArray[2];
                value.PaymentId = invoiceArray[3];
                value.TotalAmount = Convert.ToDouble(invoiceArray[4]);
                value.PaymentMethod = invoiceArray[5];
                value.InvoiceDateTime = invoiceArray[6];

                return value;
            }
            else{
                return value = null;
            }

        }

        public List<Invoice> GetAllInvoices() {

            List<Invoice> invoices = new List<Invoice>();

            // check if file exists
            if (!File.Exists(path)) // file doesn't exist
            {
                return invoices = null;
            }
            else {
                List<String> lines = File.ReadLines(path).ToList<string>();
                foreach(string invoice in lines){
                    string[] invoiceArray = invoice.Split(',');
                    Invoice obj = new Invoice();
                    obj.InvoiceId = invoiceArray[0];
                    obj.OrderId = invoiceArray[1];
                    obj.CustomerId = invoiceArray[2];
                    obj.PaymentId = invoiceArray[3];
                    obj.TotalAmount = Convert.ToDouble(invoiceArray[4]);
                    obj.PaymentMethod = invoiceArray[5];
                    obj.InvoiceDateTime = invoiceArray[6];
                    invoices.Add(obj);
                }
                return invoices;
            }
        
        }

    }
}
