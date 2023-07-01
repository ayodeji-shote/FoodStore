using FoodStore.Data.Models;

namespace FoodStore.Data.ViewModel
{
    public class DrinkListViewModel
    {
        // A model for the drinks specifically the drink list 
        // A model to hold the list of drinks 
        public IEnumerable<Drink> Drinks { get; set; }
        // Used to display the current category of drinks 
        public string CurrentCategory { get; set; }

    }
}
