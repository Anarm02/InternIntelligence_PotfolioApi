using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ChangePassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b05e53dd-909c-4c36-8d59-1253e28c6c30"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("b1eb353a-c19e-4377-8f97-d8182a2349f2"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("5e5c73ab-7f40-41fe-9c50-61dc788374b8"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("a64317f2-c364-496e-82cc-f66d49b44ae0"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("30dcb638-5e1e-4ede-b6cb-c0fe92eaf22a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("e780455e-15e1-4400-b806-219704fa8904"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "DateAchieved", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("b05e53dd-909c-4c36-8d59-1253e28c6c30"), new DateTime(2025, 1, 29, 17, 28, 43, 579, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Successfully completed the C# certification exam with high distinction.", false, "Certified C# Developer" },
                    { new Guid("b1eb353a-c19e-4377-8f97-d8182a2349f2"), new DateTime(2025, 1, 29, 17, 28, 43, 579, DateTimeKind.Utc).AddTicks(5781), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awarded for outstanding performance and dedication to the company.", false, "Employee of the Month" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60f812e7-9374-4623-873b-c28d9f6437e4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3a3520f-eb68-41e9-801a-61e61cb60b66", "AQAAAAIAAYagAAAAEI0kKR911EbRESYVt+4pPCRSK9qE9AhP3wjWEq6ZhamJloXcuSjcEiGTNr4FJ7yiZg==", "16297386-886d-47cf-acbc-fa56bd79b277" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageId", "IsDeleted", "ProjectUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("5e5c73ab-7f40-41fe-9c50-61dc788374b8"), new DateTime(2025, 1, 29, 17, 28, 43, 579, DateTimeKind.Utc).AddTicks(9181), "A web-based task management application to help teams collaborate effectively.", null, false, "https://www.taskmanagerapp.com", "Task Management App" },
                    { new Guid("a64317f2-c364-496e-82cc-f66d49b44ae0"), new DateTime(2025, 1, 29, 17, 28, 43, 579, DateTimeKind.Utc).AddTicks(9177), "A fully responsive e-commerce platform with payment integration and user authentication.", null, false, "https://www.myecommerceproject.com", "E-Commerce Website" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProfiencyLevel" },
                values: new object[,]
                {
                    { new Guid("30dcb638-5e1e-4ede-b6cb-c0fe92eaf22a"), new DateTime(2025, 1, 29, 17, 28, 43, 580, DateTimeKind.Utc).AddTicks(3285), false, "C# Programming", "Advanced" },
                    { new Guid("e780455e-15e1-4400-b806-219704fa8904"), new DateTime(2025, 1, 29, 17, 28, 43, 580, DateTimeKind.Utc).AddTicks(3291), false, "Web Development", "Intermediate" }
                });
        }
    }
}
