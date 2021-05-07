using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WSEcommerce.Migrations
{
    public partial class Photo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "ProjectRequests",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "ProjectRequests");
        }
    }
}
