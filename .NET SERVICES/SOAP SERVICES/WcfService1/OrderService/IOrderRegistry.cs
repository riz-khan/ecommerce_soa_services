using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderService
{
    [ServiceContract(Namespace = "uk.ac.bcu.soa.wcf")]
    public interface IOrderRegistry
    {
        [OperationContract]
        bool AddToCart(string product_id, int quantity);

        [OperationContract]
        bool RemoveFromCart(string product_id, int quantity);

        [OperationContract]
        int ProcessOrder(string customerId);

        [OperationContract]
        Order GetOrder(string orderId);

        [OperationContract]
        List<Order> GetAllOrders();

        [OperationContract]
        bool GiveFeedback(string orderId, string feedback);

        [OperationContract]
        List<Feedback> GetAllFeedbacks();

        [OperationContract]
        List<CartItem> GetCartDetails(string cartId);

        [OperationContract]
        Dictionary<string, int> GetCurrentCart();
    }
}
