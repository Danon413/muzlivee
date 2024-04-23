using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWebsite.Server.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ProductVariants",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ProductTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(700)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(700)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 25, 14, 36, 7, 745, DateTimeKind.Local).AddTicks(6415));
        }
    }
}
