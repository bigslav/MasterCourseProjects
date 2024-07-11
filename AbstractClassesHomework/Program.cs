IConsumable consumableItem = new ChipsPack(5);

while (consumableItem.CanConsume())
{
    consumableItem.Consume();
    Console.WriteLine("1 chip consumed");
}

Console.ReadLine();