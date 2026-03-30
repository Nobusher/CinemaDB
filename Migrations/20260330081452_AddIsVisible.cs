using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaDB.Migrations
{
    /// <inheritdoc />
    public partial class AddIsVisible : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Sessions",
                type: "boolean",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVisible",
                table: "Films",
                type: "boolean",
                nullable: false,
                defaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "IsVisible",
                table: "Films");
        }
    }
}
