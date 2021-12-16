namespace GildedRoseKata;
public class Concert : IItem
{
    Item _item;
    public Concert(Item item) { _item = item; }

    public void CheckItem(Item _item)
    {
        _item.SellIn = _item.SellIn - 1;

        if (_item.SellIn < 0)
        {
            _item.Quality = _item.Quality - _item.Quality;
        }
        else
        {
            if (_item.Quality < 50)
            {
                if (_item.SellIn < 6)
                {
                    _item.Quality = _item.Quality + 3;
                }
                else if (_item.SellIn < 11)
                {
                    _item.Quality = _item.Quality + 2;
                }
                else
                {
                    _item.Quality = _item.Quality + 1;
                }
            }
        }
    }
}
