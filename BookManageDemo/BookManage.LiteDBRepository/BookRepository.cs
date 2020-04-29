using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManage.Domain;
using BookManage.IRepository;
using LiteDB;
using System.Configuration;

namespace BookManage.LiteDBRepository
{
    public class BookRepository : IBookRepository
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LiteDb"].ConnectionString;

        /// <summary>
        /// Db对应一个数据库
        /// </summary>
        public LiteDatabase Db
        {
            get
            {
                return new LiteDatabase(connectionString);
            }
        }

        /// <summary>
        /// 对应数据库中的一张表
        /// </summary>
        public ILiteCollection<Book> Collection
        {
            get;
            set;
        }

        public BookRepository()
        {
            Collection = Db.GetCollection<Book>("books");
        }

        public void Add(Book book)
        {
            Collection.Insert(book);
        }

        public IList<Book> FindAll()
        {
            var books = Collection.FindAll();
            return books.ToList();
        }

        public Book FindById(int id)
        {
            var book = Collection.FindById(id);
            return book;
        }

        public void Modify(Book book)
        {
            Collection.Update(book);
        }

        public void Remove(int id)
        {
            Collection.Delete(id);
        }
    }
}