using ExampleAspNetTodo.Models;

namespace ExampleAspNetTodo.Data
{
    public static class MockUserData
    {
        public static List<UserViewModel> GetUsers() => new List<UserViewModel>
        {
            new UserViewModel { Id = 1, Name = "Alice Johnson", Email = "alice.johnson@example.com" },
            new UserViewModel { Id = 2, Name = "Bob Smith", Email = "bob.smith@example.com" },
            new UserViewModel { Id = 3, Name = "Charlie Brown", Email = "charlie.brown@example.com" },
            new UserViewModel { Id = 4, Name = "Diana Prince", Email = "diana.prince@example.com" },
            new UserViewModel { Id = 5, Name = "Ethan Hunt", Email = "ethan.hunt@example.com" },
            new UserViewModel { Id = 6, Name = "Fiona Gallagher", Email = "fiona.gallagher@example.com" },
            new UserViewModel { Id = 7, Name = "George Martin", Email = "george.martin@example.com" },
            new UserViewModel { Id = 8, Name = "Hannah Wells", Email = "hannah.wells@example.com" },
            new UserViewModel { Id = 9, Name = "Ivan Drago", Email = "ivan.drago@example.com" },
            new UserViewModel { Id = 10, Name = "Julia Roberts", Email = "julia.roberts@example.com" }
        };
    }
}
