using AutoMapper;
using flightManagement.Entities;
using flightManagement.Models;
using flightManagement.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace flightManagement.Controllers
{
    [Route("flight/")]
    public class FlightController : ControllerBase
    {

        private readonly IFlightService _flightService;
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<FlightListsDto>> GetAll()
        {
            var flightListDto = _flightService.GetAll();


            return Ok(flightListDto);
        }

        [HttpGet("{id}")]
        public ActionResult<FlightListsDto> Get([FromRoute] Guid id)
        {
            var flight = _flightService.GetById(id);
            if (flight is null)
            {
                return NotFound();
            }


            return Ok(flight);
        }

        [HttpPost]
        public ActionResult CreateFlight([FromBody] CreateFlightDto dto)
        {
            var id = _flightService.Create(dto);

            return Created($"/aflight/{id}", null);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] Guid id)
        {
            var isDeleted = _flightService.Delete(id);
            if (isDeleted)
            {
                return NoContent();

            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] UpdateFlightDto dto , [FromRoute] Guid id)
        {
            var isUpdated = _flightService.Update(id, dto);
            if (!isUpdated)
            {
                return NotFound();
            }
            return Ok();
        }

      

    }
}
