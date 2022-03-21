using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAppDAL.Migrations
{
    public partial class AddToPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "PatientID", "DOB", "EmailAddress", "FullNames", "Gender", "MobileNumber" },
                values: new object[] { 1, new DateTime(2022, 3, 19, 0, 5, 31, 564, DateTimeKind.Local).AddTicks(3807), "charmaine@gmail.com", "Charmaine Meintjies", "Female", "0832458796" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: 1);
        }
    }
}
