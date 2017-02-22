using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ORMAssignment
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public String ProductName { get; set; }

        public String Description { get; set; }

        [Required]
        public String HomePageUrl { get; set; } 
    }
}
