namespace GildedRoseKata
{
    public class Item
    {
        public string name { get; set; }
        public int sellIn { get; set; }
        public int quality { get; set; }

        internal Item(string name, int sellIn, int quality)
        {
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int SellIn
        {
            get { return this.sellIn; }
        }

        public int Quality
        {
            get { return this.quality; }
        }
    }
}
