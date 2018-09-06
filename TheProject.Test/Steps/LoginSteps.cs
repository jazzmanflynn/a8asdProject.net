using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TheProject.Model;

namespace TheProject.Test.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private Library library = new Library();
        private Member _member;

        [Given(@"I am a member (.*) and (.*)")]
        public void GivenIAmAMember(string user, string password)
        {
            library.CurrentUser = library.MemberRegister.Find(user, password);
        }


        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            library.Login();
        }

        [Then(@"am logged in")]
        public void ThenAmLoggedIn()
        {
            Assert.IsTrue(library.IsMemberLoggedIn);
        }
    }
}
