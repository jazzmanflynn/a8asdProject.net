using NUnit.Framework;
using TheProject.Model;

namespace TheProject.Test.Unit
{
    [TestFixture]
    public class DummyTests
    {
        [Test]

        public void LoginFailureTest()
        {
            string nonMemberUserName = "nonmemberUsername";
            string nonMemberUserPassword = "nonmemberPassword";

            var library = new Library
            {
                CurrentUser = new Member { Username = nonMemberUserName, Password = nonMemberUserPassword }
            };
            library.Login();

            Assert.IsFalse(library.IsMemberLoggedIn);
        }
    }
}
