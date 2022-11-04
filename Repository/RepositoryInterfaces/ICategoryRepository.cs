
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<Category> GetCategorytByIdAsync(int productId);
        Task RemoveCategoryByIdAsync(int productId);
        Task AddCategoryAsync(Category product);
        Task UpdateCategoryAsync(Category product);
       
    }
}
