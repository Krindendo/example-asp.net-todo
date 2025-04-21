namespace ExampleAspNetTodo.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";
        public decimal Price { get; set; }
        public string Category { get; set; } = "";
        public double Weight { get; set; } // weight in kg
        public string Description { get; set; } = "";
    }
}
