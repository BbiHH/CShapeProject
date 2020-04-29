using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManage.Domain;
using BookManage.IRepository;
using Simple.Data;
using System.Configuration;

namespace BookManage.SimpleDBRepository
{
    public class BookRepository : IBookRepository
    {
        private string constr = ConfigurationManager.ConnectionStrings["SimpleDb"].ConnectionString;

        /// <summary>
        /// Db映射过来的数据库
        /// </summary>
        public dynamic Db
        {
            get
            {
                return Database.OpenConnection(constr);
            }
        }

        public void Add(Book book)
        {
            Db.Books.Insert(book);
        }

        public IList<Book> FindAll()
        {
            IList<Book> bookList = Db.Books.All();
            return bookList;
        }

        public Book FindById(int id)
        {
            return Db.Books.Get(id);
        }

        public void Modify(Book book)
        {
            Db.Books.Update(book);
        }

        public void Remove(int id)
        {
            Db.Books.DeleteById(id);
        }
    }
}