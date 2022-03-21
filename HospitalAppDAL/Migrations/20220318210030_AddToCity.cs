using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAppDAL.Migrations
{
    public partial class AddToCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "ProvinceID" },
                values: new object[] { 1, "Port Elizabeth", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 1);
        }
    }
}
