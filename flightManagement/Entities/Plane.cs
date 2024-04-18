namespace flightManagement.Entities
{
    public class Plane
    {
        public Guid Id {  get; set; }
        public string PlaneType {  get; set; }
        public string SerialNumber {  get; set; }
        public ListOfFlights ListOfFlights { get; set; }
    }
}
