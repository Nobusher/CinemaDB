using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaDB.Migrations
{
    /// <inheritdoc />
    public partial class AddCinemaView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("""
                CREATE VIEW "CinemaView" AS
                SELECT s."Id", f."Title", d."Name" AS "DirectorName",
                g."Name" AS "GenreName", h."Name" AS "HallName",
                s."DateTime", s."Price"
                FROM "Sessions" s
                JOIN "Films" f ON f."Id" = s."FilmID"
                JOIN "Directors" d ON d."Id" = f."DirectorId"
                JOIN "Genres" g ON g."Id" = f."GenreId"
                JOIN "Halls" h ON h."Id" = s."HallId"
                WHERE s."IsVisible" = true AND f."IsVisible" = true
                """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW ""CinemaView""");
        }
    }
}
