using ExampleAspNetTodo.Models;

namespace ExampleAspNetTodo.Data
{
    public static class MockProductData
    {
        public static List<ProductViewModel> GetProducts() => new List<ProductViewModel>
        {
            new ProductViewModel
            {
                Id = 1,
                Name = "Wireless Mouse",
                Brand = "LogiTech",
                Price = 29.99m,
                Category = "Electronics",
                Weight = 0.1,
                Description = "Compact wireless mouse with ergonomic design and long battery life."
            },
            new ProductViewModel
            {
                Id = 2,
                Name = "Running Shoes",
                Brand = "Nike",
                Price = 89.99m,
                Category = "Footwear",
                Weight = 0.75,
                Description = "Lightweight running shoes with responsive cushioning for daily workouts."
            },
            new ProductViewModel
            {
                Id = 3,
                Name = "Espresso Machine",
                Brand = "DeLonghi",
                Price = 149.99m,
                Category = "Kitchen",
                Weight = 4.2,
                Description = "Easy-to-use espresso machine for high-quality home coffee brewing."
            },
            new ProductViewModel
            {
                Id = 4,
                Name = "Bluetooth Speaker",
                Brand = "JBL",
                Price = 59.95m,
                Category = "Electronics",
                Weight = 0.6,
                Description = "Portable waterproof speaker with powerful bass and 10-hour battery life."
            },
            new ProductViewModel
            {
                Id = 5,
                Name = "Smartphone Case",
                Brand = "Spigen",
                Price = 19.99m,
                Category = "Accessories",
                Weight = 0.05,
                Description = "Shock-absorbent and slim smartphone case for everyday protection."
            },
            new ProductViewModel
            {
                Id = 6,
                Name = "Yoga Mat",
                Brand = "Gaiam",
                Price = 25.00m,
                Category = "Fitness",
                Weight = 1.2,
                Description = "Non-slip yoga mat with extra cushioning and eco-friendly material."
            },
            new ProductViewModel
            {
                Id = 7,
                Name = "LED Monitor 24\"",
                Brand = "Samsung",
                Price = 149.00m,
                Category = "Electronics",
                Weight = 3.1,
                Description = "Full HD LED monitor with vivid colors, slim design, and HDMI support."
            },
            new ProductViewModel
            {
                Id = 8,
                Name = "Electric Toothbrush",
                Brand = "Oral-B",
                Price = 39.99m,
                Category = "Personal Care",
                Weight = 0.3,
                Description = "Rechargeable electric toothbrush with pressure sensor and timer."
            },
            new ProductViewModel
            {
                Id = 9,
                Name = "Backpack",
                Brand = "Herschel",
                Price = 79.99m,
                Category = "Bags",
                Weight = 0.9,
                Description = "Stylish and durable backpack with laptop compartment and water-resistant fabric."
            },
            new ProductViewModel
            {
                Id = 10,
                Name = "Gaming Keyboard",
                Brand = "Razer",
                Price = 119.99m,
                Category = "Electronics",
                Weight = 1.4,
                Description = "RGB mechanical keyboard with customizable lighting and macro support."
            }
        };
    }
}
