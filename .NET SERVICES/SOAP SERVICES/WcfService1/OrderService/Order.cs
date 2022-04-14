using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OrderService
{
    [DataContract(Namespace = "uk.ac.bcu.soa.wcf")]
    public class Order
    {
        // ----------- ATTRIBUTES ------------
        [DataMember]
        public string OrderId;

        [DataMember]
        public string CartId;

        [DataMember]
        public string CustomerId;

        [DataMember]
        public string OrderDateTime;
        

        //----------- GETTERS ---------------
        public string GetOrderId()
        {
            return OrderId;
        }

        public string GetCartId()
        {
            return CartId;
        }

        public string GetCustomerId()
        {
            return CustomerId;
        }

        public string GetOrderDateTime()
        {
            return OrderDateTime;
        }

        //------------ SETTERS --------------

        public void SetOrderId(string order_id)
        {
            OrderId = order_id;
        }

        public void SetCartId(string cart_id)
        {
            CartId = cart_id;
        }

        public void SetCustomerId(string customer_id)
        {
            CustomerId = customer_id;
        }

        public void SetOrderDateTime(string order_datetime)
        {
            OrderDateTime = order_datetime;
        }

    }
}