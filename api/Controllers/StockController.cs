using System.Threading.Tasks;
using api.Models.Request;
using api.Models.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StockController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{ticker}")]
        public async Task<Stock> Get([FromRoute] string ticker)
        {
            var stock = await _mediator.Send(new GetStockQuery { Ticker = ticker });
            return stock;
        }

        [HttpPost]
        public async Task<CreatedAtActionResult> Create(CreateStockRequest createStockRequest)
        {
            var result = await _mediator.Send(createStockRequest);
            return CreatedAtAction(nameof(Get), new { ticker = createStockRequest.Ticker }, result);
        }
    }
}
