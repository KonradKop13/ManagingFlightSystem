namespace flightManagement.Entities
{
    public class Arrival
    {
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public ListOfFlights ListOfFlights { get; set; }
        public Location Location { get; set; }
        
    }
}
