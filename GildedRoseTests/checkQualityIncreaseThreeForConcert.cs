namespace GildedRoseTests;
public class checkQualityIncreaseThreeForConcert
{
    [Fact]
    public void test()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 43 } };
        MyRose app = new MyRose(Items);
        app.UpdateQuality();
        Assert.Equal(46, Items[0].Quality);
    }
}