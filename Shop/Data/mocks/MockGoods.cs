using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockGoods : IAllGoods
    {
        private readonly IGoodsCategory _categoryGoods = new MockCategory();

        public IEnumerable<Goods> Goods { 
            get {
                return new List<Goods> {
                    new Goods
                    {
                        name = "Chair №001",
                        shortDesc = "White Modern Chair",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/product-img/pro-big-1.jpg",
                        price = 40,
                        isFavourite = true,
                        available = true,
                        Category = _categoryGoods.AllCategories.First()},

                    new Goods {
                        name = "Succulent Plant",
                        shortDesc = "White Brazil succulent",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/product-img/pro-big-4.jpg",
                        price = 15,
                        isFavourite = true,
                        available = true,
                        Category = _categoryGoods.AllCategories.ElementAtOrDefault(2)},

                    new Goods {
                        name = "Bed №001",
                        shortDesc = "White Bed IKEA decora",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/product-img/product7.jpg",
                        price = 800,
                        isFavourite = false,
                        available = true,
                        Category = _categoryGoods.AllCategories.ElementAtOrDefault(1)}
                };
            }
        }

        public IEnumerable<Goods> getFavGoods { get; set; }

        public Goods getObjectGoods(int goodsId)
        {
            throw new NotImplementedException();
        }
    }
}
