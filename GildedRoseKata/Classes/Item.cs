global using GildedRose.Strategies;

namespace GildedRoseKata
{
    //public class Item
    //{
    //    public string Name { get; set; }
    //    public int SellIn { get; set; }
    //    public int Quality { get; set; }
    //}

    public class Item : IObserver
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update()
        {
            try
            {
                IItemStrategy strategy = StrategyDictionary.keyValuePairs[Name];
                strategy.UpdateItem(this);
            }
            catch (Exception)
            {
                IItemStrategy strategy = new OtherStrategy();
                strategy.UpdateItem(this);
            }
        }
    }

    public static class StrategyDictionary
    {
        public static Dictionary<string, IItemStrategy> keyValuePairs;
        static StrategyDictionary() { 
            keyValuePairs = new Dictionary<string,IItemStrategy>();
            keyValuePairs.Add("Aged Brie", new BrieStrategy());
            keyValuePairs.Add("Backstage passes to a TAFKAL80ETC concert", new ConcertStrategy());
            keyValuePairs.Add("Sulfuras, Hand of Ragnaros", new LegendaryStrategy());

        }
    }
}
