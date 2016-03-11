using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Stars { get; set; }
        public int ReleaseYear { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
    }
}