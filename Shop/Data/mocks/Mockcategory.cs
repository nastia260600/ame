using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : IGoodsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Chairs", description="Comfortable chairs"},
                    new Category {categoryName = "Beds", description="Cozy beds"},
                    new Category {categoryName = "Accesoires", description="Design your home"},
                    new Category {categoryName = "Furniture", description="Everything is here."},
                    new Category {categoryName = "Bathroom", description="All for your purity"},
                    new Category {categoryName = "Tables", description="Modern tables"}
                };
            }
        }
    }
}
