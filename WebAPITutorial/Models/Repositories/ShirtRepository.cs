﻿namespace WebAPITutorial.Models.Repositories
{
    public static class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId = 1, Brand = "My Brand", Color = "Blue", Gender = "Men", Price = 30, Size = 10},
            new Shirt {ShirtId = 2, Brand = "My Brand", Color = "Black", Gender = "Men", Price = 24, Size = 8},
            new Shirt {ShirtId = 3, Brand = "Your Brand", Color = "Green", Gender = "Women", Price = 32, Size = 6},
            new Shirt {ShirtId = 4, Brand = "Her Brand", Color = "Pink", Gender = "Women", Price = 10, Size = 10},
        };

        public static List<Shirt> GetShirts()
        {
            return shirts;
        }

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}