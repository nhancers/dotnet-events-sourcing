using System.Threading;
using System.Threading.Tasks;
using api.Models.Events;
using api.Models.Request;
using api.Models.Response;
using MediatR;

namespace api.Handlers.Implementations
{
    public class CreateStockInformationHandler : IRequestHandler<CreateStockRequest, CreateNewStockResult>
    {
        private readonly IMediator _mediator;
        public CreateStockInformationHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CreateNewStockResult> Handle(CreateStockRequest request, CancellationToken cancellationToken)
        {
            var result = await Task.FromResult(new CreateNewStockResult
            {
                Ticker = request.Ticker
            });

            await _mediator.Publish(new StockCreatedEvent
            {
                Ticker = request.Ticker
            }, cancellationToken);

            return result;
        }
    }
}