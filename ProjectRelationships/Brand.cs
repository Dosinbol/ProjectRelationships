using System.Text.Json.Serialization;

namespace ProjectRelationships
{
    public class Brand
    {
        public int Id { get; set; }
        public string? BrandName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
