using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shokhovshop.Migrations
{
    /// <inheritdoc />
    public partial class AddimgnamepriceinSetProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Set_Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Set_Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Set_Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Full_Name",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Set_Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Set_Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Set_Products");

            migrationBuilder.DropColumn(
                name: "Full_Name",
                table: "Orders");
        }
    }
}
