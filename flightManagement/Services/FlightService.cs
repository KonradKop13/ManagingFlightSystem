using AutoMapper;
using flightManagement.Entities;
using flightManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace flightManagement.Services
{
    public interface IFlightService
    {
        FlightListsDto GetById(Guid id);
        IEnumerable<FlightListsDto> GetAll();
        Guid Create(CreateFlightDto dto);
        bool Delete(Guid id);
        bool Update(Guid id, UpdateFlightDto dto);
    }

    public class FlightService : IFlightService
    {
        private readonly MyBoardsContext _dbContext;
        private readonly IMapper _mapper;

        public FlightService(MyBoardsContext dbContext , IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper= mapper;
        }


        public FlightListsDto GetById(Guid id)
        {
            var flight = _dbContext
             .ListsOfFlight
             .Include(r => r.Plane)
             .Include(r => r.Arrival)
             .Include(r => r.Departure)
             .FirstOrDefault(r => r.FlightNumber == id);

            if (flight is null) return null;

            var result = _mapper.Map<FlightListsDto>(flight);
            return result;
        }

        public IEnumerable <FlightListsDto> GetAll()
        {
            var flight = _dbContext
             .ListsOfFlight
             .Include(r => r.Plane)
             .Include(r => r.Arrival)
             .Include(r => r.Departure)
             .ToList();
            var flightsDtos = _mapper.Map<List<FlightListsDto>>(flight);
            return flightsDtos;
        }

        public Guid Create(CreateFlightDto dto)
        {
            var flight = _mapper.Map<ListOfFlights>(dto);
            _dbContext.ListsOfFlight.Add(flight);
            _dbContext.SaveChanges();
            return flight.FlightNumber;
        }
      
        public bool Delete(Guid id)
        {

            var flight = _dbContext
             .ListsOfFlight
             .FirstOrDefault(r => r.FlightNumber == id);

            if (flight is null) return false;

            _dbContext.ListsOfFlight.Remove(flight);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Guid id , UpdateFlightDto dto)
        {
            var flight = _dbContext
             .ListsOfFlight
             .FirstOrDefault(r => r.FlightNumber == id);

            if (flight is null) return false;

            flight.Plane.PlaneType = dto.PlaneType;
            flight.Plane.SerialNumber = dto.SerialNumber;
            flight.Arrival.ArrivalDate = dto.ArrivalDate;
            flight.Departure.DepurtureDate = dto.DepurtureDate; 

            _dbContext.SaveChanges() ; return true;
    }
        
        
    }
}
