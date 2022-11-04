
using DataAccessLayer.Entities;

namespace DaaAccessLayer.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
        Task RemoveProductByIdAsync(int productId);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);


    }
}
