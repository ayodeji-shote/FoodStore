using FoodStore.Data.Models;

namespace FoodStore.Data.ViewModel
{
    public class FoodListViewModel
    {
        // A model for the Foods specifically the Food list 
        // A model to hold the list of Foods 
        public IEnumerable<Food> Foods { get; set; }
        // Used to display the current category of Foods 
        public string CurrentFoodCategory { get; set; }

    }
}
