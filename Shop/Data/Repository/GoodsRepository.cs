using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class GoodsRepository : IAllGoods
    {
        private readonly AppDBContent appDBContent;

        public GoodsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        } 

        public IEnumerable<Goods> Goods => appDBContent.Good.Include(c => c.Category);

        public IEnumerable<Goods> getFavGoods => appDBContent.Good.Where(p => p.isFavourite).Include(c => c.Category);

        public Goods getObjectGoods(int goodsId) => appDBContent.Good.FirstOrDefault(p => p.id == goodsId);
       
    }
}
