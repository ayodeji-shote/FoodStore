using FoodStore.Data.Models;

namespace FoodStore.Data.interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get;}
    }
}
