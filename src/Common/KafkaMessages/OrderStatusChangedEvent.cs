namespace KafkaMessages;

public class OrderStatusChangedEvent
{
    public Guid OrderId { get; set; }
    
    public required Status Status { get; set; }
}

public class Status
{
    public int code { get; set; } 
    public string name { get; set; }
}