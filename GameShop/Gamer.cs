using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop
{
    class Gamer:GameShopObject
    {
        public Gamer(string tcNo , string name , string surName , string birthDay )
        {
            this.tcNo = tcNo;
            this.name = name;
            this.surName = surName;
            this.birthDay = birthDay;
        }
        public string tcNo { get; set; }
        public string name { get; set; }
        public string  surName { get; set; }
        public string birthDay { get; set; }
    }
}
