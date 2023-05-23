using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class portfolioEntityRevise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Portfolios",
                newName: "ProjectUrl");

            migrationBuilder.AddColumn<string>(
                name: "ImageFullUrl",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageShortUrl",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFullUrl",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "ImageShortUrl",
                table: "Portfolios");

            migrationBuilder.RenameColumn(
                name: "ProjectUrl",
                table: "Portfolios",
                newName: "ImageUrl");
        }
    }
}
