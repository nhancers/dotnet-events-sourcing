using api.Models.Response;
using MediatR;

namespace api.Models.Request
{
    public class GetStockQuery : IRequest<Stock>
    {
        public string Ticker { get; set; }
    }
}