﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string description { set; get; }
        public List<Goods> goods { set; get; }  //указывается какие товары входят именно в эту категорию


    }
}
