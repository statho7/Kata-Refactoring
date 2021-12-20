using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata.Classes
{
    public class ConcertObserver : Observer
    {
        public ConcertObserver(Subject subject)
        {

        }
        public override void Update()
        {
            Console.WriteLine();
        }
    }
}
