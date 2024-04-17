using AutoMapper;
using flightManagement.Entities;
using flightManagement.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace flightManagement.Controllers
{
    [Route("flight/")]
    public class FlightController : ControllerBase
    {

        private readonly MyBoardsContext _dbContext;
        private readonly IMapper _mapper;
        public FlightController(MyBoardsContext dbCountext) {
            _dbContext = dbCountext;
        }

        public ActionResult<IEnumerable<ListOfFlights>> GetAll()
        {
            var flight = _dbContext.ListsOfFlight.ToList();
            return Ok(flight);
        }

        [HttpGet("{id}")]
        public ActionResult<ListOfFlights> Get([FromRoute] Guid id)
        {
            var flight = _dbContext.ListsOfFlight.FirstOrDefault(r => r.FlightNumber == id);
            if (flight is null)
            {
                return NotFound();
            }
            return Ok(flight);
        }

        [HttpPost]
        public ActionResult CreateFlight([FromBody] CreateFlightDto dto)
        {
            var flight = _mapper.Map<ListOfFlights>(dto);
            _dbContext.ListsOfFlight.Add(flight);
            _dbContext.SaveChanges();

            return Created($"/aflight/{flight.FlightNumber}", null);
        }

      

    }
}
