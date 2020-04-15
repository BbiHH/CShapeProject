using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountDemos.Domain
{
    public interface IPrice
    {
        /// <summary>
        /// 获得价格
        /// </summary>
        double GetPrice(double Price);
    }
}