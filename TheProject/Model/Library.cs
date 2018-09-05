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
        public Library()
        {
            MemberRegister = new MemberRegister();
        }

        public bool IsMemberLoggedIn { get; set; }
        public MemberRegister MemberRegister { get; set; }
        public Member CurrentUser { get; set; }

        public void Login()
        {
            var member = MemberRegister.Find(CurrentUser.Username, CurrentUser.Password);
            IsMemberLoggedIn = member != null;
        }
    }
}
