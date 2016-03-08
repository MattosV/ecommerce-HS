using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities
{
    public class MovieSales
    {
        [Key]
        public int Id { get; set; }
        public virtual Movies Movies { get; set; }
        public virtual Sales Sales { get; set; }
    }
}