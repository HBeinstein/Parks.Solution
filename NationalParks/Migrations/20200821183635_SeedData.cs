using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParks.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Parks");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State", "StateOrNational" },
                values: new object[,]
                {
                    { 1, "Yosemite National Park", "California", "National" },
                    { 2, "Glacier National Park", "Montana", "National" },
                    { 3, "Zion National Park", "Utah", "National" },
                    { 4, "Olympic National Park", "Washington", "National" },
                    { 5, "Ecola State Park", "Oregon", "State" },
                    { 6, "Niagara Falls State Park", "New York", "State" },
                    { 7, "Smith Rock State Park", "Oregon", "State" },
                    { 8, "Shasta State Historic Park", "California", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Parks",
                nullable: true);
        }
    }
}
