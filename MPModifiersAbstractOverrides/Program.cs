var unoDeck = new UnoDeck();
unoDeck.GenerateDeckCards();
unoDeck.Shuffle();

List<UnoCard> hand = unoDeck.DrawCards(4);

foreach (UnoCard unoCard in hand)
{
    Console.WriteLine($"{unoCard.Value} of {unoCard.Color}");
}

unoDeck.DiscardCards(hand);

Console.ReadLine();

public class UnoDeck : Deck<UnoCard>
{
    public override void GenerateDeckCards()
    {
        for (int value = 0; value < 13; value++)
        {
            for (int color = 0; color < 4; color++)
            {
                _deckCards.Add(new UnoCard((UnoCardValue)value, (UnoCardColor)color));
            }
        }

        for (int value = 13; value < 15; value++)
        {
            _deckCards.Add(new UnoCard((UnoCardValue)value, UnoCardColor.Any));
            _deckCards.Add(new UnoCard((UnoCardValue)value, UnoCardColor.Any));
        }
    }
}

public abstract class Deck<T> where T : Card
{
    protected List<T> _deckCards = new();
    protected List<T> _drawPile = new();
    protected List<T> _discardPile = new();

    public abstract void GenerateDeckCards();

    public virtual void Shuffle()
    {
        var rnd = new Random();
        _drawPile = _deckCards.OrderBy(x => rnd.Next()).ToList();
    }

    public List<T> DrawCards(int count)
    {
        var cardsToDeal = new List<T>();
        for (int i = 0; i < count; i++)
        {
            T? firstCard = _drawPile.FirstOrDefault();

            if (firstCard != null)
            {
                cardsToDeal.Add(firstCard);
                _drawPile.Remove(firstCard);
            }
            else
                break;
        }

        return cardsToDeal;
    }

    public void DiscardCards(List<T> cards)
    {
        _discardPile.AddRange(cards);
    }
}

public abstract class Card
{
}

public class UnoCard : Card
{
    public UnoCardValue Value { get; private set; }
    public UnoCardColor Color { get; private set; }

    public UnoCard(UnoCardValue value, UnoCardColor color)
    {
        Value = value;
        Color = color;
    }
}

public enum UnoCardValue
{
    Zero,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Skip,
    Reverse,
    DrawTwo,
    Wild,
    WildDrawFour
}

public enum UnoCardColor
{
    Green,
    Blue,
    Yellow,
    Red,
    Any
}