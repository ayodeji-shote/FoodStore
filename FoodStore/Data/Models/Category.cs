namespace FoodStore.Data.Models
{
    public class Category
    {
        // The id is a unique identifier for entity framework 
        public int CategoryId { get; set; }
        // The name attached to the category like wether or not the drink is alcoholic or non alcoholic or if the food is vegitarian or vegan or normal.
        public string CategoryName { get; set; }
        // Holds a short description for each category 
        public string CategoryDescription { get; set; }

        // The descriptions help entity framework make the one to many relationship between the category and the category id
        public List<Drink> Drinks { get; set; }

        public List<Food> Foods { get; set; }
    }
}
