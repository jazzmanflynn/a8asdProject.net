using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject.Model
{
    public class Catalog
    {
        private IList<Book> _listOfBooks = new List<Book>();

        public void AddBook(Book book)
        {
            _listOfBooks.Add(book);
        }

        public bool ContainsBook(string title)
        {
            return _listOfBooks.Any(b => b.Name == title);
        }

        public void LendBook(string bookTitle)
        {
            _listOfBooks.First(b => b.Name == bookTitle).IsBorrowed = true;

        }

        public Book GetBook(string bookTitle)
        {
            return _listOfBooks.First(b => b.Name == bookTitle);
        }
    }
}
