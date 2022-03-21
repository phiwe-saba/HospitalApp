using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAppDAL.Migrations
{
    public partial class AddToSuburb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Suburbs",
                columns: new[] { "SuburbID", "CityID", "SuburbName" },
                values: new object[,]
                {
                    { 1, 1, "Adcock Vale" },
                    { 2, 1, "Algoapark" },
                    { 3, 1, "Humewood" },
                    { 4, 1, "Summerstrand" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suburbs",
                keyColumn: "SuburbID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suburbs",
                keyColumn: "SuburbID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suburbs",
                keyColumn: "SuburbID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suburbs",
                keyColumn: "SuburbID",
                keyValue: 4);
        }
    }
}
