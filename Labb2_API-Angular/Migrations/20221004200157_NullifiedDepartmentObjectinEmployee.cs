using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2_API_Angular.Migrations
{
    public partial class NullifiedDepartmentObjectinEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("3740f8ee-b2b4-49c1-b46b-952f4084e2a5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("3caa2baa-1703-4380-b906-a6fd86cb7aef"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("3eaf4389-6f3c-4371-a451-fb6ec1b0bbd0"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("3ec39fac-c118-4c3a-a2e3-9793901b556a"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PersonalNumber", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { new Guid("074a61d9-4bb5-4601-9cbe-3a9050fabe36"), "Riksbyvägen 43", 2, "bunny_boo@gmail.com", "Sasha", "Female", "Mason", "9610217483", "0735890521", 34200 },
                    { new Guid("0a980a8b-8c20-4be1-843b-a6647bf6e110"), "Storgatan 32a", 4, "koolkat4@gmail.com", "Jade", "Female", "Hunter", "9607111829", "0721228563", 33200 },
                    { new Guid("7e7e4179-b1c7-4e2b-b81e-1ba87745b7de"), "Drottninggatan 6b", 3, "angel85@gmail.com", "Cloe", "Female", "Santon", "9702235461", "0709876543", 33700 },
                    { new Guid("f3d59cdb-a2e3-4b8c-87b4-010604593e1a"), "Kungsgatan 1", 1, "pretty_princess10@gmail.com", "Yasmin", "Female", "Larian", "9708191229", "0751231234", 34000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("074a61d9-4bb5-4601-9cbe-3a9050fabe36"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("0a980a8b-8c20-4be1-843b-a6647bf6e110"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("7e7e4179-b1c7-4e2b-b81e-1ba87745b7de"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("f3d59cdb-a2e3-4b8c-87b4-010604593e1a"));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Address", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PersonalNumber", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { new Guid("3740f8ee-b2b4-49c1-b46b-952f4084e2a5"), "Riksbyvägen 43", 2, "bunny_boo@gmail.com", "Sasha", "Female", "Mason", "9610217483", "0735890521", 34200 },
                    { new Guid("3caa2baa-1703-4380-b906-a6fd86cb7aef"), "Storgatan 32a", 4, "koolkat4@gmail.com", "Jade", "Female", "Hunter", "9607111829", "0721228563", 33200 },
                    { new Guid("3eaf4389-6f3c-4371-a451-fb6ec1b0bbd0"), "Drottninggatan 6b", 3, "angel85@gmail.com", "Cloe", "Female", "Santon", "9702235461", "0709876543", 33700 },
                    { new Guid("3ec39fac-c118-4c3a-a2e3-9793901b556a"), "Kungsgatan 1", 1, "pretty_princess10@gmail.com", "Yasmin", "Female", "Larian", "9708191229", "0751231234", 34000 }
                });
        }
    }
}
