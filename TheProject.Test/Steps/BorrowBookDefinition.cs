using TechTalk.SpecFlow;

namespace TheProject.Test.Steps
{
    [Binding]
    public sealed class BorrowBookDefinition
    {
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
