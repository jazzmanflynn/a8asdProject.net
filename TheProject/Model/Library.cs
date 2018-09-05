using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject.Model
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        public string Screen { get; set; }

        public void AddBook(string p0)
        {
            books.Add(new Book { Name = p0});
        }

        public Book Search(string p0)
        {
            return books.FirstOrDefault(b => b.Name == p0);
        }
    }
}
