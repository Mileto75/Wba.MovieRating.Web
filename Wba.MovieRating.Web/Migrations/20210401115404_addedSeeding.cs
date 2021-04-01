using Microsoft.EntityFrameworkCore.Migrations;

namespace Wba.MovieRating.Web.Migrations
{
    public partial class addedSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, "Keanu", "Reeves" },
                    { 2L, "Kim", "Basinger" },
                    { 3L, "Robert", "De Niro" },
                    { 4L, "Walter", "Capiau" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Warner Bros" },
                    { 2L, "Universal" },
                    { 3L, "Pixar" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, "Steven", "Spielberg" },
                    { 2L, "Sly", "Stallone" },
                    { 3L, "Kathryn", "Bigelow" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Username" },
                values: new object[,]
                {
                    { 1L, "Slash", "Slash", "slash@GandR.com" },
                    { 2L, "John", "Frusciante", "johnF@RedHotChillis.com" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CompanyId", "ReleaseDate", "Title" },
                values: new object[] { 1L, 1L, null, "Point Break" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CompanyId", "ReleaseDate", "Title" },
                values: new object[] { 3L, 1L, null, "Rambo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CompanyId", "ReleaseDate", "Title" },
                values: new object[] { 2L, 2L, null, "Rocky" });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 3L },
                    { 3L, 3L },
                    { 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "MovieDirectors",
                columns: new[] { "DirectorId", "MovieId" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 3L, 3L },
                    { 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MovieId", "Review", "Score", "UserId" },
                values: new object[,]
                {
                    { 1L, 1L, "Very good! Loved it!", 10, 1L },
                    { 2L, 3L, "Sucks monkeyballs!", 4, 2L },
                    { 3L, 3L, "Effing awesome!!", 10, 2L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2L, 3L });

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3L, 3L });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "MovieDirectors",
                keyColumns: new[] { "DirectorId", "MovieId" },
                keyValues: new object[] { 3L, 3L });

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
