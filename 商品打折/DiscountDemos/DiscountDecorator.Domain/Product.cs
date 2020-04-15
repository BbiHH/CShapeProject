using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDecorator.Domain
{
    public class Product
    {
        public string Name
        {
            get => default;
            set
            {
            }
        }

        public int ID
        {
            get => default;
            set
            {
            }
        }

        public double Price
        {
            get => default;
            set
            {
            }
        }

        public void GetPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}