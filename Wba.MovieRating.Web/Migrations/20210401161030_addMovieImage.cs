using Microsoft.EntityFrameworkCore.Migrations;

namespace Wba.MovieRating.Web.Migrations
{
    public partial class addMovieImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Movies");
        }
    }
}
