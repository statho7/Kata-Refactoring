namespace GildedRoseKata.Classes
{
    public class BrieObserver : Observer
    {
        public BrieObserver(Subject subject)
        {

        }
        public override void Update()
        {
            Console.WriteLine();
        }
    }
}
