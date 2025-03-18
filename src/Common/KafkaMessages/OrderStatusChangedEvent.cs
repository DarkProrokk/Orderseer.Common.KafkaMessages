using Entities;

namespace KafkaMessages;

public class OrderStatusChangedEvent
{
    public Guid OrderId { get; set; }
    
    public required Status Status { get; set; }
}

public class Status
{
    public OrderStatus Code { get; set; } 
    public string Name { get; set; }
}