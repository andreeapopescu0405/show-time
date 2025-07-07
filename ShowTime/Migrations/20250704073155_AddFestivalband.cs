using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowTime.Migrations
{
    /// <inheritdoc />
    public partial class AddFestivalband : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BandFestival");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Bookings");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Bookings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FestivalsBands",
                columns: table => new
                {
                    FestivalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FestivalsBands", x => new { x.FestivalId, x.BandId });
                    table.ForeignKey(
                        name: "FK_FestivalsBands_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FestivalsBands_Festivals_FestivalId",
                        column: x => x.FestivalId,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FestivalsBands_BandId",
                table: "FestivalsBands",
                column: "BandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FestivalsBands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "Guid",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "Guid");

            migrationBuilder.CreateTable(
                name: "BandFestival",
                columns: table => new
                {
                    BandsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FestivalsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandFestival", x => new { x.BandsId, x.FestivalsId });
                    table.ForeignKey(
                        name: "FK_BandFestival_Bands_BandsId",
                        column: x => x.BandsId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BandFestival_Festivals_FestivalsId",
                        column: x => x.FestivalsId,
                        principalTable: "Festivals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BandFestival_FestivalsId",
                table: "BandFestival",
                column: "FestivalsId");
        }
    }
}
