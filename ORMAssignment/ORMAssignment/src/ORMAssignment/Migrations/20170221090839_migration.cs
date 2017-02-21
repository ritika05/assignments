using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ORMAssignment.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_user_UserModeluserId",
                table: "product");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.RenameColumn(
                name: "productName",
                table: "product",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "homePageUrl",
                table: "product",
                newName: "HomePageUrl");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "product",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "product",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "UserModeluserId",
                table: "product",
                newName: "UpdateModelId");

            migrationBuilder.RenameIndex(
                name: "IX_product_UserModeluserId",
                table: "product",
                newName: "IX_product_UpdateModelId");

            migrationBuilder.CreateTable(
                name: "update",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    UpdateDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_update", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_product_update_UpdateModelId",
                table: "product",
                column: "UpdateModelId",
                principalTable: "update",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_update_UpdateModelId",
                table: "product");

            migrationBuilder.DropTable(
                name: "update");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "product",
                newName: "productName");

            migrationBuilder.RenameColumn(
                name: "HomePageUrl",
                table: "product",
                newName: "homePageUrl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "product",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "product",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "UpdateModelId",
                table: "product",
                newName: "UserModeluserId");

            migrationBuilder.RenameIndex(
                name: "IX_product_UpdateModelId",
                table: "product",
                newName: "IX_product_UserModeluserId");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    dateOfBirth = table.Column<string>(nullable: true),
                    emailId = table.Column<string>(nullable: false),
                    frstName = table.Column<string>(maxLength: 50, nullable: false),
                    lastName = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_product_user_UserModeluserId",
                table: "product",
                column: "UserModeluserId",
                principalTable: "user",
                principalColumn: "userId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
