﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
