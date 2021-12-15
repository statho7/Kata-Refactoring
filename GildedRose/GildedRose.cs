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

        public override void CheckItem(Item item) {

            item.SellIn = item.SellIn - 1;
            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    IncreaseQuality(item);
                }
            }
            if (item.Quality < 50)
            {
                IncreaseQuality(item);
            }
        }
    }

    public class Concert : MyItem
    {
        Item _item;
        public Concert(Item item) { _item = item; }

        public override void CheckItem(Item item) {
            item.SellIn = item.SellIn - 1;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else
            {
                if (item.Quality < 50)
                {
                    if (item.SellIn < 6)
                    {
                        IncreaseQuality(item, 3);
                    }
                    else if (item.SellIn < 11)
                    {
                        IncreaseQuality(item, 2);
                    }
                    else
                    {
                        IncreaseQuality(item);
                    }
                }
            }
        }
    }

    public class Other : MyItem
    {
        Item _item;
        public Other(Item item) { _item = item; }

        public override void CheckItem(Item item) {
            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    DecreaseQuality(item);
                }
            }
            if (item.Quality > 0)
            {
                DecreaseQuality(item);
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
