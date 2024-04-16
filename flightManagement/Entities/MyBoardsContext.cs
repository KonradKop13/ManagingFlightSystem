using Microsoft.EntityFrameworkCore;
namespace flightManagement.Entities

{
    public class MyBoardsContext : DbContext
    {
        public MyBoardsContext(DbContextOptions<MyBoardsContext> options):base(options) 
        {
            
        }
        public DbSet<ListOfFlights> ListOfFlight { get;set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Arrival> Arrivals { get; set; }
        public DbSet<Departure> Departures { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListOfFlights>()
                .HasOne(u => u.Arrival)
                .WithOne(a => a.ListOfFlights)
                .HasForeignKey<ListOfFlights>(a => a.ArrivalId);

            modelBuilder.Entity<ListOfFlights>()
               .HasOne(u => u.Departure)
               .WithOne(a => a.ListOfFlights)
               .HasForeignKey<ListOfFlights>(a => a.DepartureId);

            modelBuilder.Entity<ListOfFlights>()
               .HasOne(u => u.Plane)
               .WithOne(a => a.ListOfFlights)
               .HasForeignKey<ListOfFlights>(a => a.PlaneId);

            modelBuilder.Entity<Arrival>()
              .HasOne(u => u.Location)
              .WithOne(a => a.Arrival)
              .HasForeignKey<Arrival>(a => a.LocationId);

            modelBuilder.Entity<Departure>()
              .HasOne(u => u.Location)
              .WithOne(a => a.Departure)
              .HasForeignKey<Departure>(a => a.LocationId);

        }

    }
}
