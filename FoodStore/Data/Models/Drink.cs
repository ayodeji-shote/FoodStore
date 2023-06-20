using System.ComponentModel;

namespace FoodStore.Data.Models
{
    public class Drink
    {
        // drink id 
        public int Id { get; set; }
        // drink name 
        public string Name { get; set; }
        // short description of what the drink contains 
        public string ShortDescription { get; set; }

        // longer description of what the drink contains 
        public string LongDescription { get; set; }

        // the price of the drink in pounds sterling 

        public decimal Price { get; set; }
        // The url image of the drink 
        public string ImageUrl { get; set; }


        // The thumbnail image url of the drink 
        public string ImageThumbnailUrl { get; set; }

        // Boolean that determines if the drink will show on the front page or not based on amount bought 
        public bool IsFavorite { get; set; }
        // A value to see if the drink is in stock and if it is more than one then it will be shown in the shop 
        public bool Stock { get; set; }
        // The categoryId and category are used by entity framework to create datbase relationship a drink can be nonalcoholic or alcoholic
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
