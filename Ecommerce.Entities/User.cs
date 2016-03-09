using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual Client Client { get; set; }

        [NotMapped]
        public bool IsAdmin
        {
            get { return Client != null; }
        }

    }
}
