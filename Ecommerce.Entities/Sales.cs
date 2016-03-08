using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Entities
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public Client Client { get; set; }
        public virtual ICollection<MovieSales> Movies { get; set; }

    }
}
