namespace FoodStore.Data.Models
{
    public class Category
    {
        // The id is a unique identifier for entity framework 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Drink> Drinks { get; set; }

        public List<Food> Foods { get; set; }
    }
}
