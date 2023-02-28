using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace shokhovshop.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminTools : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Confirmed_Admin",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Confirmed_Admin",
                table: "Orders");
        }
    }
}
