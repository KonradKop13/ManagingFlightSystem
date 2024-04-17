namespace flightManagement.Models
{
    public class ArrivalDto
    {
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string City { get; set; }
        public string AirportName { get; set; }
    }
}
