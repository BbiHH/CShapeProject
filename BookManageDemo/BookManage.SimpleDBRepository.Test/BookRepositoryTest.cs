using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BookManage.Domain;
using BookManage.IRepository;
using BookManage.SimpleDBRepository;
using Autofac;
using Autofac.Configuration;

namespace BookManage.SimpleDBRepository.Test
{
    [TestClass]
    public class BookRepositoryTest
    {
        private Book book;
        private BookRepository repository;

        [TestInitialize]
        public void Initialize()
        {
            book = new Book()
            {
                Id = 6,
                Title = "测试书籍",
                Author = "Test",
                Press = "清华大学出版社",
                Isbn = "123456",
                Price = 45.6f
            };
            repository = new BookRepository();
        }

        [TestMethod]
        public void Add_Book_CountIncreaseOne()
        {
            var before = repository.FindAll().Count;
            repository.Add(book);
            var after = repository.FindAll().Count;

            var actual = after - before;
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void FindById_Book_InstanceOfBook()
        {
            var book = repository.FindById(1);
            Assert.IsInstanceOfType(book, typeof(Book));
        }

        [TestMethod]
        public void FindAll_InstanceOfBook()
        {
            var booklist = repository.FindAll();
            Assert.IsTrue(booklist.Count >= 1);
        }

        [TestMethod]
        public void Modify_BookTitle()
        {
            var before = repository.FindById(6);
            var expected = "测试书籍";
            before.Title = expected;
            repository.Modify(before);
            var after = repository.FindById(6);

            Assert.AreEqual(expected, after.Title);
        }

        [TestMethod]
        public void Remove_Book_CountDecreaseOne()
        {
            var before = repository.FindAll().Count;
            repository.Remove(6);
            var after = repository.FindAll().Count;

            var actual = after - before;
            Assert.AreEqual(-1, actual);
        }
    }
}