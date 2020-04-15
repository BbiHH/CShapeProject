using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistrictQueryLocalDb.Domain
{
    public class City
    {
        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityID
        {
            get;
            set;
        }

        /// <summary>
        /// 城市名字
        /// </summary>
        public string CityName
        {
            get;
            set;
        }

        /// <summary>
        /// 城市排序
        /// </summary>
        public int CitySort
        {
            get;
            set;
        }

        public Province Province
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