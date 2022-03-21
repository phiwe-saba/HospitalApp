using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAppDAL.Migrations
{
    public partial class AddProvince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceID", "ProvinceName" },
                values: new object[] { 1, "Eastern Cape" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceID",
                keyValue: 1);
        }
    }
}
