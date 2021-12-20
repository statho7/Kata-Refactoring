using GildedRose.Strategies;

namespace GildedRoseKata;
public class GildedRose
{
    IList<Item> Items;
    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        ItemFactory itemFactory = new ItemFactory();
        Items.ToList().ForEach(item =>
        {
            //var myItem = itemFactory.getItem(item, item.Name);
            //myItem.CheckItem(item);

            var context = new ItemContext(item.Name);
            context.UpdateItem(item);
        });
    }
}
