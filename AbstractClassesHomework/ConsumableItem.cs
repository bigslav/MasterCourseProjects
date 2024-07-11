public abstract class ConsumableItem : IConsumable
{
    public int ConsumeCountLeft { get; set; }

    public bool CanConsume()
    {
        return ConsumeCountLeft > 0;
    }

    public void Consume()
    {
        ConsumeCountLeft--;
    }
}

public class ChipsPack : ConsumableItem
{
    public ChipsPack(int chipsCount)
    {
        ConsumeCountLeft = chipsCount;
    }
}