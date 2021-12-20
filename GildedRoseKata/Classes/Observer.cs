namespace GildedRoseKata.Classes
{
    public abstract class Observer
    {
        protected Subject _subject;
        public abstract void Update();
    }
}
