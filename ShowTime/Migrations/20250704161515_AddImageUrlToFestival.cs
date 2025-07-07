using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowTime.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrlToFestival : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Festivals",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Festivals");
        }
    }
}
