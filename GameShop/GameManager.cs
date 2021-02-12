using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace GameShop
{
    class GameManager : IGameService
    {
        public GameManager()
        {
            games = new List<Game>();
        }
        List<Game> games;

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine(game.gameName + "\tsisteme eklendi");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine(game.gameName + "\tsistemden silindi");
        }

        public void Update(Game game, string newName)
        {
            Console.WriteLine(game.gameName + "in adı " + newName + "olarak güncellendi");
            game.gameName = newName;
        }
        public void Sell(Gamer gamer, List<Game> games2)
        {
            double totalPayement = 0;
            Console.WriteLine(gamer.name + "adli kullanici ");
            foreach (var item in games2)
            {
                Console.WriteLine("\t" + item.gameName + "\t{0:C2}", item.price);
                totalPayement += item.price;
            }
            Console.WriteLine("adli oyunları aldı\nödeme tutarı: {0:C2}", totalPayement);
        }
        public void Sell(Gamer gamer, List<Game> games2, BaseDiscount discount)
        {
            double totalPayement = 0;
            double discountedTotal; //indirim uygulanmış ücret
            Console.WriteLine(gamer.name + "adli kullanici ");
            foreach (var item in games2)
            {
                Console.WriteLine("\t" + item.gameName + "\t{0:C2}", item.price);
                totalPayement += item.price;
            }
            discountedTotal =(100- discount.discountRatio) * totalPayement / 100;
            Console.WriteLine("adli oyunları aldı\nödeme tutarı:\t{0:C2}\n%{1}indirim ile\t{2:C2}", totalPayement,discount.discountRatio,discountedTotal);
        }
    }
}
