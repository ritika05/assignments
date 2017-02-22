using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ORMAssignment;

namespace ORMAssignment.Migrations
{
    [DbContext(typeof(DataBaseConnection))]
    [Migration("20170221083934_111")]
    partial class _111
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORMAssignment.ProductModel", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("UserModeluserId");

                    b.Property<string>("description");

                    b.Property<string>("homePageUrl")
                        .IsRequired();

                    b.Property<string>("productName")
                        .IsRequired();

                    b.HasKey("productId");

                    b.HasIndex("UserModeluserId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("ORMAssignment.UserModel", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("dateOfBirth");

                    b.Property<string>("emailId")
                        .IsRequired();

                    b.Property<string>("frstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("lastName");

                    b.Property<string>("url");

                    b.HasKey("userId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("ORMAssignment.ProductModel", b =>
                {
                    b.HasOne("ORMAssignment.UserModel")
                        .WithMany("ProductId")
                        .HasForeignKey("UserModeluserId");
                });
        }
    }
}
