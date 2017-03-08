using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ORMAssignment
{
    public class UpdateModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String UpdateDescription { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public ProductModel product { get; set; }
    }
}
