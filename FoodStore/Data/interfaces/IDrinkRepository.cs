using FoodStore.Data.Models;

namespace FoodStore.Data.interfaces
{
    public interface IDrinkRepository
    {
        // The drink property is used to get all present drinks while the favorite  property is used to get the favorite drinks 
        IEnumerable<Drink > Drinks { get; }
        IEnumerable<Drink> FavoriteDrink  { get;}

        Drink getDrinkByID(int id);
    }
}
