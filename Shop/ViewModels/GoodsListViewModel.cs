﻿using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class GoodsListViewModel
    {
        public IEnumerable<Goods> allGoods { get; set; }
        public string currCategory { get; set; }
    }
}
