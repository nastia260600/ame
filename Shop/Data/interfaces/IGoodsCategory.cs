using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    //ф-я будет возвращать все категории из модели category
    public interface IGoodsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
