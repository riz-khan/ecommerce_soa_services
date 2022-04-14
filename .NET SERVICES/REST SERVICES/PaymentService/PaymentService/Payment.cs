using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization; 

namespace Payment_Service
{
    [DataContract(Namespace = "uk.ac.bcu.soa.wcf.rest")] 
    public class Payment
    {
        [DataMember] 
        public string PaymentId; 
        [DataMember] 
        public string OrderId;
        [DataMember]
        public string CustomerId;
        [DataMember]
        public double TotalAmount; 
        [DataMember]
        public string PaymentDateTime;
        [DataMember]
        public string PaymentMethod;

        
        // getters
        public string GetPaymentId() {
            return PaymentId;
        }

        public String GetOrderId() {
            return OrderId;
        }

        public String GetCustomerId() {
            return CustomerId;
        }

        public double GetTotalAmount() {
            return TotalAmount;
        }

        public String GetPaymentDateTime() {
            return PaymentDateTime;
        }

        public String GetPaymentMethod() {
            return PaymentMethod;
        }

        // setters
        public void SetPaymentId(string payment_id)
        {
            PaymentId = payment_id;
        }

        public void SetOrderId(string order_id)
        {
            OrderId = order_id;
        }

        public void SetCustomerId(string customer_id)
        {
            CustomerId = customer_id;
        }

        public void SetTotalAmount(double total_amount)
        {
            TotalAmount = total_amount;
        }

        public void SetPaymentDateTime(string payment_datetime)
        {
            PaymentDateTime = payment_datetime;
        }

        public void SetPaymentMethod(string payment_method)
        {
            PaymentMethod = payment_method;
        }
    }
}