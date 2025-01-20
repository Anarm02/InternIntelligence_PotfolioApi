using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAchieved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfiencyLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "DateAchieved", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("1216b6e6-e924-4510-a737-79a90aaa23c9"), new DateTime(2025, 1, 19, 9, 33, 32, 49, DateTimeKind.Utc).AddTicks(7502), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awarded for outstanding performance and dedication to the company.", false, "Employee of the Month" },
                    { new Guid("4aa3e5af-5af7-4ae2-9a0f-d4f506b62156"), new DateTime(2025, 1, 19, 9, 33, 32, 49, DateTimeKind.Utc).AddTicks(7513), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Successfully completed the C# certification exam with high distinction.", false, "Certified C# Developer" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "ProjectUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("28ec600c-0749-4589-8ba2-a0f7f75e659d"), new DateTime(2025, 1, 19, 9, 33, 32, 50, DateTimeKind.Utc).AddTicks(3283), "A web-based task management application to help teams collaborate effectively.", false, "https://www.taskmanagerapp.com", "Task Management App" },
                    { new Guid("8b4aa032-12f0-4f2c-9049-9521642869fd"), new DateTime(2025, 1, 19, 9, 33, 32, 50, DateTimeKind.Utc).AddTicks(3276), "A fully responsive e-commerce platform with payment integration and user authentication.", false, "https://www.myecommerceproject.com", "E-Commerce Website" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProfiencyLevel" },
                values: new object[,]
                {
                    { new Guid("36926819-2235-481e-8c0a-e4eb633c9572"), new DateTime(2025, 1, 19, 9, 33, 32, 50, DateTimeKind.Utc).AddTicks(7103), false, "Web Development", "Intermediate" },
                    { new Guid("dd8d8445-0a7a-475f-9ce5-baab336aa606"), new DateTime(2025, 1, 19, 9, 33, 32, 50, DateTimeKind.Utc).AddTicks(7100), false, "C# Programming", "Advanced" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievements");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
