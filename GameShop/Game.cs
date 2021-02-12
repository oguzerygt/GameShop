using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    class Game:GameShopObject
    {
        public Game(string gameName, string releaseYear,double price)
        {
            this.gameName = gameName;
            this.releaseYear = releaseYear;
            this.price = price;
        }
        public string gameName { get; set; }
        public string releaseYear { get; set; }
        public double price { get; set; }

    }
}
