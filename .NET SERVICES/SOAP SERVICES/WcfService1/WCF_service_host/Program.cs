using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using InvoiceService;
using OrderService;

namespace WCF_service_host
{
    class Program
    {
        static void Main(string[] args)
        {

            // Step 1 Create a URI to serve as the base address. 
            Uri baseAddress2 = new Uri("http://cmp7038-PC:8889/INVOICE-SERVICE/");
            Uri baseAddress3 = new Uri("http://cmp7038-PC:8890/ORDER-SERVICE/");
            

            // Step 2 Create a ServiceHost instance 
            ServiceHost selfHost2 = new ServiceHost(typeof(InvoiceRegistry), baseAddress2);
            ServiceHost selfHost3 = new ServiceHost(typeof(OrderRegistry), baseAddress3);
            
            try
            {
                // Step 3 Add a service endpoint. 
                selfHost2.AddServiceEndpoint(typeof(IInvoiceRegistry), new BasicHttpBinding(), "InvoiceRegistry");
                selfHost3.AddServiceEndpoint(typeof(IOrderRegistry), new BasicHttpBinding(), "OrderRegistry");
                
                // Step 4 Enable metadata exchange. 
                ServiceMetadataBehavior smb2 = new ServiceMetadataBehavior();
                smb2.HttpGetEnabled = true;
                ServiceMetadataBehavior smb3 = new ServiceMetadataBehavior();
                smb3.HttpGetEnabled = true;

                selfHost2.Description.Behaviors.Add(smb2);
                selfHost3.Description.Behaviors.Add(smb3);
                
                // Step 5 define service behavior as single, so that the service   
                // maintain state. 
                ServiceBehaviorAttribute sba2 = selfHost2.Description.Behaviors.Find<ServiceBehaviorAttribute>();
                sba2.InstanceContextMode = InstanceContextMode.Single;
                sba2.ConcurrencyMode = ConcurrencyMode.Single;

                ServiceBehaviorAttribute sba3 = selfHost3.Description.Behaviors.Find<ServiceBehaviorAttribute>();
                sba3.InstanceContextMode = InstanceContextMode.Single;
                sba3.ConcurrencyMode = ConcurrencyMode.Single;

                // Step 6 Start the service. 
                selfHost2.Open();
                selfHost3.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service. 
                selfHost2.Close();
                selfHost3.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost2.Abort();
                selfHost3.Abort();
            }
        }
    }
}