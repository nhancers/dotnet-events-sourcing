using System.Threading;
using System.Threading.Tasks;
using api.Models.Request;
using api.Models.Response;
using MediatR;

namespace api.Handlers.Implementations
{
    public class GetStockInformationHandler : IRequestHandler<GetStockQuery, Stock>
    {
        public Task<Stock> Handle(GetStockQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult<Stock>(new Stock
            {
                Name = $"test_{request.Ticker}",
                Ticker = request.Ticker
            });
        }
    }
}