using Microsoft.EntityFrameworkCore.Migrations;

namespace EFNgApp.Migrations
{
    public partial class addCities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblCities",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { 1, "Bangalore" },
                    { 2, "Delhi" },
                    { 3, "Mangalore" },
                    { 4, "Hydrabad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblCities",
                keyColumn: "CityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblCities",
                keyColumn: "CityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblCities",
                keyColumn: "CityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblCities",
                keyColumn: "CityID",
                keyValue: 4);
        }
    }
}
