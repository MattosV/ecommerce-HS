using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        //Client's address info
        public string Street { get; set; }
        public string Complement { get; set; }//Diplay a placeholder (Number, Apartment, building)
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        //Client's personal info
        public string Gender { get; set; }
        public string CPF { get; set; }
        public long CardNumber { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<Sales> Sales { get; set; } 
        public virtual ICollection<MovieSales> Movies { get; set; } 
    }
}