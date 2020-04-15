using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistrictQueryLocalDb.Domain
{
    public class Province
    {
        /// <summary>
        /// 省份名字
        /// </summary>
        public string ProName
        {
            get;
            set;
        }

        /// <summary>
        /// 省份标识
        /// </summary>
        public string ProRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 省份排序
        /// </summary>
        public int ProSort
        {
            get;
            set;
        }

        /// <summary>
        /// 省份ID
        /// </summary>
        public int ProvinceID
        {
            get;
            set;
        }
    }
}