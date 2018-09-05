using TechTalk.SpecFlow;

namespace TheProject.Test.Steps
{
    using TheProject.Model;

    [Binding]
    public sealed class BorrowBookDefinition
    {
        [Given(@"I am a (.*)")]
        public void GivenIAmA(string p0)
        {
            Member member = new Member();
            ScenarioContext.Current.Pending();
        }

        [Given(@"the (.*) is in the catalog")]
        public void GivenTheIsInTheCatalog(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"and the (.*) is not borrowed")]
        public void GivenAndTheIsNotBorrowed(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I choose to borrow the book")]
        public void WhenIChooseToBorrowTheBook()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I get a borrow confirmation")]
        public void ThenIGetABorrowConfirmation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
