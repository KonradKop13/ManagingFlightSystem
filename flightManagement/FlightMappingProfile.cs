using AutoMapper;
using flightManagement.Entities;
using flightManagement.Models;

namespace flightManagement
{
    public class FlightMappingProfile : Profile
    {
       

        public FlightMappingProfile()
        {
            CreateMap<ListOfFlights, FlightListsDto>()
                .ForMember(m => m.PlaneType, c => c.MapFrom(s => s.Plane.PlaneType))
                .ForMember(m => m.SerialNumber, c => c.MapFrom(s => s.Plane.SerialNumber))
                .ForMember(m => m.ArrivalDate, c => c.MapFrom(s => s.Arrival.ArrivalDate))
                .ForMember(m => m.DepurtureDate, c => c.MapFrom(s => s.Departure.DepurtureDate))
                .ForMember(m => m.CityArrival, c => c.MapFrom(s => s.Arrival.Location.City))
                .ForMember(m => m.AirportNameArrival, c => c.MapFrom(s => s.Arrival.Location.AirportName))
                .ForMember(m => m.CityDepurture, c => c.MapFrom(s => s.Departure.Location.City))
                .ForMember(m => m.DepurtureAirportName, c => c.MapFrom(s => s.Departure.Location.AirportName));


            CreateMap<CreateFlightDto, ListOfFlights>()
              .ForMember(r => r.Plane,
               c => c.MapFrom(dto => new Plane()
               { PlaneType = dto.PlaneType, SerialNumber = dto.SerialNumber }));

            CreateMap<CreateFlightDto, ListOfFlights>()
               .ForMember(r => r.Arrival,
               c => c.MapFrom(dto => new Arrival()
               { ArrivalDate = dto.ArrivalDate,  }));
            
            CreateMap<LocationDto, Arrival>()
               .ForMember(r => r.Location,
               c => c.MapFrom(dto => new Location()
               { City = dto.City, AirportName = dto.AirportName }));

            CreateMap<LocationDto, Departure>()
              .ForMember(r => r.Location,
              c => c.MapFrom(dto => new Location()
              { City = dto.City, AirportName = dto.AirportName }));

            CreateMap<CreateFlightDto, ListOfFlights>()
              .ForMember(r => r.Departure,
              c => c.MapFrom(dto => new Departure()
              { DepurtureDate = dto.DepurtureDate }));


         
        }
    }
}
