namespace Ecommerce.Entities
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}
