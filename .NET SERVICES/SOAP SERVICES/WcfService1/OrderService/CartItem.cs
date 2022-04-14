using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OrderService
{
    [DataContract(Namespace = "uk.ac.bcu.soa.wcf")]
    public class CartItem
    {
        // ----------- ATTRIBUTES ------------
        [DataMember]
        public string CartId;

        [DataMember]
        public string ProductId;

        [DataMember]
        public string ProductQuantity;

        // ------------- GETTERS --------------

        public string GetCartId()
        {
            return CartId;
        }

        public string GetProductId()
        {
            return ProductId;
        }

        public string getProductQuantity()
        {
            return ProductQuantity;
        }

        // ------------- SETTERS --------------

        public void SetCartId(string Cart_Id)
        {
            this.CartId = Cart_Id;
        }

        public void SetProductId(string Product_Id)
        {
            this.ProductId = Product_Id;
        }

        public void SetProductQuantity(string product_quantity)
        {
            this.ProductQuantity = product_quantity;
        }
    }
}