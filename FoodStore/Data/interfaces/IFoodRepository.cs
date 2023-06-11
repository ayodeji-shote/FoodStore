using FoodStore.Data.Models;

namespace FoodStore.Data.interfaces
{
    public interface IFoodRepository
    {
        IEnumerable<Food> Foods { get; set; }
        IEnumerable<Food> FavoriteFood { get; set; }

        Food getFoodByID(int Foodid);
    }
}
