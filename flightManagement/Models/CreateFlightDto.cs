using System.ComponentModel.DataAnnotations;

namespace flightManagement.Models
{
    public class CreateFlightDto
    {

        [Key]
        public Guid FlightNumber { get; set; }
        public string PlaneType { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepurtureDate { get; set; }
    }
}
