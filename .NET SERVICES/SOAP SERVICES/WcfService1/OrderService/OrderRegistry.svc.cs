using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml;
using OrderService.CustomerService;
using OrderService.ProductService;

namespace OrderService
{
    public class OrderRegistry : IOrderRegistry
    {
        public string orderPath = @"C:\Users\CMP7174User\Documents\Order.txt";
        public string feedbackPath = @"C:\Users\CMP7174User\Documents\OrderFeedback.txt";
        public string cartPath = @"C:\Users\CMP7174User\Documents\Cart.txt";
        public string productPath = @"C:\Users\CMP7174User\Documents\Product.txt";
        public Dictionary<string, int> cart = new Dictionary<string, int>();

        public bool AddToCart(string product_id, int quantity)
        {

            if(quantity >= 1){
                // check if product exists or not
                ProductService.ProductService productClient = new ProductService.ProductService();
                product prd = productClient.get(product_id);
                if(prd == null){
                    return false;
                }
                else if (cart.ContainsKey(product_id))
                {
                    int value = 0;
                    cart.TryGetValue(product_id, out value);
                    value = value + quantity;
                    cart[product_id] = value;
                }
                else {
                    cart.Add(product_id, quantity);
                }
                return true;
            }
            else{
                return false;
            }
        }

        public bool RemoveFromCart(string product_id, int quantity)
        {
            if(quantity >= 1){
                // check if product exists or not
                ProductService.ProductService productClient = new ProductService.ProductService();
                product prd = productClient.get(product_id);
                int value = -1;
                cart.TryGetValue(product_id, out value);
                value = value - quantity;
                if (prd == null)
                {
                    return false;
                }
                else if(value == 0){
                    cart.Remove(product_id);
                }
                else if(value < 0){
                    return false;
                }
                else{
                    cart[product_id] = value;
                }
                return true;
            }
            else{
                return false;
            }        
        }

        public int ProcessOrder(string customerId)
        {
            int returnCode = -2;

            // check if the cart is empty
            if(cart.Count == 0){
                returnCode = 2;
                return returnCode;
            }

            // generate a new cardId using random numbers
            Random rnd = new Random();
            int num = rnd.Next(1000, 9999);
            string newCartId = "CRT" + num;
            if(File.ReadLines(cartPath).Any(line => line.Contains(newCartId))) //  CART ID ALREADY EXISTS
            {
                while (!File.ReadLines(cartPath).Any(line => line.Contains(newCartId)))
                {
                    num = rnd.Next(1000, 9999);
                    newCartId = "CRT" + num;
                }
            }

            SaveCart(newCartId);

            // CALCULATE THE TOTAL AMOUNT FROM THE CART
            // SINCE WE STOPPED USER FROM ADDING ITEMS THAT ARE OUT OF 
            // STOCK, WE DO NOT NEED TO CHECK HERE
            double totalAmount = 0;
            foreach(var item in cart){
                // get the product against productId
                List<String> lines2 = File.ReadLines(productPath).ToList<string>();
                foreach (string cartItem in lines2)
                {
                    string[] cartArray = cartItem.Split(',');
                    if(cartArray[0] == item.Key){
                        totalAmount += Convert.ToDouble(cartArray[2])*item.Value;
                    }
                }
            }

            // generate a new orderid using random numbers
            num = rnd.Next(1000, 9999);
            string newOrderId = "ORD" + num;

            // create a string array
            string[] lines = { newOrderId+","+
                               newCartId+","+
                               customerId+","+
                               DateTime.Now.ToString()
                             };

            // WE MAKE CALL TO PAYMENT SERVCE
            string baseAddress = "http://cmp7038-pc:4444/PAYMENT-SERVICE/processPayment?orderId="+newOrderId+"&customerId="+customerId+"&totalAmount="+totalAmount+"&paymentMethod=DEBIT";
            string body = ""; 
            string res = SendRequest(baseAddress , "GET", "text/xml", body);

            XmlDocument xd = new XmlDocument();
            xd.LoadXml(res);
            res = xd.InnerText;

            if(res == "-1"){ // there was some error in payment service. Both Payment and invoice were not generate
                returnCode = -1;
                return returnCode;
            }
            else if(res == "0"){ // success
                returnCode = 0;
            }
            else if(res == "1"){ // invoice generation failed but payment was done
                returnCode = 1;
            }

            if (!File.Exists(orderPath)) // file doesn't exist
            {
                File.WriteAllLines(orderPath, lines);
                cart.Clear();
                return returnCode;
            }
            else if (File.Exists(orderPath)) // file exist but id doesn't exist
            {
                if (!File.ReadLines(orderPath).Any(line => line.Contains(newOrderId)))
                {
                    File.AppendAllLines(orderPath, lines);
                    cart.Clear();
                    return returnCode;
                }
            }
            else if (File.Exists(orderPath)) // file and id both exist
            {
                if (File.ReadLines(orderPath).Any(line => line.Contains(newOrderId)))
                {
                    // since the newly generated order id is already existing, we make a recursive 
                    // call to restart the process
                    ProcessOrder(customerId);
                    cart.Clear();
                    return returnCode;
                }
            }
            else
            { // if there is some other issue
                return -1;
            }

            return -1;

        }

