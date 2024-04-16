namespace flightManagement.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string City {  get; set; }
        public string AirportName {  get; set; }
        public ListOfFlights ListOfFlights { get; set; }
        public Arrival Arrival { get; set; }
        public Departure Departure { get; set; }
    }
}
