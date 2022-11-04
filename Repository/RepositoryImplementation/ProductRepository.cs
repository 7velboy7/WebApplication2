
using DataAccessLayer.DataAccess;
using DataAccessLayer.Entities;
using DataAccessLayer.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace DaaAccessLayer.Repository.RepositoryImplementation
{   
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context; 
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public async Task AddProductAsync(Product product) 
        {
           await _context.Products.AddAsync(product);
           await _context.SaveChangesAsync();
        }
         
        public async Task<IEnumerable<Product>> GetAllProductsAsync() 
        {
            return await _context.Products.Include(products => products.CategoryId).ToListAsync(); 
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var expectedProduct = await _context.Products.FindAsync(productId);

            if (expectedProduct == null)
            {
                throw new ProductNotFoundException("product was not found");
            }
            return expectedProduct;
        }

        public async Task RemoveProductByIdAsync(int productId)
        {
            var product = await GetProductByIdAsync(productId);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
