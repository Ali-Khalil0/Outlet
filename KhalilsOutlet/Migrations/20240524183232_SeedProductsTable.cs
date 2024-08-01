using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KhalilsOutlet.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Products",
                newName: "CreatedAt");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "CreatedAt", "Description", "ImageFileName", "Name", "price" },
                values: new object[,]
                {
                    { 1, "Nike", "Men", new DateTime(2024, 5, 24, 11, 32, 32, 151, DateTimeKind.Local).AddTicks(6130), "The Nike V2K Run Sneaker is a blend of nostalgic style and modern performance,ideal for those looking for a sneaker that performs well in both casual and athletic settings.", "Nike V2k Run Sneaker 1.jpg", "Nike V2k Run Sneaker 1", 160m },
                    { 2, "Nike", "Men", new DateTime(2024, 5, 24, 11, 32, 32, 151, DateTimeKind.Local).AddTicks(6186), "The Nike Air Foamposite Pro Forest is a fusion of style and functionality. Its bold design, durable construction,and advanced cushioning make it a favorite among sneaker collectors and athletes..", "Nike Air Foamposite Pro Forest.jpg", "Nike Air Foamposite Pro Forest", 420m },
                    { 3, "Adidas", "Men", new DateTime(2024, 5, 24, 11, 32, 32, 151, DateTimeKind.Local).AddTicks(6190), "The Adidas Terrex line is highly regarded for its performance and reliability in outdoor settings.", "Adidas Terrex.jpg", "Adidas Terrex", 335m },
                    { 4, "Adidas", "Women", new DateTime(2024, 5, 24, 11, 32, 32, 151, DateTimeKind.Local).AddTicks(6194), "The Adidas Gazelle Indoor is a blend of classic style and modern functionality. ", "Adidas Gazelle Indoor.jpg", "Adidas Gazelle Indoor", 115m },
                    { 5, "Reebok", "Men", new DateTime(2024, 5, 24, 11, 32, 32, 151, DateTimeKind.Local).AddTicks(6198), "The Reebok BB4600 is a standout shoe that combines the best of old-school basketball aesthetics with modern comfort and durability.", "Reebok BB4600.jpg", "Reebok BB4600", 225m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Products",
                newName: "CreatedDate");
        }
    }
}
