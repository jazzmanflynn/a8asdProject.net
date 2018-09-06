using TechTalk.SpecFlow;

namespace TheProject.Test.Steps
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using TheProject.Model;

    [Binding]
    public sealed class BorrowBookDefinition
    {
        private Member member ;
        private Book book;
        private Library library;

        public BorrowBookDefinition()
        {
            library = new Library();
            
            
            member = new Member();
        }

        [Given(@"(.*) is a member")]
        public void GivenIAmAMember(string name)
        {
            member.Username = name;
            library.AddUser(name);
        }

        [Given(@"(.*) is in the library catalog")]
        public void GivenTheSelectedBookIsInCatalog(string bookTitle)
        {
            library.AddBook(bookTitle);
        }

        [When(@"(.*) borrows (.*)")]
        public void WhenIChooseToBorrowTheBook(string memberName, string bookTitle)
        {

            library.LendBook(library.Search(bookTitle), member);
        }

        [Then(@"(.*) is borrowed")]
        public void ThenIGetABorrowConfirmation(string bookTitle)
        {
            Assert.That(library.Search(bookTitle).IsBorrowed);
        }

        [Then(@"(.*) borrowed book list not contains (.*)")]
        public void ThenMikkisBorrowedBookNotContainsNotAvailableBook(string memberName, string bookTitle)
        {
            bool hasBook = library.MemberRegister.Find(memberName).GetBorrowedBooks().Contains(bookTitle);
            Assert.IsFalse(hasBook);
        }
    }
}
