using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    class StandartDiscount:BaseDiscount
    {
        //standard discount for everyone
        public StandartDiscount(double ratio)
        {
            this.discountRatio = ratio;
        }
    }
}
