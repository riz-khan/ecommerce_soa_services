using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace InvoiceService
{
    [ServiceContract(Namespace = "uk.ac.bcu.soa.wcf")]
    public interface IInvoiceRegistry
    {
        [OperationContract]
        bool GenerateInvoice(string orderId, string customerId, string paymentId, double totalAmount, string paymentMethod);

        [OperationContract]
        Invoice GetInvoice(string invoiceId);

        [OperationContract]
        List<Invoice> GetAllInvoices();

    }

}
