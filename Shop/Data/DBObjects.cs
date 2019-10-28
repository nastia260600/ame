using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if(!content.Good.Any())
            {
                content.AddRange(
                    new Goods
                    {
                        name = "Chair №001",
                        shortDesc = "White Modern Chair",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/1.jpg",
                        price = 40,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Chairs"]
                    },

                    new Goods
                    {
                        name = "Succulent Plant",
                        shortDesc = "White Brazil succulent",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/2.jpg",
                        price = 15,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Accesoires"]
                    },

                    new Goods
                    {
                        name = "Combo Amado",
                        shortDesc = "White Ikea Chair and cart",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/3.jpg",
                        price = 100,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Furniture"]
                    },

                    new Goods
                    {
                        name = "Cactus Orgo",
                        shortDesc = "Mexico cactus",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/4.jpg",
                        price = 19,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Accesoires"]
                    },

                    new Goods
                    {
                        name = "Succulent Aurora",
                        shortDesc = "Mexico succulent",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/5.jpg",
                        price = 10,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Accesoires"]
                    },

                    new Goods
                    {
                        name = "White Table №014",
                        shortDesc = "Table Colley from white wood",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/6.jpg",
                        price = 60,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Tables"]
                    },

                    new Goods
                    {
                        name = "Chair №008",
                        shortDesc = "White loft chair",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/7.jpg",
                        price = 25,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Chairs"]
                    },

                    new Goods
                    {
                        name = "Rocking chair №002",
                        shortDesc = "White rocking chair Amelia",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/8.jpg",
                        price = 40,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Chairs"]
                    },

                    new Goods
                    {
                        name = "Cactus Orgo",
                        shortDesc = "Mexico cactus",
                        longDesc = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid quae eveniet culpa officia quidem mollitia impedit iste asperiores nisi reprehenderit consequatur, autem, nostrum pariatur enim?",
                        img = "/img/bg-img/99.jpg",
                        price = 19,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Accesoires"]
                    }
                    );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Chairs", description="Comfortable chairs"},
                        new Category {categoryName = "Beds", description="Cozy beds"},
                        new Category {categoryName = "Accesoires", description="Design your home"},
                        new Category {categoryName = "Furniture", description="Everything is here."},
                        new Category {categoryName = "Bathroom", description="All for your purity"},
                        new Category {categoryName = "Tables", description="Modern tables"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category element in list)
                        category.Add(element.categoryName, element);
                }

                return category;
            }
        }
    }
}
