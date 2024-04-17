using AutoMapper;
using flightManagement.Entities;
using flightManagement.Models;

namespace flightManagement
{
    public class FlightMappingProfile : Profile
    {
        public FlightMappingProfile()
        {
            CreateMap<CreateFlightDto, ListOfFlights>()
                    .ForMember(r => r.Plane,
                    c => c.MapFrom(dto => new Plane()
                    { PlaneType = dto.PlaneType, SerialNumber = dto.SerialNumber }));

            CreateMap<CreateFlightDto, ListOfFlights>()
               .ForMember(r => r.Arrival,
               c => c.MapFrom(dto => new Arrival()
               { ArrivalDate = dto.ArrivalDate }));

            CreateMap<CreateFlightDto, ListOfFlights>()
              .ForMember(r => r.Departure,
              c => c.MapFrom(dto => new Departure()
              { DepurtureDate = dto.DepurtureDate }));


         
        }
    }
}
