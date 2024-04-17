namespace flightManagement.Models
{
    public class DeoartureDto
    {
        public Guid Id { get; set; }
        public DateTime DepurtureDate { get; set; }
        public string City { get; set; }
        public string AirportName { get; set; }
    }
}
