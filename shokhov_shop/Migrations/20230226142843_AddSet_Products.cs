using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shokhovshop.Migrations
{
    /// <inheritdoc />
    public partial class AddSetProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_Product_Orders_OrderId",
                table: "Set_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Set_Product",
                table: "Set_Product");

            migrationBuilder.RenameTable(
                name: "Set_Product",
                newName: "Set_Products");

            migrationBuilder.RenameIndex(
                name: "IX_Set_Product_OrderId",
                table: "Set_Products",
                newName: "IX_Set_Products_OrderId");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Set_Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Set_Products",
                table: "Set_Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Products_Orders_OrderId",
                table: "Set_Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_Products_Orders_OrderId",
                table: "Set_Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Set_Products",
                table: "Set_Products");

            migrationBuilder.RenameTable(
                name: "Set_Products",
                newName: "Set_Product");

            migrationBuilder.RenameIndex(
                name: "IX_Set_Products_OrderId",
                table: "Set_Product",
                newName: "IX_Set_Product_OrderId");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Set_Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Set_Product",
                table: "Set_Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Product_Orders_OrderId",
                table: "Set_Product",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
