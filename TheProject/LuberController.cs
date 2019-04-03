using System.Collections.Generic;
using System.Linq;

namespace TheProject
{
    public class LuberController
    {
        private Dictionary<string,Driver> drivers = new Dictionary<string, Driver>();
        private Dictionary<string,Passenger> passengers = new Dictionary<string, Passenger>();

        public void AddDriver(string name)
        {
            drivers[name] = new Driver {Name = name};
        }

        public void AddPassenger(string name)
        {
            passengers[name] = new Passenger {Name = name};
        }

        public void BookRide(string passengerName, string driverName)
        {
            drivers[driverName].Book(passengers[passengerName]);
        }

        public Passenger GetPassenger(string passengerName)
        {
            return passengers[passengerName];
        }

        public Driver GetDriver(string driverName)
        {
            return drivers[driverName];
        }

        public void BookRide(string passengerName)
        {
            if (drivers.Count == 0)
            {
                throw new NoDriversException();
            }
            BookRide(passengerName,drivers.Values.ElementAt(0).Name);
        }
    }
}