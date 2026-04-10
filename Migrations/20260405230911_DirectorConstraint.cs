using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CinemaDB.Migrations
{
    /// <inheritdoc />
    public partial class DirectorConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CinemaViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    DirectorName = table.Column<string>(type: "text", nullable: false),
                    GenreName = table.Column<string>(type: "text", nullable: false),
                    HallName = table.Column<string>(type: "text", nullable: false),
                    Datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaViews", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Directors_Name",
                table: "Directors",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CinemaViews");

            migrationBuilder.DropIndex(
                name: "IX_Directors_Name",
                table: "Directors");
        }
    }
}
