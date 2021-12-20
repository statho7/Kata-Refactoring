namespace GildedRoseTests;
public class checkLegendarySellInNotDrop
{
    [Fact]
    public void test()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20 } };
        MyRose app = new MyRose(Items);
        app.UpdateQuality();
        Assert.Equal(10, Items[0].SellIn);
    }
}
