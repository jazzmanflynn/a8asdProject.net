using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TheProject.Test.Unit
{
    public class LuberControllerTest
    {
        [Test]
        public void BookRideThrowsExceptionWhenNoDriverAvailable()
        {
            var luber = new LuberController();
            luber.AddPassenger("pat");
            Assert.Throws<NoDriversException>(()=>luber.BookRide("pat"));
        }
    }
}
