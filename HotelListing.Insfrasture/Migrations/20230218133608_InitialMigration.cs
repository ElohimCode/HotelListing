using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.Insfrasture.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotels_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryCode", "CountryName" },
                values: new object[,]
                {
                    { new Guid("12e15727-d369-49a9-8b13-bc22e9362179"), "CH", "China" },
                    { new Guid("14629847-905a-4a0e-9abe-80b61655c5cb"), "JM", "Jamaica" },
                    { new Guid("501c6d33-1bbe-45f1-8fbd-2275913c6218"), "BS", "Bahamas" },
                    { new Guid("56bf46a4-02b8-4693-a0f5-0a95e2218bdc"), "TH", "Thailand" },
                    { new Guid("8f30bedc-47dd-4286-8950-73d8a68e5d41"), "PT", "Palestinian Territory" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "CountryId", "HotelAddress", "HotelName", "Rating" },
                values: new object[,]
                {
                    { new Guid("8d2bef80-abe6-4aa4-b549-c145806f9cd1"), null, null, "Bala Blu Resort Centre", 4.0 },
                    { new Guid("91d88c68-bce7-46aa-8472-34ef6cb56719"), null, null, "Jen Resort Centre", 4.0 },
                    { new Guid("a7104362-6641-4e37-8a6c-994af5b56c25"), null, null, "Ben Resort Centre", 4.5 },
                    { new Guid("a9da989c-5d4b-43df-a905-aaff4f75d82f"), null, null, "Zeus Resort Centre", 3.7999999999999998 },
                    { new Guid("b455f8cb-b8ec-44af-8115-7bf00adc33d0"), null, null, "Zen Resort Centre", 5.0 },
                    { new Guid("c196b58a-6e17-499e-ba2d-10729f6c5a89"), null, null, "Nulen Resort Centre", 3.5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CountryId",
                table: "Hotels",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
