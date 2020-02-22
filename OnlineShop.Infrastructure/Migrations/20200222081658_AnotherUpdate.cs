using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Infrastructure.Migrations
{
    public partial class AnotherUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartId1",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartOrderId",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                columns: new[] { "Id", "OrderId" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientID",
                table: "Orders",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id_ClientID",
                table: "Orders",
                columns: new[] { "Id", "ClientID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CartId",
                table: "Items",
                column: "CartId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_Id",
                table: "Items",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CartId1_CartOrderId",
                table: "Items",
                columns: new[] { "CartId1", "CartOrderId" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Id",
                table: "Clients",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_OrderId",
                table: "Carts",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Id_OrderId",
                table: "Carts",
                columns: new[] { "Id", "OrderId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Orders_OrderId",
                table: "Carts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Carts_CartId1_CartOrderId",
                table: "Items",
                columns: new[] { "CartId1", "CartOrderId" },
                principalTable: "Carts",
                principalColumns: new[] { "Id", "OrderId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientID",
                table: "Orders",
                column: "ClientID",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Orders_OrderId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Carts_CartId1_CartOrderId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_Id_ClientID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Items_CartId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_Id",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CartId1_CartOrderId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Clients_Id",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_OrderId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_Id_OrderId",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CartOrderId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");
        }
    }
}
