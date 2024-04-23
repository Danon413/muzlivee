using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWebsite.Server.Migrations
{
    public partial class CategoryFlags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "CartItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Addresses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(817), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(821), true });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "Visible" },
                values: new object[] { new DateTime(2023, 4, 29, 13, 53, 36, 33, DateTimeKind.Local).AddTicks(824), true });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 13, 32, 29, 883, DateTimeKind.Local).AddTicks(9091));
        }
    }
}
