global using GildedRoseKata.Interfaces;
global using GildedRoseKata.Classes;

namespace GildedRoseKata;

public class Subject : ISubject
{ 
    // List of subscribers. In real life, the list of subscribers can be
    // stored more comprehensively (categorized by event type, etc.).
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        //Console.WriteLine("Subject: Attached an observer.");
        this._observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        this._observers.Remove(observer);
        //Console.WriteLine("Subject: Detached an observer.");
    }

    // Trigger an update in each subscriber.
    public void Notify()
    {
        //Console.WriteLine("Subject: Notifying observers...");

        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}

//{
//    public class Subject : ISubject
//    {
//        // For the sake of simplicity, the Subject's state, essential to all
//        // subscribers, is stored in this variable.
//        public string Name { get; set; }
//        public int SellIn { get; set; }
//        public int Quality { get; set; }

//        // List of subscribers. In real life, the list of subscribers can be
//        // stored more comprehensively (categorized by event type, etc.).
//        private List<IObserver> _observers = new List<IObserver>();

//        // The subscription management methods.
//        public void Attach(IObserver observer)
//        {
//            Console.WriteLine("Subject: Attached an observer.");
//            this._observers.Add(observer);
//        }

//        public void Detach(IObserver observer)
//        {
//            this._observers.Remove(observer);
//            Console.WriteLine("Subject: Detached an observer.");
//        }

//        // Trigger an update in each subscriber.
//        public void Do()
//        {
//            Console.WriteLine("Subject: Notifying observers...");

//            foreach (var observer in _observers)
//            {
//                observer.Update(this);
//            }
//        }

//        // Usually, the subscription logic is only a fraction of what a Subject
//        // can really do. Subjects commonly hold some important business logic,
//        // that triggers a notification method whenever something important is
//        // about to happen (or after it).
//        public IObserver SomeBusinessLogic()
//        {
//            switch (Name)
//            {
//                case "Aged Brie":
//                    return new BrieObserver(new Subject()
//                    {
//                        Name = Name,
//                        SellIn = SellIn,
//                        Quality = Quality
//                    });
//                case "Backstage passes to a TAFKAL80ETC concert":
//                    return new ConcertObserver(new Subject()
//                    {
//                        Name = Name,
//                        SellIn = SellIn,
//                        Quality = Quality
//                    });
//                case "Sulfuras, Hand of Ragnaros":
//                    return new LegendaryObserver(new Subject()
//                    {
//                        Name = Name,
//                        SellIn = SellIn,
//                        Quality = Quality
//                    });
//                default:
//                    return new OtherObserver(new Subject()
//                    {
//                        Name = Name,
//                        SellIn = SellIn,
//                        Quality = Quality
//                    });
//            }
//        }
//    }
//}
