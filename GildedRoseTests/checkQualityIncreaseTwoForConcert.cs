namespace GildedRoseTests;
public class checkQualityIncreaseTwoForConcert
{
    [Fact]
    public void test()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 8, Quality = 0 } };
        MyRose app = new MyRose(Items);
        app.UpdateQuality();
        Assert.Equal(2, Items[0].Quality);
    }
}