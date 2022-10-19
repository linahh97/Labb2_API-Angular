using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2_API_Angular.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PersonalNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Management" },
                    { 2, "Human Resources" },
                    { 3, "Marketing and Sales" },
                    { 4, "IT" },
                    { 5, "Finance" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
