using Xunit;
using System.Collections.Generic;
using GildedRoseKata;
using System;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            GildedRose app = new GildedRose(Items);

            string output = "";
            string expected = "+5 Dexterity Vest, -20, 0\n"+
                "Aged Brie, -28, 50\n" +
                "Elixir of the Mongoose, -25, 0\n" +
                "Sulfuras, Hand of Ragnaros, 0, 80\n" +
                "Sulfuras, Hand of Ragnaros, -1, 80\n" +
                "Backstage passes to a TAFKAL80ETC concert, -15, 0\n" +
                "Backstage passes to a TAFKAL80ETC concert, -20, 0\n" +
                "Backstage passes to a TAFKAL80ETC concert, -25, 0\n" +
                "Conjured Mana Cake, -27, 0\n";
                

            for (var i = 0; i < 31; i++)
            {
                //Console.WriteLine("-------- day " + i + " --------");
                //Console.WriteLine("name, sellIn, quality");
                if (i == 30)
                {
                    for (var j = 0; j < Items.Count; j++)
                    {
                        output += Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality + "\n";
                    }
                }
                app.UpdateQuality();
            }

            //app.UpdateQuality();
            Assert.Equal(expected, output);
        }
    }
}


//IList<Item> Items = new List<Item>{
//                new Item ,
//                new Item ,
//                new Item ,
//                new Item ,
//                new Item ,
//                new Item
//                ,
//                new Item
//                ,
//                new Item
//                {
//                    Name = "Backstage passes to a TAFKAL80ETC concert",
//                    SellIn = 5,
//                    Quality = 49
//                },
//				// this conjured item does not work properly yet
//				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
//            };

//var app = new GildedRose(Items);


//for (var i = 0; i < 31; i++)
//{
//    Console.WriteLine("-------- day " + i + " --------");
//    Console.WriteLine("name, sellIn, quality");
//    for (var j = 0; j < Items.Count; j++)
//    {
//        System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
//    }
//    Console.WriteLine("");
//    app.UpdateQuality();
//}

//+5 Dexterity Vest, -20, 0
//Aged Brie, -28, 50
//Elixir of the Mongoose, -25, 0
//Sulfuras, Hand of Ragnaros, 0, 80
//Sulfuras, Hand of Ragnaros, -1, 80
//Backstage passes to a TAFKAL80ETC concert, -15, 3
//Backstage passes to a TAFKAL80ETC concert, -20, 3
//Backstage passes to a TAFKAL80ETC concert, -25, 3
//Conjured Mana Cake, -27, 0