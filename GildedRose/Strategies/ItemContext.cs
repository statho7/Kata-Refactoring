namespace GildedRose.Strategies;
public class ItemContext
{
    private readonly IItemStrategy _strategy = null;

    public ItemContext(string name)
    {

        switch (name)
        {
            case "Aged Brie":
                _strategy = new BrieStrategy();
                break;
            case "Backstage passes to a TAFKAL80ETC concert":
                _strategy = new ConcertStrategy();
                break;
            case "Sulfuras, Hand of Ragnaros":
                _strategy = new LegendaryStrategy();
                break;
            default:
                _strategy = new BrieStrategy();
                break;
        }
    }

    public void UpdateItem(Item item)
    {
        _strategy.UpdateItem(item);
    }
}
