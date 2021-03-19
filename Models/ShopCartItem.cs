using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WA20.Models
{
    public class ShopCartItem
    {

        public int id { get; set; }
        public Realty realty { get; set; }
        public int price { get; set; }

        public string ShopCartId { get; set; }


    }
}
