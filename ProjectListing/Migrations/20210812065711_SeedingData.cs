using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectListing.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Continent", "Name" },
                values: new object[,]
                {
                    { 1, "BZ", "North America", "Belize" },
                    { 2, "AU", "Oceania", "Australia" },
                    { 3, "ES", "Europe", "Spain" },
                    { 4, "JP", "	Asia", "Japan" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "383 Langosh Creek Toledo, Belize", 1, "Spring Mansion Hotel", 4.5999999999999996 },
                    { 2, "49409 Weimann Harbors, Australia", 2, "Majestic Star Resort & Spa", 5.0 },
                    { 3, "39452 Hintz Stravenue, Spain", 3, "Parallel Season Resort", 4.7999999999999998 },
                    { 4, "1428 Hills Village, Japan", 4, "Antique Mountain Motel", 3.7999999999999998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
