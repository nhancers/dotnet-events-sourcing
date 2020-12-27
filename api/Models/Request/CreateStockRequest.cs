using api.Models.Response;
using MediatR;

namespace api.Models.Request
{
    public class CreateStockRequest : IRequest<CreateNewStockResult>
    {
        public string Ticker { get; set; }

        public string Name { get; set; }
    }
}