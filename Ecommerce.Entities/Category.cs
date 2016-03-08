using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public string Name { get; set; }
    }
}
