using SamplePingPongStoreCatalogAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SamplePingPongStoreCatalogAPI.Repository
{
    public class CatalogRepository : ICatalogRepository
    {
        private readonly List<Product> _catalog;

        public CatalogRepository()
        {
            _catalog = new List<Product>
            {
                new Product { Id = 1, Name = "Professional Table Tennis Table", Description = "Competition-grade table tennis table", Category = "Tables", Price = 699.99M, ImageUrl = "table1.jpg" },
                new Product { Id = 2, Name = "Butterfly Zhang Jike ZJX6", Description = "Professional ping pong paddle", Category = "Paddles", Price = 199.99M, ImageUrl = "paddle1.jpg" },
                new Product { Id = 3, Name = "DHS 3-Star Balls (6-pack)", Description = "Competition approved 40mm+ balls", Category = "Balls", Price = 14.99M, ImageUrl = "balls1.jpg" },
                new Product { Id = 4, Name = "Training Robot", Description = "Automatic ping pong ball shooter", Category = "Equipment", Price = 299.99M, ImageUrl = "robot1.jpg" },
                new Product { Id = 5, Name = "Professional Net Set", Description = "Tournament-grade net and posts", Category = "Accessories", Price = 49.99M, ImageUrl = "net1.jpg" },
                new Product { Id = 6, Name = "Beginner Paddle Set", Description = "Two recreational paddles with balls", Category = "Paddles", Price = 24.99M, ImageUrl = "paddleset1.jpg" },
                new Product { Id = 7, Name = "Table Cover", Description = "Waterproof table tennis table cover", Category = "Accessories", Price = 29.99M, ImageUrl = "cover1.jpg" },
                new Product { Id = 8, Name = "Practice Balls (100-pack)", Description = "Training balls for practice", Category = "Balls", Price = 19.99M, ImageUrl = "balls2.jpg" },
                new Product { Id = 9, Name = "Premium Rubber Sheet", Description = "Professional grade rubber replacement", Category = "Components", Price = 39.99M, ImageUrl = "rubber1.jpg" },
                new Product { Id = 10, Name = "Ball Catch Net", Description = "Ball collection net system", Category = "Equipment", Price = 79.99M, ImageUrl = "net2.jpg" },
                new Product { Id = 11, Name = "Portable Mini Table", Description = "Compact table for small spaces", Category = "Tables", Price = 199.99M, ImageUrl = "table2.jpg" },
                new Product { Id = 12, Name = "Score Counter", Description = "Digital score keeper", Category = "Accessories", Price = 15.99M, ImageUrl = "counter1.jpg" },
                new Product { Id = 13, Name = "Professional Sports Bag", Description = "Padded bag for equipment", Category = "Accessories", Price = 45.99M, ImageUrl = "bag1.jpg" },
                new Product { Id = 14, Name = "Table Tennis Shoes", Description = "Professional grip shoes", Category = "Apparel", Price = 89.99M, ImageUrl = "shoes1.jpg" },
                new Product { Id = 15, Name = "Training Guide DVD", Description = "Professional training videos", Category = "Training", Price = 19.99M, ImageUrl = "dvd1.jpg" }
            };
        }

        public IEnumerable<Product> GetAll() => _catalog;
        public Product GetById(int id) => _catalog.FirstOrDefault(p => p.Id == id);
        public void Add(Product product) => _catalog.Add(product);
        public void Remove(Product product) => _catalog.Remove(product);
        public int GetNextId() => _catalog.Any() ? _catalog.Max(p => p.Id) + 1 : 1;
    }
}
