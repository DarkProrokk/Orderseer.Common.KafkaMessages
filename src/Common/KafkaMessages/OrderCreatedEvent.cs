namespace KafkaMessages;

public class OrderCreatedEvent
{
    public Guid UserReference { get; set; }
    public Guid OrderReference { get; set; }

    public bool Validate()
    {
        return UserReference != default && OrderReference != default;
    }
}