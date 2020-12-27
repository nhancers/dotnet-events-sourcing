using System.Threading;
using System.Threading.Tasks;
using api.Models.Events;
using MediatR;

namespace api.Handlers.Implementations
{
    public class SyncStockInWarehouseHandler : INotificationHandler<StockCreatedEvent>
    {
        public Task Handle(StockCreatedEvent notification, CancellationToken cancellationToken)
        {
            System.Console.WriteLine($"{typeof(SyncStockInWarehouseHandler)}_{typeof(StockCreatedEvent)} handled for {notification.Ticker}");
            return Task.CompletedTask;
        }
    }
}