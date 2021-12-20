namespace GildedRoseKata;
public class Other : IItem
{
    Item _item;
    public Other(Item item) { _item = item; }

    public void CheckItem(Item _item)
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
