using BoDi;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace TheProject.Test
{
    [Binding]
    public class BookRideSteps
    {
        private readonly LuberController luber;

        public BookRideSteps(LuberController luber)
        {
            this.luber = luber;
        }

        [Given(@"(.*) is a driver")]
        public void GivenDaniIsADriver(string name)
        {
            luber.AddDriver(name);
        }

        [Given(@"these passengers")]
        public void GivenThesePassengers(Table table)
        {
            var passengers = table.CreateSet<Passenger>();
            foreach (var passenger in passengers)
            {
                luber.AddPassenger(passenger.Name);
            }
        }

        [Given(@"(.*) is a passenger")]
        public void GivenPatIsAPassenger(string name)
        {
            luber.AddPassenger(name);
        }

        [Given(@"these drivers")]
        public void GivenTheseDrivers(Table table)
        {
            var newDrivers = table.CreateSet<Driver>();
            foreach (var driver in newDrivers)
            {
                luber.AddDriver(driver.Name);
            }
        }

        [When(@"(.*) books a ride with (.*)")]
        public void WhenPatBooksARide(string passengerName,string driverName)
        {
            luber.BookRide(passengerName, driverName);
        }
        [When(@"(.*) books a ride")]
        public void WhenAnyoneBooksARide(string passengerName)
        {
            luber.BookRide(passengerName);
        }

        [Then(@"(.*) is booked by (.*)")]
        public void ThenDaniIsBooked(string driverName,string passengerName)
        {
            Assert.AreEqual(luber.GetPassenger(passengerName), luber.GetDriver(driverName).BookedBy());
        }

        [Then(@"these results are expected")]
        public void ThenTheseResultsAreExpected(Table table)
        {
            var results = table.CreateSet<Results>();
            foreach (var result in results)
            {
                Assert.AreEqual(result.IsBooked, luber.GetDriver(result.Driver).IsBooked);
            }
        }
    }

    public class Results
    {
        public string Driver;
        public string Passenger;
        public bool IsBooked;
    }
}
