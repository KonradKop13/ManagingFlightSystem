using System.Diagnostics.Eventing.Reader;

namespace flightManagement.Models
{
    public class UpdateFlightDto
    {
        public string PlaneType { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepurtureDate { get; set; }
        
    }
}
