namespace GildedRoseTests;
public class checkQualityNoMoreThan50
{
    [Fact]
    public void test()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
        MyRose app = new MyRose(Items);
        app.UpdateQuality();
        Assert.Equal(50, Items[0].Quality);
    }
}
