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

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Cinema>> UpdateCinema([FromRoute] Guid id, UpdateCinemaRequest updateCinemaRequest)
        {
            var updateCommand = new UpdateCinemaCommand
            {
                Id = id,
                Name = updateCinemaRequest.Name,
                Street = updateCinemaRequest.Street,
                City = updateCinemaRequest.City,
                NumberOfAuditoriums = updateCinemaRequest.NumberOfAuditoriums
            };

            var cinema = await _mediator.Send(updateCommand);

            if (cinema is null)
            {
                return NotFound();
            }
            return Ok(cinema);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCinema([FromRoute] Guid id)
        {
            var command = new DeleteCinemaCommand { Id = id };

            await _mediator.Send(command);

            return NoContent();
        }
    }
}