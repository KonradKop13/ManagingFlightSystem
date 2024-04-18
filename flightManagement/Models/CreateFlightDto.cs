namespace flightManagement.Models
{
    public class CreateFlightDto
    {
        public string PlaneType { get; set; }
        public string SerialNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepurtureDate { get; set; }
        public string? CityDepurture { get; set; }
        public string? DepurtureAirportName { get; set; }

        public string? CityArrival { get; set; }
        public string? AirportNameArrival { get; set; }

    }
}
