using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDemos.Domain
{
    public class Product
    {
        /// <summary>
        /// 商品原价
        /// </summary>
        public double Price
        {
            get;
            set;
        }

        public IPrice IPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 商品ID
        /// </summary>
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 计算折后价
        /// </summary>
        public double GetPrice(string discountType)
        {
            return IPrice.GetPrice(Price);
        }
    }
}