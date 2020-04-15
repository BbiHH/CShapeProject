using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDemos.Domain
{
    public class GovDiscount : IPrice
    {
        public double GetPrice(double Price)
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Hour > 22 && dateTime.Hour < 24)
            {
            }

            //这里是折扣方式
            return Price;
        }
    }
}