        public Order GetOrder(string orderId)
        {
            Order value = new Order();
            if (!File.Exists(orderPath)) // file doesn't exist
            {
                return value = null;
            }
            else if (File.ReadLines(orderPath).Any(line => line.Contains(orderId))) // orderid exists
            {
                var order = File.ReadLines(orderPath).SkipWhile(line => !line.Contains(orderId));
                string[] invoiceArray = order.First().Split(',');
                value.OrderId = invoiceArray[0];
                value.CartId = invoiceArray[1];
                value.CustomerId = invoiceArray[2];
                value.OrderDateTime = invoiceArray[3];

                return value;
            }
            else
            {
                return value = null;
            }
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            // check if file exists
            if (!File.Exists(orderPath)) // file doesn't exist
            {
                return orders = null;
            }
            else
            {
                List<String> lines = File.ReadLines(orderPath).ToList<string>();
                foreach (string order in lines)
                {
                    string[] invoiceArray = order.Split(',');
                    Order obj = new Order();
                    obj.OrderId = invoiceArray[0];
                    obj.CartId = invoiceArray[1];
                    obj.CustomerId = invoiceArray[2];
                    obj.OrderDateTime = invoiceArray[3];
                    orders.Add(obj);
                }
                return orders;
            }
        }

        public bool GiveFeedback(string orderId, string feedback)
        {
            // check if order_id exists, if yes then return false indicating that a feedback has already been
            // provided against this order_id

            // generate a new invoiceId using random numbers
            Random rnd = new Random();
            int num = rnd.Next(1000, 9999);
            string newFeedbackId = "FDB" + num;

            string[] lines = { newFeedbackId + "," + orderId + "," + feedback };
            
            if (!File.Exists(feedbackPath)) // file doesn't exist
            {
                File.WriteAllLines(feedbackPath, lines);
                return true;
            }
            else if (File.Exists(feedbackPath)) // file exist but id doesn't exist
            {
                if (!File.ReadLines(feedbackPath).Any(line => line.Contains(newFeedbackId)))
                {
                    File.AppendAllLines(feedbackPath, lines);
                    return true;
                }
            }
            else if (File.Exists(feedbackPath)) // file and id both exist
            {
                if (File.ReadLines(feedbackPath).Any(line => line.Contains(newFeedbackId)))
                {
                    // since the newly generated feedback id is already existing, we make a recursive 
                    // call to restart the process
                    GiveFeedback(orderId, feedback);
                    return true;
                }
            }
            else
            { // if there is some other issue
                return false;
            }

            return false;
        }

        public List<Feedback> GetAllFeedbacks()
        {
            List<Feedback> feedbacks = new List<Feedback>();

            // check if file exists
            if (!File.Exists(feedbackPath)) // file doesn't exist
            {
                return feedbacks;
            }
            else
            {
                List<String> lines = File.ReadLines(feedbackPath).ToList<string>();
                foreach (string order in lines)
                {
                    string[] feedbackArray = order.Split(',');
                    Feedback temp = new Feedback();
                    temp.SetFeedBackId(feedbackArray[0]);
                    temp.SetOrderId(feedbackArray[1]);
                    temp.SetFeedback(feedbackArray[2]);
                    feedbacks.Add(temp);
                }
                return feedbacks;
            }
        }

        public bool SaveCart(string cartId) {
            // loop through the cart and add each product into file
            foreach (var item in cart)
            {
                string[] lines = { cartId + "," + item.Key + "," + item.Value };

                if (!File.Exists(cartPath)) // file doesn't exist
                {
                    File.WriteAllLines(cartPath, lines);
                }
                else if (File.Exists(cartPath)) // file exist
                {
                    File.AppendAllLines(cartPath, lines);
                }
                else
                { // if there is some other issue
                    return false;
                }
            }
            return true;
        }

        public List<CartItem> GetCartDetails(string cartId){
            List<CartItem> cartItems = new List<CartItem>();

            // check if file exists
            if (!File.Exists(cartPath)) // file doesn't exist
            {
                return cartItems;
            }
            else if (File.ReadLines(cartPath).Any(line => line.Contains(cartId)))// both file and cartid exists
            {
                var lines1 = File.ReadAllLines(cartPath).ToList();
                var lines2 = lines1.Where(x => x.Contains(cartId)).ToList();

                foreach (string cartItem in lines2)
                {
                    string[] cartItemArray = cartItem.Split(',');
                    CartItem temp = new CartItem();
                    temp.SetCartId(cartItemArray[0]);
                    temp.SetProductId(cartItemArray[1]);
                    temp.SetProductQuantity(cartItemArray[2]);
                    cartItems.Add(temp);
                }
                return cartItems;
            }
            return null;
        }

        public Dictionary<string, int> GetCurrentCart(){
            return cart;
        }

        public static string SendRequest(string uri, string method, string contentType, string body)
        {
            string responseBody = null;

            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(uri);
            req.Method = method;
            if (!String.IsNullOrEmpty(contentType))
            {
                req.ContentType = contentType;
            }
            if (!String.IsNullOrEmpty(body))
            {
                byte[] bodyBytes = Encoding.UTF8.GetBytes(body);
                req.GetRequestStream().Write(bodyBytes, 0, bodyBytes.Length);
                req.GetRequestStream().Close();
            }

            HttpWebResponse resp;
            try
            {
                resp = (HttpWebResponse)req.GetResponse();
            }
            catch (WebException e)
            {
                resp = (HttpWebResponse)e.Response;
            }

            Stream respStream = resp.GetResponseStream();

            if (respStream != null)
            {
                responseBody = new StreamReader(respStream).ReadToEnd();
            }
            else
            {
                Console.WriteLine("HttpWebResponse.GetResponseStream returned null");
            }
            return responseBody;
        }

    }
}
