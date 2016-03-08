﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}