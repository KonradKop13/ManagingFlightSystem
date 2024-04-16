namespace flightManagement.Entities
{
    public class Departure
    {
        public Guid Id { get; set; }
        public DateTime DepurtureDate { get; set; }
        public ListOfFlights ListOfFlights { get; set; }
        public Location Location { get; set; }
        

    }
}
