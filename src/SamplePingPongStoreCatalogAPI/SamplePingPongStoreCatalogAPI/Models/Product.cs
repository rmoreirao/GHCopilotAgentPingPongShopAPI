namespace SamplePingPongStoreCatalogAPI.Models
{
    public sealed class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
