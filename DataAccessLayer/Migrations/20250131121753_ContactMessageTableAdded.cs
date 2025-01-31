using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ContactMessageTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("87324275-992e-432d-a4aa-2b385af6de9b"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("c88950fa-04a4-436e-932b-d94c878b2e4c"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("c1e8d8b6-7b78-4c80-a4cf-00f5587ca261"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("edb93356-d6ed-4f5a-aece-6594c98db547"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("15bfe2bd-63f5-4320-9724-eae45651163c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("d6d6e60f-9dfb-4d9f-acfd-fb2039cac0f4"));

            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "DateAchieved", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("d93af781-ffde-4f30-a173-bb21d867f456"), new DateTime(2025, 1, 31, 12, 17, 50, 61, DateTimeKind.Utc).AddTicks(9548), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awarded for outstanding performance and dedication to the company.", false, "Employee of the Month" },
                    { new Guid("ee51b213-aba2-467e-adbb-cd6cdc4728a2"), new DateTime(2025, 1, 31, 12, 17, 50, 61, DateTimeKind.Utc).AddTicks(9559), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Successfully completed the C# certification exam with high distinction.", false, "Certified C# Developer" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60f812e7-9374-4623-873b-c28d9f6437e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9d52355-adbc-476a-84f4-3685cb0e55d5", "AQAAAAIAAYagAAAAEIxNsCpmuUizstbpIsXre60FOe9zixXwbZ99IyZKMU7REimisc4xgUmDnOfZYMbi8A==", "694753d1-a0d7-4175-b9c3-aebb54c30a69" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageId", "IsDeleted", "ProjectUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("680cf4f0-9a0a-457a-b689-ce04063af945"), new DateTime(2025, 1, 31, 12, 17, 50, 62, DateTimeKind.Utc).AddTicks(5237), "A fully responsive e-commerce platform with payment integration and user authentication.", null, false, "https://www.myecommerceproject.com", "E-Commerce Website" },
                    { new Guid("78c76386-d5e3-4c7d-8b31-843214b1592c"), new DateTime(2025, 1, 31, 12, 17, 50, 62, DateTimeKind.Utc).AddTicks(5241), "A web-based task management application to help teams collaborate effectively.", null, false, "https://www.taskmanagerapp.com", "Task Management App" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProfiencyLevel" },
                values: new object[,]
                {
                    { new Guid("4bbc48f7-cec2-4249-bf8c-dbc60c09c55a"), new DateTime(2025, 1, 31, 12, 17, 50, 62, DateTimeKind.Utc).AddTicks(7328), false, "Web Development", "Intermediate" },
                    { new Guid("812e0042-e58d-403d-b3a1-973c46c6439a"), new DateTime(2025, 1, 31, 12, 17, 50, 62, DateTimeKind.Utc).AddTicks(7306), false, "C# Programming", "Advanced" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("d93af781-ffde-4f30-a173-bb21d867f456"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("ee51b213-aba2-467e-adbb-cd6cdc4728a2"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("680cf4f0-9a0a-457a-b689-ce04063af945"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("78c76386-d5e3-4c7d-8b31-843214b1592c"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4bbc48f7-cec2-4249-bf8c-dbc60c09c55a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("812e0042-e58d-403d-b3a1-973c46c6439a"));

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "DateAchieved", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("87324275-992e-432d-a4aa-2b385af6de9b"), new DateTime(2025, 1, 29, 17, 39, 45, 879, DateTimeKind.Utc).AddTicks(2204), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awarded for outstanding performance and dedication to the company.", false, "Employee of the Month" },
                    { new Guid("c88950fa-04a4-436e-932b-d94c878b2e4c"), new DateTime(2025, 1, 29, 17, 39, 45, 879, DateTimeKind.Utc).AddTicks(2210), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Successfully completed the C# certification exam with high distinction.", false, "Certified C# Developer" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60f812e7-9374-4623-873b-c28d9f6437e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7659f9e-eb2b-4c1f-886b-8865a206d51d", "AQAAAAIAAYagAAAAEFX2ViRRR/3iqLai2OBNwZ0ey2dJgcyuOSvfCOBD0oUve95is3XMECEOKxe3m9ln2w==", "e5072109-f8bd-4bdf-93fd-0edfa7f7d55d" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageId", "IsDeleted", "ProjectUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("c1e8d8b6-7b78-4c80-a4cf-00f5587ca261"), new DateTime(2025, 1, 29, 17, 39, 45, 879, DateTimeKind.Utc).AddTicks(5701), "A fully responsive e-commerce platform with payment integration and user authentication.", null, false, "https://www.myecommerceproject.com", "E-Commerce Website" },
                    { new Guid("edb93356-d6ed-4f5a-aece-6594c98db547"), new DateTime(2025, 1, 29, 17, 39, 45, 879, DateTimeKind.Utc).AddTicks(5704), "A web-based task management application to help teams collaborate effectively.", null, false, "https://www.taskmanagerapp.com", "Task Management App" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProfiencyLevel" },
                values: new object[,]
                {
                    { new Guid("15bfe2bd-63f5-4320-9724-eae45651163c"), new DateTime(2025, 1, 29, 17, 39, 45, 879, DateTimeKind.Utc).AddTicks(7882), false, "C# Programming", "Advanced" },
                    { new Guid("d6d6e60f-9dfb-4d9f-acfd-fb2039cac0f4"), new DateTime(2025, 1, 29, 17, 39, 45, 879, DateTimeKind.Utc).AddTicks(7899), false, "Web Development", "Intermediate" }
                });
        }
    }
}
