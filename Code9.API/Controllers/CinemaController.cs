using Code9.API.Models;
using Code9.Domain.Commands;
using Code9.Domain.Models;
using Code9.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Code9.API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CinemaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CinemaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cinema>>> GetAllCinemas()
        {
            var query = new GetAllCinemasQuery();
            var result = _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]

        public async Task<ActionResult<List<Cinema>>> AddCinema(AddCinemaRequest addCinemaRequest)
        {
            var command = new AddCinemaCommand
            {
                City = addCinemaRequest.City,
                Name = addCinemaRequest.Name,
                NumberOfAuditoriums = addCinemaRequest.NumberOfAuditoriums,
                Street = addCinemaRequest.Street
            };

            var result = await _mediator.Send(command);

            //return Ok(result);
            return CreatedAtAction(nameof(GetAllCinemas), new { id = result.Id }, result);
        }
    }
}