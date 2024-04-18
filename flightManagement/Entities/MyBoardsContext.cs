using Microsoft.EntityFrameworkCore;
namespace flightManagement.Entities

{
    public class MyBoardsContext : DbContext
    {
        public MyBoardsContext(DbContextOptions<MyBoardsContext> options):base(options) 
        {
            
        }
        public DbSet<ListOfFlights> ListsOfFlight { get;set; }
        public DbSet<Location> Locationss { get; set; }
        public DbSet<Plane> Planess { get; set; }
        public DbSet<Arrival> Arrivalss { get; set; }
        public DbSet<Departure> Departuress { get; set; }    

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

            modelBuilder.Entity<Location>()
              .HasOne(u => u.Arrival)
              .WithOne(a => a.Location)
              .HasForeignKey<Location>(a => a.ArrivalId);

            modelBuilder.Entity<Location>()
              .HasOne(u => u.Departure)
              .WithOne(a => a.Location)
              .HasForeignKey<Location>(a => a.DepartureId);

        }

    }
}
