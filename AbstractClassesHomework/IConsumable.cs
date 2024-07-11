public interface IConsumable
{
    public int ConsumeCountLeft { get; set; }
    bool CanConsume();
    void Consume();
}