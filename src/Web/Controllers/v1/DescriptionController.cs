using Application.Commands;
using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.ApiModels.v1.Request;

namespace Web.Controllers.v1
{

    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]
    [EnableCors("AllowSpecificOrigin")]
    public class DescriptionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DescriptionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetAll());

            if (response is null)
                return BadRequest();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var response = await _mediator.Send(new GetById(id));

            if (response is null)
                return BadRequest();

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DescriptionRequest opinion)
        {
            var response = await _mediator.Send(new Create(opinion));

            if (response is null)
                return BadRequest();

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put(string id, DescriptionRequest opinion)
        {
            opinion.Id = id;
            await _mediator.Send(new Update(id, opinion));

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _mediator.Send(new Remove(id));

            return Ok();
        }
    }
}