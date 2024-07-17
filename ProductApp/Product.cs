using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProductApp.Product;

namespace ProductApp
{
    internal class Product
    {
        public class Products 
        {
            private int productId;
            private string productname;
            private int productPrice;
            private int productDiscountPercentage;

        public Products(int productId, string productname, int productPrice, int productDiscountPercentage)
        {
                this.productId = productId;
                this.productPrice = productPrice;
                this.productname = productname;
                this.productDiscountPercentage = productDiscountPercentage;
        }
        public double productDiscountedPrice()
            {
                double productDiscountedPrice= productPrice - (productPrice * productDiscountPercentage / 100);
                return productDiscountedPrice;
            }
        }
    }
}
