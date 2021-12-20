namespace GildedRoseKata;
public class ItemFactory
{
    public IItem getItem(Item item, string name)
    {
        switch (item.Name)
        {
            case "Aged Brie":
                return new Brie(item);
            case "Backstage passes to a TAFKAL80ETC concert":
                return new Concert(item);
            case "Sulfuras, Hand of Ragnaros":
                return new Legendary(item);
            default:
                return new Other(item);
        }
    }
    //public IItem getStrategy(Item item, string name)
    //{
    //    switch (item.Name)
    //    {
    //        case "Aged Brie":
    //            return new Brie(item);
    //        case "Backstage passes to a TAFKAL80ETC concert":
    //            return new Concert(item);
    //        case "Sulfuras, Hand of Ragnaros":
    //            return new Legendary(item);
    //        default:
    //            return new Other(item);
    //    }
    //}
}
