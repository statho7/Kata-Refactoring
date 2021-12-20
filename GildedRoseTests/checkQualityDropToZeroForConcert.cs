namespace GildedRoseTests;
public class checkQualityDropToZeroForConcert
{
    [Fact]
    public void test()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 52 } };
        MyRose app = new MyRose(Items);
        app.UpdateQuality();
        Assert.Equal(0, Items[0].Quality);
    }
}