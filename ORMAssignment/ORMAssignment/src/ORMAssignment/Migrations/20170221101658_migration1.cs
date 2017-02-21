using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ORMAssignment.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_update_UpdateModelId",
                table: "product");

            migrationBuilder.DropIndex(
                name: "IX_product_UpdateModelId",
                table: "product");

            migrationBuilder.DropColumn(
                name: "UpdateModelId",
                table: "product");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "update",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_update_ProductId",
                table: "update",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_update_product_ProductId",
                table: "update",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_update_product_ProductId",
                table: "update");

            migrationBuilder.DropIndex(
                name: "IX_update_ProductId",
                table: "update");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "update");

            migrationBuilder.AddColumn<int>(
                name: "UpdateModelId",
                table: "product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_product_UpdateModelId",
                table: "product",
                column: "UpdateModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_product_update_UpdateModelId",
                table: "product",
                column: "UpdateModelId",
                principalTable: "update",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
