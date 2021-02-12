using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    class GamerManager : IGamerService
    {
        public GamerManager()
        {
            gamers = new List<Gamer>();
        }
        public List<Gamer> gamers;


        public void Add(Gamer gamer)
        {
            Validator validator = new Validator();
            bool result=validator.Validate(gamer);
            if (!result) //sonuc false ise fonksiyonu kır işlemi yapma
            {
                Console.WriteLine("ekleme yaplıamadı");
                return;
            }
            gamers.Add(gamer);
            Console.WriteLine(gamer.name + "\tsisteme eklendi\n");
        }

        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
            Console.WriteLine(gamer.name + "\tsistemden silindi\n");
        }

        public void Update(Gamer gamer, string newName)
        {
            Console.WriteLine(gamer.name + "in adı " + newName + " olarak güncellendi\n");
            gamer.name = newName;
        }


        
    }
}
