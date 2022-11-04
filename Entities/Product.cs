
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } 
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailible { get; set; }

        public int? CategoryId { get; set; }
       
    }
}
