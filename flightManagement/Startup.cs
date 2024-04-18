using flightManagement.Entities;
using flightManagement.Services;
using AutoMapper;

namespace flightManagement
{
    public class Startup
    {

        public Startup(IConfiguration configuration) { 
        Configuration = configuration;
        }
        public IConfiguration Configuration { get;  }

        public void ConfigureServices(IServiceCollection servicec)
        {
            servicec.AddControllers();
            servicec.AddDbContext<MyBoardsContext>();
            servicec.AddAutoMapper(this.GetType().Assembly);
            servicec.AddScoped<IFlightService, FlightService>();

        }

    }
}
