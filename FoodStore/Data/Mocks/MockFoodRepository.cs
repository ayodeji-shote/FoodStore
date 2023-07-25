using FoodStore.Data.interfaces;
using FoodStore.Data.Models;

namespace FoodStore.Data.Mocks
{
    public class MockFoodRepository : IFoodRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Food> Foods
        {
            get
            {
                return new List<Food>
                {
                    new Food {
                        Name = "Burger",
                        Price = 7.95M, ShortDescription = "A burger is a flat round mass of minced meat or vegetables",
                        LongDescription = "A burger is a flat round mass of minced meat or vegetables, which is fried and often eaten in a bread roll",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.linkpicture.com/q/1000_F_169569546_zaLG8x4tyIu3SDn1jYWXThVpMjCEbn8Q.jpg",
                        Stock = true,
                        IsFavorite = true,
                        ImageThumbnailUrl = "https://www.linkpicture.com/q/1000_F_169569546_zaLG8x4tyIu3SDn1jYWXThVpMjCEbn8Q.jpg"
                    },
                    new Food {
                        Name = "Tofu-Burger",
                        Price = 7.95M, ShortDescription = "A burger is a flat round mass of minced meat or vegetables, a vegan burger replaces the meat with tofu",
                        LongDescription = "A vegan burger is a hamburger patty that does not contain meat.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.linkpicture.com/q/1000_F_125436420_yyhCbcW6Ck9x2pzh6l9B2Fq9mYnDQy7E.jpg",
                        Stock = true,
                        IsFavorite = true,
                        ImageThumbnailUrl = "https://www.linkpicture.com/q/1000_F_125436420_yyhCbcW6Ck9x2pzh6l9B2Fq9mYnDQy7E.jpg"
                    },

                    new Food
                    {
                        Name = "Salad ",
                        Price = 12.95M,
                        ShortDescription = "raw greens (such as lettuce) often combined with other vegetables and toppings and served especially with dressing",
                        LongDescription = "raw greens (such as lettuce) often combined with other vegetables and toppings and served especially with dressing",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://www.linkpicture.com/q/1000_F_60001352_UU9m9FyI9aFwXveVN5iENQqC5DkGDh8Y.jpg",
                        Stock = true,
                        IsFavorite = false,
                        ImageThumbnailUrl = "https://www.linkpicture.com/q/1000_F_60001352_UU9m9FyI9aFwXveVN5iENQqC5DkGDh8Y.jpg"
                    }
                };
            }
        }
        public IEnumerable<Food> FavoriteFood { get; }
        public Food getFoodByID(int FoodId)
        {
            throw new NotImplementedException();
        }
    }
}
