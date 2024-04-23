using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopWebsite.Server.Migrations
{
    public partial class UserAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 29, 11, 49, 49, 943, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 3 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 1, 4 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 2, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 3, 2 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 6 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 4, 7 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 5, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 6, 5 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 9 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 7, 10 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 8, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 9, 8 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 10, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { 11, 1 },
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2023, 4, 27, 22, 46, 44, 100, DateTimeKind.Local).AddTicks(4389));
        }
    }
}
