using BookManage.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.IRepository
{
    public interface IBookRepository
    {
        /// <summary>
        /// 增添图书
        /// </summary>
        /// <param name="book">待增图书对象</param>
        void Add(Book book);

        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="id">待删除图书id</param>
        void Remove(int id);

        /// <summary>
        /// 修改图书
        /// </summary>
        void Modify(Book book);

        /// <summary>
        /// 通过id查询图书
        /// </summary>
        /// <param name="id">待查书id</param>
        Book FindById(int id);

        /// <summary>
        /// 查询数据库中所有图书
        /// </summary>
        IList<Book> FindAll();
    }
}