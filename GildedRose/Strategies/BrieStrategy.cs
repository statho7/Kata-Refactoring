namespace GildedRose.Strategies;
public class BrieStrategy : IItemStrategy
{
    public void UpdateItem(Item _item)
    {
        _item.SellIn = _item.SellIn - 1;

        if (_item.SellIn < 0)
        {
            if (_item.Quality < 50)
            {
                _item.Quality = _item.Quality + 1;
            }
        }
        if (_item.Quality < 50)
        {
            _item.Quality = _item.Quality + 1;
        }
    }
}
