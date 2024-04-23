using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWebsite.Server.Migrations
{
    public partial class CartItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => new { x.UserId, x.ProductId, x.ProductTypeId });
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 16, 9, 52, 155, DateTimeKind.Local).AddTicks(7696));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3083));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 26, 17, 20, 2, 395, DateTimeKind.Local).AddTicks(3274));
        }
    }
}
