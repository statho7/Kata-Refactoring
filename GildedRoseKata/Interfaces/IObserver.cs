namespace GildedRoseKata.Classes
{

    public interface IObserver
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public void Update();
    }
}
