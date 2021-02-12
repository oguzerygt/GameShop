using System;
using System.Collections.Generic;
namespace GameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game("nfs carbon", "2007", 10.35);
            Game game2 = new Game("fifa 21", "2020", 80.50);
            Game game3 = new Game("call of duty 4", "2006", 15);

            Gamer gamer1 = new Gamer("464", "oguz", "eryt", "1995");
            Gamer gamer2 = new Gamer("000", "eren", "eryt", "1995");
            Gamer gamer3 = new Gamer("000", "maahmut", "eryt", "1995");
            Gamer gamer4 = new Gamer("000", "dalha", "eryt", "1995");

            GamerManager gamerManager = new GamerManager();
            GameManager gameManager = new GameManager();
            StandartDiscount stdDiscount1 = new StandartDiscount(10);

            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Add(gamer3);
            gamerManager.Add(gamer4);

            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);


            gamerManager.Delete(gamer4);
            gamerManager.Delete(gamer4);

            gamerManager.Update(gamer3, "halil");

            foreach (var item in gamerManager.gamers)
            {
                Console.WriteLine(item.name);
            }

            gameManager.Sell(gamer2, new List<Game> { game1,game2} ,stdDiscount1);


        }
    }
}
