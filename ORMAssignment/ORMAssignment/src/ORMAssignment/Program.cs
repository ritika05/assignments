using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORMAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new DataBaseConnection())
            {
                db.Database.Migrate();
                db.update.Add(new UpdateModel
                {
                    Name = "abc",
                    UpdateDescription = "abc produdct updated",
                    ProductId = 19

                });

                db.update.Add(new UpdateModel
                {
                    Name = "def",
                    UpdateDescription = "def product updated",
                    ProductId = 20
                });

                db.update.Add(new UpdateModel
                {
                    Name = "xyz",
                    UpdateDescription = "xyz product updated",
                    ProductId = 22
                });

                db.update.Add(new UpdateModel
                {
                    Name = "phones",
                    UpdateDescription = "phones product updated",
                    ProductId = 20
                });

                db.product.Add(new ProductModel
                {
                    ProductName = "phones",
                    HomePageUrl = "http:\\phones.com",
                });

                db.product.Add(new ProductModel
                {
                    ProductName = "headphones",
                    HomePageUrl = "http:\\headphones.com",

                });
                db.product.Add(new ProductModel
                {
                    ProductName = "back covers",
                    HomePageUrl = "http:\\covers.com",
                });
                db.product.Add(new ProductModel
                {
                    ProductName = "abc",
                    HomePageUrl = "http:\\abc.com",
                });

                db.product.Add(new ProductModel
                {
                    ProductName = "def",
                    HomePageUrl = "http:\\def.com",
                });

                db.product.Add(new ProductModel
                {
                    ProductName = "xyz",
                    HomePageUrl = "http:\\xyz.com",
                });

                db.update.Remove(new UpdateModel
                {
                    Id = 24
                });

                db.update.Update(new UpdateModel
                {
                    Id = 17,
                    ProductId = 20,
                    Name = "covers",
                    UpdateDescription = "def updated to covers",
                });

                db.product.Update(new ProductModel
                {
                    ProductId = 20,
                    ProductName = "tempered glass",
                    HomePageUrl = "http:\\temperedglass.com",
                });

                db.product.Remove(new ProductModel
                {
                    ProductId = 19
                });

                var count = db.SaveChanges();
                Console.WriteLine("{0} changes saved", count);
                Console.WriteLine();
            }
        }
    }
}
