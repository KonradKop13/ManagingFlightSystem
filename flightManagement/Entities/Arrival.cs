namespace flightManagement.Entities
{
    public class Arrival
    {
        public int Id { get; set; }
        public int IdLocation { get; set; }
        public DateTime ArrivalDate { get; set; }
        public ListOfFlights ListOfFlights { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
    }
}
