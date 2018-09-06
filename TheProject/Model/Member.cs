using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject.Model
{
    public class Member
    {
        public IList<string> _borrowedBooks = new List<string>();

        public string Username { get; set; }

        public string Password { get; set; }

        public void BorrowBook(Book book)
        {
            _borrowedBooks.Add(book.Name);
        }
    }
}
