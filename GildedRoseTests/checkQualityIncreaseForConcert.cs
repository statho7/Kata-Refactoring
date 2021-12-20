namespace GildedRoseTests;
public class checkQualityIncreaseForConcert
{
    [Fact]
    public void test()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 12, Quality = 0 } };
        MyRose app = new MyRose(Items);
        app.UpdateQuality();
        Assert.Equal(1, Items[0].Quality);
    }
}
