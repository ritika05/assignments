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

                ////Adding Products in the Product Table
                db.product.Add(new ProductModel
                {
                    ProductName = "Samsung phones",
                    HomePageUrl = "http:\\samsung.com",
                });
                var count = db.SaveChanges();
                db.product.Add(new ProductModel
                {
                    ProductName = "headphones",
                    HomePageUrl = "http:\\headphones.com",

                });
                count = db.SaveChanges();
                db.product.Add(new ProductModel
                {
                    ProductName = "back covers",
                    HomePageUrl = "http:\\covers.com",
                });
                count = db.SaveChanges();
                db.product.Add(new ProductModel
                {
                    ProductName = "nokia Phones",
                    HomePageUrl = "http:\\Nokia.com",
                });
                count = db.SaveChanges();
                db.product.Add(new ProductModel
                {
                    ProductName = "Asus Phones",
                    HomePageUrl = "http:\\asus.com",
                });
                count = db.SaveChanges();
                db.product.Add(new ProductModel
                {
                    ProductName = "Sony Phones",
                    HomePageUrl = "http:\\sony.com",
                });
                count = db.SaveChanges();

                ////Adding Products in the Update Table
                db.update.Add(new UpdateModel
                {
                    Name = "Nokia Phones",
                    UpdateDescription = "Nokia  produdct updated",
                    ProductId = 1

                });
                count = db.SaveChanges();
                db.update.Add(new UpdateModel
                {
                    Name = "Asus Phones",
                    UpdateDescription = "Asus product updated",
                    ProductId = 5
                });
                count = db.SaveChanges();
                db.update.Add(new UpdateModel
                {
                    Name = "Sony Phones",
                    UpdateDescription = "Sony product updated",
                    ProductId = 2
                });
                count = db.SaveChanges();
                db.update.Add(new UpdateModel
                {
                    Name = "Samsung phones",
                    UpdateDescription = "Samsung phones product updated",
                    ProductId = 2
                });
                count = db.SaveChanges();

            }
            using (var db = new DataBaseConnection())
            {
                //Updating the Product Table when the ProductId is given
                db.product.Update(new ProductModel
                {
                    ProductId = 2,
                    ProductName = "tempered glass",
                    HomePageUrl = "http:\\temperedglass.com",
                    Description = "dewvf"
                });
                var count = db.SaveChanges();


                //Updating the Update Table when Id and ProductId is given
                db.update.Update(new UpdateModel
                {
                    Id = 2,
                    Name = "covers",
                    UpdateDescription = "Asus updated to covers",
                    ProductId = 5,
                });
                count = db.SaveChanges();


            }
            //Removing data from the Product Table when ProductId is given
            using (var db = new DataBaseConnection())
            {
                db.product.Remove(new ProductModel
                {
                    ProductId = 5
                });

                //Removing Data from update Table when Id is given
                db.update.Remove(new UpdateModel
                {
                    Id = 4
                });
                var count = db.SaveChanges();



                count = db.SaveChanges();
            }

                Console.WriteLine();
                Console.Read();
            }
        }
    }

