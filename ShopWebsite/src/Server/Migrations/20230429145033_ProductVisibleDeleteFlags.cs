using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWebsite.Server.Migrations
{
    public partial class ProductVisibleDeleteFlags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ProductVariants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ProductVariants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6046), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6053), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6056), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6059), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6062), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6065), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6068), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6071), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6074), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6077), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6079), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6082), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6085), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6088), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6091), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6093), true });

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6097), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5986), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5991), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5995), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(5998), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6001), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6005), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6008), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6012), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6016), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6019), true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 17, 50, 32, 782, DateTimeKind.Local).AddTicks(6022), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(864));
        }
    }
}
