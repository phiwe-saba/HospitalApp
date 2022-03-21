using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalAppDAL.Migrations
{
    public partial class AddToAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressID", "AddressLine1", "AddressLine2", "PatientID", "SuburbID" },
                values: new object[] { 1, "Admirality Way", "", 1, 4 });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2022, 3, 19, 0, 14, 58, 186, DateTimeKind.Local).AddTicks(8626));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "PatientID",
                keyValue: 1,
                column: "DOB",
                value: new DateTime(2022, 3, 19, 0, 5, 31, 564, DateTimeKind.Local).AddTicks(3807));
        }
    }
}
