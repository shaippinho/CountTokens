using MediatR;
using Microsoft.AspNetCore.Mvc;
using OpenAI.Tokenizer.Domain.Domain;

namespace OpenAI.Tokenizer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenizerController : ControllerBase
    {
        private readonly ILogger<TokenizerController> _logger;
        private readonly IMediator _mediator;

        public TokenizerController(ILogger<TokenizerController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("count")]
        public async Task<IActionResult> Count(CountCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

    }
}
