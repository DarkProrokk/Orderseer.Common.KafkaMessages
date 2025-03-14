namespace KafkaMessages;

public class OrderCreatedForProductEvent
{
    public Guid OrderReference { get; set; }
    
    public List<Guid> ItemsReference { get; set; } = null!;

    public bool Validate()
    {
        return OrderReference != default && ItemsReference.Count > 1 ;
    }
}