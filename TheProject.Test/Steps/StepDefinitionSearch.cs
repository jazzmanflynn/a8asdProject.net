using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TheProject.Model;

namespace TheProject.Test.Steps
{
    [Binding]
    public class SearchBookSteps
    {
        private Library library = new Library();

        [Given(@"the book ""(.*)"" is in the catalog")]
        public void GivenTheSearchedBookIsInTheCatalog(string p0)
        {
            library.AddBook(p0);
        }


        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string p0)
        {
            Book book = library.Search(p0);
            library.Screen = book.Name;
        }
        
        [Then(@"the book ""(.*)"" is shown on the screen")]
        public void ThenTheBookIsShownOnTheScreen(string p0)
        {          
            Assert.AreEqual(library.Screen, p0);
        }
    }
}
