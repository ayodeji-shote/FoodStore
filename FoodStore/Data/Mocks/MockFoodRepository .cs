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
                        ImageUrl = "https://shorturl.at/uGOZ6",
                        Stock = true,
                        IsFavorite = true,
                        ImageThumbnailUrl = "https://shorturl.at/uGOZ6"
                    },
                    new Food {
                        Name = "Tofu-Burger",
                        Price = 7.95M, ShortDescription = "A burger is a flat round mass of minced meat or vegetables, a vegan burger replaces the meat with tofu",
                        LongDescription = "A vegan burger is a hamburger patty that does not contain meat.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://shorturl.at/fqLNT",
                        Stock = true,
                        IsFavorite = true,
                        ImageThumbnailUrl = "https://shorturl.at/fqLNT"
                    },

                    new Food
                    {
                        Name = "Salad ",
                        Price = 12.95M,
                        ShortDescription = "raw greens (such as lettuce) often combined with other vegetables and toppings and served especially with dressing",
                        LongDescription = "raw greens (such as lettuce) often combined with other vegetables and toppings and served especially with dressing",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://shorturl.at/wDIXY",
                        Stock = true,
                        IsFavorite = false,
                        ImageThumbnailUrl = "https://shorturl.at/wDIXY"
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
