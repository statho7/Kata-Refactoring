namespace GildedRose.Strategies;
public class OtherStrategy : IItemStrategy
{
    public void UpdateItem(Item _item)
    {
        _item.SellIn = _item.SellIn - 1;

        if (_item.SellIn < 0)
        {
            if (_item.Quality > 0)
            {
                _item.Quality = _item.Quality - 1;
            }
        }
        if (_item.Quality > 0)
        {
            _item.Quality = _item.Quality - 1;
        }
    }
}
