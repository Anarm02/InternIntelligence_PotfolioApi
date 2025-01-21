using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ProjectImageAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("1216b6e6-e924-4510-a737-79a90aaa23c9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("4aa3e5af-5af7-4ae2-9a0f-d4f506b62156"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("28ec600c-0749-4589-8ba2-a0f7f75e659d"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("8b4aa032-12f0-4f2c-9049-9521642869fd"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("36926819-2235-481e-8c0a-e4eb633c9572"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("dd8d8445-0a7a-475f-9ce5-baab336aa606"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Projects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectImages_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "DateAchieved", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("5844eb7d-b9d4-445a-8716-7f2199d3b0a9"), new DateTime(2025, 1, 21, 13, 48, 36, 899, DateTimeKind.Utc).AddTicks(2029), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Successfully completed the C# certification exam with high distinction.", false, "Certified C# Developer" },
                    { new Guid("58ea2db5-d993-4de8-a045-48208c762a2c"), new DateTime(2025, 1, 21, 13, 48, 36, 899, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awarded for outstanding performance and dedication to the company.", false, "Employee of the Month" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageId", "IsDeleted", "ProjectUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("1ccc79dd-f190-4aa9-9470-9cf4a84909c6"), new DateTime(2025, 1, 21, 13, 48, 36, 899, DateTimeKind.Utc).AddTicks(3568), "A web-based task management application to help teams collaborate effectively.", null, false, "https://www.taskmanagerapp.com", "Task Management App" },
                    { new Guid("a453f4eb-a9cf-4d59-87c0-31e750223fa3"), new DateTime(2025, 1, 21, 13, 48, 36, 899, DateTimeKind.Utc).AddTicks(3567), "A fully responsive e-commerce platform with payment integration and user authentication.", null, false, "https://www.myecommerceproject.com", "E-Commerce Website" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProfiencyLevel" },
                values: new object[,]
                {
                    { new Guid("1f470d7e-3763-4699-94dd-60b87d294c83"), new DateTime(2025, 1, 21, 13, 48, 36, 899, DateTimeKind.Utc).AddTicks(4851), false, "Web Development", "Intermediate" },
                    { new Guid("de168aa8-cca9-4fce-8711-b49008c15632"), new DateTime(2025, 1, 21, 13, 48, 36, 899, DateTimeKind.Utc).AddTicks(4849), false, "C# Programming", "Advanced" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImages_ProjectId",
                table: "ProjectImages",
                column: "ProjectId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectImages");

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("5844eb7d-b9d4-445a-8716-7f2199d3b0a9"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("58ea2db5-d993-4de8-a045-48208c762a2c"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("1ccc79dd-f190-4aa9-9470-9cf4a84909c6"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("a453f4eb-a9cf-4d59-87c0-31e750223fa3"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("1f470d7e-3763-4699-94dd-60b87d294c83"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("de168aa8-cca9-4fce-8711-b49008c15632"));

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Projects");

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
    }
}
