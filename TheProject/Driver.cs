namespace TheProject
{
    public class Driver
   {
        private Passenger passenger;
        public bool IsBooked { get; set; }
        public string Name { get; set; }

        public void Book(Passenger newPassenger)
        {
            IsBooked = true;
            passenger = newPassenger;
	 }

        public Passenger BookedBy()
        {
            return passenger;
        }
    }
}
