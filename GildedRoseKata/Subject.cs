global using GildedRoseKata.Classes;

namespace GildedRoseKata
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int getState()
        {
            return state;
        }

        public void setState(int state)
        {
            this.state = state;
            notifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            for (Observer observer : observers)
            {
                observer.update();
            }
        }
    }
}
