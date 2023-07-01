using FoodStore.Data.Models;

namespace FoodStore.Data.interfaces
{
    public interface IFoodRepository
    {
        IEnumerable<Food> Foods { get; }
        IEnumerable<Food> FavoriteFood { get; }

        Food getFoodByID(int Foodid);
    }
}
