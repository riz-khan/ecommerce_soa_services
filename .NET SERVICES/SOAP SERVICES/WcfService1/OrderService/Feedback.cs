using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OrderService
{
    [DataContract(Namespace = "uk.ac.bcu.soa.wcf")]
    public class Feedback
    {
        // ----------- ATTRIBUTES ------------
        [DataMember]
        public string FeedbackId;

        [DataMember]
        public string OrderId;

        [DataMember]
        public string CustomerFeedback;

        // ------------- GETTERS --------------

        public string GetOrderId()
        {
            return OrderId;
        }

        public string GetFeedbackId()
        {
            return FeedbackId;
        }

        public string getCustomerFeedback()
        {
            return CustomerFeedback;
        }

        // ------------- SETTERS --------------

        public void SetOrderId(string order_id)
        {
            this.OrderId = order_id;
        }

        public void SetFeedBackId(string feedback_id)
        {
            this.FeedbackId = feedback_id;
        }

        public void SetFeedback(string feedback)
        {
            this.CustomerFeedback = feedback;
        }

    }
}