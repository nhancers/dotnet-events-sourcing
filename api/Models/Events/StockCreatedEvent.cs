using MediatR;

namespace api.Models.Events
{
    public class StockCreatedEvent : INotification
    {
        public string Ticker { get; set; }
    }
}