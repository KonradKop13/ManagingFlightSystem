using System.ComponentModel.DataAnnotations;

namespace flightManagement.Entities
{
    public class ListOfFlights
    {
        [Key]
        public int FlightNumber {  get; set; }
        public Plane Plane { get; set; }
        public int PlaneId { get; set; }
        public Arrival Arrival { get; set; }
        public int ArrivalId { get; set; }
        public Departure Departure { get; set; }
        public int DepartureId { get; set; } 
    }
}
