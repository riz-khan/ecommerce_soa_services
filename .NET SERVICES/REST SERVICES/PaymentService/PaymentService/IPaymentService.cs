using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Payment_Service
{
    [ServiceContract(Namespace = "uk.ac.bcu.soa.wcf.rest")]
    public interface IPaymentService
    {
        [OperationContract]
        [WebGet(UriTemplate = "processPayment?orderId={orderId}&customerId={customerId}&totalAmount={totalAmount}&paymentMethod={paymentMethod}", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)] 
        int ProcessPayment(string orderId, string customerId, double totalAmount, string paymentMethod);

        [OperationContract]
        [WebGet(UriTemplate = "getPayment?paymentId={paymentId}", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        Payment GetPayment(string paymentId);

        [OperationContract]
        [WebGet(UriTemplate = "getAllPayments", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml)]
        List<Payment> GetAllPayment();
    }
}
