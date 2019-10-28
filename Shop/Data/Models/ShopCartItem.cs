using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public virtual Goods goods { get; set; }
        public int price { get; set; }
        public int goodsid { get; set; }
        public string ShopCartId { get; set; }
    }
}
