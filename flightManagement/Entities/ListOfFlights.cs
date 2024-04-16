using System.ComponentModel.DataAnnotations;

namespace flightManagement.Entities
{
    public class ListOfFlights
    {
        [Key]
        public Guid FlightNumber {  get; set; }
        public Plane Plane { get; set; }
        public Guid PlaneId { get; set; }
        public Arrival Arrival { get; set; }
        public Guid ArrivalId { get; set; }
        public Departure Departure { get; set; }
        public Guid DepartureId { get; set; } 
    }
}
