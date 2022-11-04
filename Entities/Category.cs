using DataAccessLayer.Entities;

namespace DataAccessLayer.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
 
    }
}
