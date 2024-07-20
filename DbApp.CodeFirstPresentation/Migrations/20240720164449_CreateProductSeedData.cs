using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbApp.CodeFirstPresentation.Migrations
{
    /// <inheritdoc />
    public partial class CreateProductSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_id", "category_id", "crea_date", "is_ative", "name", "price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 20, 19, 44, 48, 370, DateTimeKind.Local).AddTicks(6344), true, "İphone 15 pro max", 84.500m },
                    { 2, 1, new DateTime(2024, 7, 20, 19, 44, 48, 370, DateTimeKind.Local).AddTicks(6367), true, "sahomi ultra x", 78m },
                    { 3, 2, new DateTime(2024, 7, 15, 19, 44, 48, 370, DateTimeKind.Local).AddTicks(6369), true, "Yoldaki mühendis", 200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_id",
                keyValue: 3);
        }
    }
}
