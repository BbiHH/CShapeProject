using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDecorator.Domain
{
    public class DiscountDecorator : PriceDiscount
    {
        private PriceDiscount _priceDiscount;

        public DiscountDecorator(PriceDiscount priceDiscount)
        {
            this._priceDiscount = priceDiscount;
        }

        public override double DiscountedPrice(double price)
        {
            return _priceDiscount.DiscountedPrice(price);
        }
    }
}