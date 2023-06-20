using FoodStore.Data.interfaces;
using System.Collections.Generic;
using FoodStore.Data.Models;

namespace FoodStore.Data.Mocks
{
    // C# Repository is a c# class that will inherit from the repository interfaces we created
    // it also implements the methods and the properties
    public class MockCategoryRepository : ICategoryRepository
    {

        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Alcoholic", CategoryDescription= "All Alcoholic drinks"},
                    new Category {CategoryName = "Non-alcoholic", CategoryDescription= "All Non-alcoholic drinks"},
                    new Category {CategoryName = "Kids-drinks", CategoryDescription= "Drinks for kids"},
                    new Category {CategoryName = "Vegiterian", CategoryDescription= "All vegiterian foods"},
                    new Category {CategoryName = "Vegan", CategoryDescription= "All Vegan foods"},
                    new Category {CategoryName = "Normal", CategoryDescription= "All foods for people that arent vegiterian or vegan"}

                };
            }

        }
    }
}
