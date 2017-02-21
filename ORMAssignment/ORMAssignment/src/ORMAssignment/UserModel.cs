using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ORMAssignment
{
    public class UserModel
    {
        [Key]
        public int userId { get; set; }

        [Required]
        [MaxLength(50)]
        public String frstName { get; set; }

        public String lastName { get; set; }

        [Required]
        public String emailId { get; set; }

        public String dateOfBirth { get; set; }

        public String url { get; set; }

        public List<ProductModel> ProductId { get; set; }



    }
}
