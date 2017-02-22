using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORMAssignment
{
    public class DataBaseConnection : DbContext
    {
        public DbSet<UpdateModel> update { get; set; }
        public DbSet<ProductModel> product { get; set; }
        protected override  void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ORM_DataBase");
        }
    }
}
