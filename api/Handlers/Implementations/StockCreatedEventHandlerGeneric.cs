using System.Threading;
using System.Threading.Tasks;
using api.Models.Events;
using MediatR;

namespace api.Handlers.Implementations
{
    public class StockCreatedEventHandlerGeneric : INotificationHandler<StockCreatedEvent>
    {
        public Task Handle(StockCreatedEvent notification, CancellationToken cancellationToken)
        {
            System.Console.WriteLine($"{typeof(StockCreatedEventHandlerGeneric)}_{typeof(StockCreatedEvent)} handled for {notification.Ticker}");
            return Task.CompletedTask;
        }
    }
}