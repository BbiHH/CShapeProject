using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistricvtQuery.Domain
{
    public class District
    {
        /// <summary>
        /// 区域ID
        /// </summary>
        public int DistrictID
        {
            get;
            set;
        }

        /// <summary>
        /// 区域名
        /// </summary>
        public string DistrictName
        {
            get;
            set;
        }

        /// <summary>
        /// 区域排序
        /// </summary>
        public int DistrictSort
        {
            get;
            set;
        }

        public City City
        {
            get;
            set;
        }

        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityID
        {
            get;
            set;
        }
    }
}