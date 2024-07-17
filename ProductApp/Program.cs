using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProductApp.Product;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products(10,"biscuit",2000,10);
            Console.WriteLine("Discounted price is  = "+ product1.productDiscountedPrice());
            
        }
    }
}
