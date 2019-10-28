using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class GoodsController : Controller
    {
        private readonly IAllGoods _allGoods;
        private readonly IGoodsCategory _allCategories;

        public GoodsController(IAllGoods iAllGoods, IGoodsCategory iGoodsCategory)
        {
            _allGoods = iAllGoods;
            _allCategories = iGoodsCategory;
        }

        [Route("Goods/List")]
        [Route("Goods/List/{category}")]

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Goods> goods = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                goods = _allGoods.Goods.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("Chairs", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _allGoods.Goods.Where(i => i.Category.categoryName.Equals("Chairs")).OrderBy(i => i.id);
                } 
                else if (string.Equals("Beds", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _allGoods.Goods.Where(i => i.Category.categoryName.Equals("Beds")).OrderBy(i => i.id);
                }
                else if (string.Equals("Accesoires", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _allGoods.Goods.Where(i => i.Category.categoryName.Equals("Accesoires")).OrderBy(i => i.id);
                }
                else if (string.Equals("Furniture", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _allGoods.Goods.Where(i => i.Category.categoryName.Equals("Furniture")).OrderBy(i => i.id);
                }
                else if (string.Equals("Bathroom", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _allGoods.Goods.Where(i => i.Category.categoryName.Equals("Bathroom")).OrderBy(i => i.id);
                }
                else if (string.Equals("Tables", category, StringComparison.OrdinalIgnoreCase))
                {
                    goods = _allGoods.Goods.Where(i => i.Category.categoryName.Equals("Tables")).OrderBy(i => i.id);
                }

                currCategory = _category; 
            }

            var goodsObj = new GoodsListViewModel
            {
                allGoods = goods,
                currCategory = currCategory
            };

            ViewBag.Title = "Amado - Furniture Ecommerce Shop";
            
            return View(goodsObj);
        }
    }
}
