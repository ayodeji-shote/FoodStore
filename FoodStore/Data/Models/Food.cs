using System.ComponentModel;

namespace FoodStore.Data.Models
{
    public class Food
    {
        // Food id 
        public int Id { get; set; }
        // Food name 
        public string Name { get; set; }
        // short description of what the Food contains 
        public string ShortDescription { get; set; }

        // longer description of what the Food contains 
        public string LongDescription { get; set; }

        // the price of the Food in pounds sterling 

        public decimal Price { get; set; }
        // The url image of the Food 
        public string ImageUrl { get; set; }


        // The thumbnail image url of the Food 
        public string ImageThumbnailUrl { get; set; }

        // Boolean that determines if the Food will show on the front page or not based on amount bought 
        public bool IsFavorite { get; set; }
        // A value to see if the Food is in stock and if it is more than one then it will be shown in the shop 
        public bool Stock { get; set; }
        // The categoryId and 
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
