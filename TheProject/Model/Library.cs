using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProject.Model
{
    public class Library
    {
        private Catalog catalog = new Catalog();

        public string Screen { get; set; }

        public void AddBook(string p0)
        {
            catalog.AddBook(new Book { Name = p0});
        }

        public Book Search(string bookTitle)
        {
            SearchedBook = new Book(){Name = bookTitle};
            return catalog.GetBook(bookTitle);
        }
        public Library()
        {
            MemberRegister = new MemberRegister();
        }

        public bool IsMemberLoggedIn { get; set; }
        public MemberRegister MemberRegister { get; set; }
        public Member CurrentUser { get; set; }
        public Book SearchedBook { get; set; }

        public void Login()
        {
            var member = MemberRegister.Find(CurrentUser.Username, CurrentUser.Password);
            IsMemberLoggedIn = member != null;
        }

        public bool LendBook(Book book, Member member)
        {
            book.IsBorrowed = true;
            member.BorrowBook(book);
            return true;
        }

        public void AddUser(string name)
        {
            MemberRegister.Add(new Member {Username = name});
        }
    }
}
