using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WSEcommerce.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NumberOfItemsOrdered",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "Orders",
                newName: "Zip");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Products",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "GiftWrap",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Line1",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Line2",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Line3",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CartLine",
                columns: table => new
                {
                    CartLineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductsProduct_Id = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrdersOrder_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLine", x => x.CartLineID);
                    table.ForeignKey(
                        name: "FK_CartLine_Orders_OrdersOrder_Id",
                        column: x => x.OrdersOrder_Id,
                        principalTable: "Orders",
                        principalColumn: "Order_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLine_Products_ProductsProduct_Id",
                        column: x => x.ProductsProduct_Id,
                        principalTable: "Products",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_OrdersOrder_Id",
                table: "CartLine",
                column: "OrdersOrder_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_ProductsProduct_Id",
                table: "CartLine",
                column: "ProductsProduct_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLine");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "GiftWrap",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Line1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Line2",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Line3",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Orders",
                newName: "ShippingAddress");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfItemsOrdered",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
