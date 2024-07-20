using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbApp.CodeFirstFluentApiPresentation.Migrations
{
    /// <inheritdoc />
    public partial class Create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    crea_date = table.Column<DateTime>(type: "DateTime2", nullable: false),
                    is_active = table.Column<bool>(type: "bit", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_category_id",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "name" },
                values: new object[,]
                {
                    { 1, "Elektronik" },
                    { 2, "Kitap" },
                    { 3, "Giyim" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_id", "category_id", "crea_date", "is_active", "name", "price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 7, 20, 21, 24, 50, 957, DateTimeKind.Local).AddTicks(4093), true, "İphone 15 pro max", 84.500m },
                    { 2, 1, new DateTime(2024, 7, 20, 21, 24, 50, 957, DateTimeKind.Local).AddTicks(4110), true, "sahomi ultra x", 78m },
                    { 3, 2, new DateTime(2024, 7, 15, 21, 24, 50, 957, DateTimeKind.Local).AddTicks(4112), true, "Yoldaki mühendis", 200m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_category_id",
                table: "Products",
                column: "category_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
