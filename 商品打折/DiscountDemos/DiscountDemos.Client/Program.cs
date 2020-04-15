using DiscountDemos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountDemos.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product();

            product.ID = 0;
            product.Name = "APPLE";
            product.Price = 300;

            product.IPrice = new SellerDiscount();
        }
    }
}