using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAppDAL.Migrations
{
    public partial class AddDoctorsDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorID", "FirstName", "LastName", "MobileNumber" },
                values: new object[] { 1, "John", "Smith", "0724588841" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorID", "FirstName", "LastName", "MobileNumber" },
                values: new object[] { 2, "Miraim", "Nkosi", "0715689551" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorID",
                keyValue: 2);
        }
    }
}
