using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Domain
{
    public class Book
    {
        /// <summary>
        /// 图书ID
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// 书名
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// 图书作者
        /// </summary>
        public string Author
        {
            get;
            set;
        }

        /// <summary>
        /// 出版社
        /// </summary>
        public string Press
        {
            get;
            set;
        }

        /// <summary>
        /// ISBN编号
        /// </summary>
        public string Isbn
        {
            get;
            set;
        }

        /// <summary>
        /// 价格
        /// </summary>
        public float Price
        {
            get;
            set;
        }
    }
}