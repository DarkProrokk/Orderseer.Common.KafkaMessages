namespace KafkaMessages;

public class OrderCreatedForProcessingEvent
{
    public Guid OrderReference { get; set; }
    public bool Validate()
    {
        return OrderReference != default;
    }
}