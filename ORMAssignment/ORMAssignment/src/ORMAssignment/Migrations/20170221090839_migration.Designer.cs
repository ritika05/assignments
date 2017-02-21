using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ORMAssignment;

namespace ORMAssignment.Migrations
{
    [DbContext(typeof(DataBaseConnection))]
    [Migration("20170221090839_migration")]
    partial class migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORMAssignment.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("HomePageUrl")
                        .IsRequired();

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<int?>("UpdateModelId");

                    b.HasKey("ProductId");

                    b.HasIndex("UpdateModelId");

                    b.ToTable("product");
                });

            modelBuilder.Entity("ORMAssignment.UpdateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UpdateDescription")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("update");
                });

            modelBuilder.Entity("ORMAssignment.ProductModel", b =>
                {
                    b.HasOne("ORMAssignment.UpdateModel")
                        .WithMany("ProductId")
                        .HasForeignKey("UpdateModelId");
                });
        }
    }
}
