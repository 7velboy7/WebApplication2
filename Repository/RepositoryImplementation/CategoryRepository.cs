
using DataAccessLayer.Entities;
using DataAccessLayer.Exceptions;
using DataAccessLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Repository;

namespace DaaAccessLayer.Repository.RepositoryImplementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private Context _context; // the same as in ProductRepostory
        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public async Task AddCategoryAsync(Category category) 
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
        }
      
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.Include(category => category.Products) 
                .ToListAsync();
        }

        public async Task<Category> GetCategorytByIdAsync(int categoryId)
        {
            Category category = await _context.Categories.FindAsync(categoryId); // include includes

            if (category == null)
            {
                throw new CategoryNotFoundException($"Category with id '{categoryId}' not found.");
            }

            return category;
        }

        public async Task RemoveCategoryByIdAsync(int CategoryId)
        {
            Category category = await _context.Categories.FindAsync(CategoryId);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        } // remove this method


        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
