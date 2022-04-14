using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace InvoiceService
{
    [DataContract(Namespace = "uk.ac.bcu.soa.wcf")]
    public class Invoice
    {
        // ----------- ATTRIBUTES ------------
        [DataMember]
        public string InvoiceId;

        [DataMember]
        public string OrderId;

        [DataMember]
        public string CustomerId;    

        [DataMember]
        public string PaymentId;

        [DataMember]
        public double TotalAmount;

        [DataMember]
        public string PaymentMethod;

        [DataMember]
        public string InvoiceDateTime;

        // ----------- GETTERS ------------

        public string GetInvoiceId() {
            return InvoiceId;
        }

        public string GetOrderId()
        {
            return OrderId;
        }

        public string GetCustomerId()
        {
            return CustomerId;
        }

        public string GetPaymentId()
        {
            return PaymentId;
        }

        public double GetTotalAmount()
        {
            return TotalAmount;
        }

        public string GetPaymentMethod()
        {
            return PaymentMethod;
        }

        public string GetInvoiceDateTime()
        {
            return InvoiceDateTime;
        }

        // ------------ SETTERS -------------

        public void SetInvoiceId(string invoice_id)
        {
            InvoiceId = invoice_id;
        }

        public void SetOrderId(string order_id)
        {
            OrderId = order_id;
        }

        public void SetCustomerId(string customer_id)
        {
            CustomerId = customer_id;
        }

        public void SetPaymentId(string payment_id)
        {
            PaymentId = payment_id;
        }

        public void SetTotalAmount(double total_amount)
        {
            TotalAmount = total_amount;
        }

        public void SetPaymentMethod(string payment_method)
        {
            PaymentMethod = payment_method;
        }

        public void SetInvoiceDateTime(string invoice_datetime)
        {
            InvoiceDateTime = invoice_datetime;
        }

    }
}