using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Infrastructure.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Items",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Carts",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Carts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Items",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Carts",
                newName: "ID");
        }
    }
}
