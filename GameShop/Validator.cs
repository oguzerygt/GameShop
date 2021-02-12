using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    class Validator
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.tcNo=="000")
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
