using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDemos.Domain
{
    public class SellerDiscount : IPrice
    {
        public double GetPrice(double Price)
        {
            //这里是折扣方式
            return Price;
        }
    }
}