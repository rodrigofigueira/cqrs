using Api.Models;

namespace API.Repository
{
    public class ProductRepository
    {
        private static readonly List<Product> products = new();

        public Product Add(string name, string description)
        {
            Product product = new(Guid.NewGuid(), name, description);
            products.Add(product);
            return product;
        }

    }
}
