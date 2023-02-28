using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shokhovshop.Migrations
{
    /// <inheritdoc />
    public partial class Upsetproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Set_Product_Products_ProductId",
                table: "Set_Product");

            migrationBuilder.DropIndex(
                name: "IX_Set_Product_ProductId",
                table: "Set_Product");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Set_Product");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Set_Product",
                newName: "Id_Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_Product",
                table: "Set_Product",
                newName: "Quantity");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Set_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Set_Product_ProductId",
                table: "Set_Product",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Set_Product_Products_ProductId",
                table: "Set_Product",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
