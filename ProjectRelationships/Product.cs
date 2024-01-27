using System.Text.Json.Serialization;

namespace ProjectRelationships
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        [JsonIgnore]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
