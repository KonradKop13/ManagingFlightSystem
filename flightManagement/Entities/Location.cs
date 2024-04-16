namespace flightManagement.Entities
{
    public class Location
    {
        public Guid Id { get; set; }
        public string City {  get; set; }
        public string AirportName {  get; set; }
        public Arrival Arrival { get; set; }
        public Guid ArrivalId { get; set; }
        public Departure Departure { get; set; }
        public Guid DepartureId { get; set; }
    }
}
