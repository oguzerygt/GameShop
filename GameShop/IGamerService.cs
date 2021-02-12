using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Delete(Gamer gamer);
        public void Update(Gamer gamer, string newName);
    }
}
