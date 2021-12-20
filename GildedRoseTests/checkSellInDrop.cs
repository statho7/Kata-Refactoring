namespace GildedRoseTests;
public class checkSellInDrop
{
    [Fact]
    public void test()
    {
        IList<Item> Items = new List<Item> { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 } };
        MyRose app = new MyRose(Items);
        app.UpdateQuality();
        Assert.Equal(9, Items[0].SellIn);
    }
}
