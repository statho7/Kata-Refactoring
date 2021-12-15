using System.Collections.Generic;

namespace GildedRoseKata
{
    abstract public class MyItem
    {
        public abstract void CheckItem(Item item);

        public void DecreaseQuality(Item item, int value = 1)
        {
            item.Quality = item.Quality - value;
        }

        public void IncreaseQuality(Item item, int value = 1)
        {
            item.Quality = item.Quality + value;
        }
    }

    public class Brie : MyItem
    {
        Item _item;

        public Brie(Item item) { _item = item; }

        public override void CheckItem(Item _item) {

            _item.SellIn = _item.SellIn - 1;
            if (_item.SellIn < 0)
            {
                if (_item.Quality < 50)
                {
                    IncreaseQuality(_item);
                }
            }
            if (_item.Quality < 50)
            {
                IncreaseQuality(_item);
            }
        }
    }

    public class Concert : MyItem
    {
        Item _item;
        public Concert(Item item) { _item = item; }

        public override void CheckItem(Item _item) {
            _item.SellIn = _item.SellIn - 1;
            if (_item.SellIn < 0)
            {
                _item.Quality = 0;
            }
            else
            {
                if (_item.Quality < 50)
                {
                    if (_item.SellIn < 6)
                    {
                        IncreaseQuality(_item, 3);
                    }
                    else if (_item.SellIn < 11)
                    {
                        IncreaseQuality(_item, 2);
                    }
                    else
                    {
                        IncreaseQuality(_item);
                    }
                }
            }
        }
    }

    public class Other : MyItem
    {
        Item _item;
        public Other(Item item) { _item = item; }

        public override void CheckItem(Item _item) {
            _item.SellIn = _item.SellIn - 1;

            if (_item.SellIn < 0)
            {
                if (_item.Quality > 0)
                {
                    DecreaseQuality(_item);
                }
            }
            if (_item.Quality > 0)
            {
                DecreaseQuality(_item);
            }
        }
    }

    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void DecreaseQuality(Item item, int value = 1)
        {
            item.Quality = item.Quality - value;
        }

        public void IncreaseQuality(Item item, int value = 1)
        {
            item.Quality = item.Quality + value;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                switch (item.Name)
                {
                    case "Aged Brie":
                        Brie brie = new Brie(item);
                        brie.CheckItem(item);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        Concert concert = new Concert(item);
                        concert.CheckItem(item);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    default:
                        Other other = new Other(item);
                        other.CheckItem(item);
                        break;
                }
            }
        }
    }
}
