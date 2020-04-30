using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManage.Domain;
using BookManage.IRepository;
using System.Configuration;
using LiteDB;
using Simple.Data;

namespace BookManage.UI
{
    public partial class BookManageForm : Form
    {
        /// <summary>
        /// 依赖倒置
        /// </summary>
        public IBookRepository bookRepository
        {
            get;
            set;
        }

        public BookManageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询所有图书
        /// </summary>
        private void LoadBooks()
        {
            IList<Book> data = bookRepository.FindAll();
            dataGridView1.DataSource = data;
        }

        /// <summary>
        /// 查询指定书记
        /// </summary>
        /// <param name="id"></param>
        private void LoadBook(int id)
        {
            var book = bookRepository.FindById(id);
            IList<Book> booklist = new List<Book>();
            booklist.Add(book);

            dataGridView1.DataSource = booklist;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var id = txtbhcx.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                LoadBooks();
            }
            else
            {
                LoadBook(int.Parse(id));
            }
        }

        private void ShowBook(Book book)
        {
            txtbh.Text = book.Id.ToString();
            txtTitle.Text = book.Title;
            txtcbs.Text = book.Press;
            txtISBN.Text = book.Isbn;
            txtAu.Text = book.Author;
            txtPrice.Text = book.Price.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var book = (Book)dataGridView1.CurrentRow.DataBoundItem;
            ShowBook(book);
        }

        private void ClearBookDetails()
        {
            ShowBook(new Book());
            txtPrice.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtbh.Text.Trim());
            if (id != 0)
            {
                bookRepository.Remove(id);
                LoadBooks();
                ClearBookDetails();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBookDetails();
        }

        private Book GetBook()
        {
            return new Book()
            {
                Id = int.Parse(txtbh.Text.Trim()),
                Title = txtTitle.Text,
                Author = txtAu.Text,
                Press = txtcbs.Text,
                Price = float.Parse(txtPrice.Text),
                Isbn = txtISBN.Text
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtbh.Text.Trim());
            var book = GetBook();
            //为0新建 非0修改
            if (id != 0)
            {
                bookRepository.Modify(book);
            }
            else
            {
                book.Id = new Random().Next(1, 200);
                bookRepository.Add(book);
            }
            LoadBooks();
            ClearBookDetails();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}