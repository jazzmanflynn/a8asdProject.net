using TechTalk.SpecFlow;

namespace TheProject.Test.Steps
{
    using NUnit.Framework;
    using TheProject.Model;

    [Binding]
    public sealed class BorrowBookDefinition
    {
        private Member member ; 
        private Book book;
        private Catalog catalog;

        public BorrowBookDefinition()
        {
            catalog = new Catalog();
            member = new Member();
        }

        [Given(@"(.*) is a member")]
        public void GivenIAmAMember(string name)
        {
            member.Username = name;
        }

        [Given(@"(.*) is in the catalog")]
        public void GivenTheSelectedBookIsInCatalog(string bookTitle)
        {
            catalog.AddBook(new Book { Name = bookTitle });
        }

        [When(@"(.*) borrows (.*)")]
        public void WhenIChooseToBorrowTheBook(string memberName, string bookTitle)
        {
            catalog.LendBook(bookTitle);
        }

        [Then(@"(.*) is borrowed")]
        public void ThenIGetABorrowConfirmation(string bookTitle)
        {
            Assert.That(catalog.GetBook(bookTitle).IsBorrowed);
        }
    }
}
