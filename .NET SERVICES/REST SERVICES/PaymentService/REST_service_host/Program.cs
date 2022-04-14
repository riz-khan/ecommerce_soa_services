using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; 
using System.ServiceModel.Description;
using Payment_Service;

namespace REST_service_host
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 Create a URI to serve as the base address. 
            Uri baseAddress = new Uri("http://cmp7038-pc:4444/PAYMENT-SERVICE/"); 
 
            // Step 2 Create a ServiceHost instance 
            ServiceHost selfHost = new ServiceHost(typeof(PaymentService), baseAddress); 
 
            try 
            { 
                // Step 3 Add a service endpoint with help page enabled. 
                ServiceEndpoint sep = selfHost.AddServiceEndpoint(typeof(IPaymentService), new WebHttpBinding(), ""); 
                WebHttpBehavior whb = new WebHttpBehavior(); 
                whb.HelpEnabled = true; 
                sep.EndpointBehaviors.Add(whb); 
 
 
                // Step 4 Start the service. 
                selfHost.Open(); 
 
                Console.WriteLine("The REST service is ready.\nPress <ENTER> to terminate service."); 
                Console.ReadLine(); 
 
                // Close the ServiceHostBase to shutdown the service. 
                selfHost.Close(); 
            } 
            catch (CommunicationException ce) 
            { 
                Console.WriteLine("An exception occurred: {0}", ce.Message); 
                selfHost.Abort(); 
            } 
        } 
    }
}
 
