using SSP.Entities;

namespace SSP.Services
{
    public class ProductService
    {
        public List<Product> GetProducts() => new List<Product>
        {
            new Product
            {
                Name = "P1",
                Id = 1,
            },
            new Product {
                Name = "P2",
                Id = 2,
            }
        };

        public Product? GetProductById(int id) => GetProducts().FirstOrDefault(x => x.Id == id);
    }
}
