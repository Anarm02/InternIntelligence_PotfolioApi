using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("138d7fef-09e4-4faa-b41e-2fb469a1e406"));

            migrationBuilder.DeleteData(
                table: "Achievements",
                keyColumn: "Id",
                keyValue: new Guid("abe858ca-3ca3-41a4-b4cc-e6f03632e695"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("2b7a0510-466d-4e8f-a857-2c6a926d3289"));

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: new Guid("59222e65-3c7c-4f1a-9b2b-5cfead251558"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("436b1191-2286-4f21-9f91-b34329887aad"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("a3164b39-0fe5-4b56-942c-2322cdfeece8"));

            migrationBuilder.InsertData(
                table: "Achievements",
                columns: new[] { "Id", "CreatedAt", "DateAchieved", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { new Guid("b05e53dd-909c-4c36-8d59-1253e28c6c30"), new DateTime(2025, 1, 29, 17, 28, 43, 579, DateTimeKind.Utc).AddTicks(5787), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Successfully completed the C# certification exam with high distinction.", false, "Certified C# Developer" },
                    { new Guid("b1eb353a-c19e-4377-8f97-d8182a2349f2"), new DateTime(2025, 1, 29, 17, 28, 43, 579, DateTimeKind.Utc).AddTicks(5781), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awarded for outstanding performance and dedication to the company.", false, "Employee of the Month" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiration", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("60f812e7-9374-4623-873b-c28d9f6437e4"), 0, "f3a3520f-eb68-41e9-801a-61e61cb60b66", "superadmin@gmail.com", true, "Anar Mammadli", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEI0kKR911EbRESYVt+4pPCRSK9qE9AhP3wjWEq6ZhamJloXcuSjcEiGTNr4FJ7yiZg==", "+9940506983552", true, null, null, "16297386-886d-47cf-acbc-fa56bd79b277", false, "superadmin@gmail.com" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60f812e7-9374-4623-873b-c28d9f6437e4"));

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
                    { new Guid("138d7fef-09e4-4faa-b41e-2fb469a1e406"), new DateTime(2025, 1, 29, 17, 18, 2, 729, DateTimeKind.Utc).AddTicks(1202), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Successfully completed the C# certification exam with high distinction.", false, "Certified C# Developer" },
                    { new Guid("abe858ca-3ca3-41a4-b4cc-e6f03632e695"), new DateTime(2025, 1, 29, 17, 18, 2, 729, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Awarded for outstanding performance and dedication to the company.", false, "Employee of the Month" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageId", "IsDeleted", "ProjectUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("2b7a0510-466d-4e8f-a857-2c6a926d3289"), new DateTime(2025, 1, 29, 17, 18, 2, 729, DateTimeKind.Utc).AddTicks(5536), "A web-based task management application to help teams collaborate effectively.", null, false, "https://www.taskmanagerapp.com", "Task Management App" },
                    { new Guid("59222e65-3c7c-4f1a-9b2b-5cfead251558"), new DateTime(2025, 1, 29, 17, 18, 2, 729, DateTimeKind.Utc).AddTicks(5510), "A fully responsive e-commerce platform with payment integration and user authentication.", null, false, "https://www.myecommerceproject.com", "E-Commerce Website" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Name", "ProfiencyLevel" },
                values: new object[,]
                {
                    { new Guid("436b1191-2286-4f21-9f91-b34329887aad"), new DateTime(2025, 1, 29, 17, 18, 2, 729, DateTimeKind.Utc).AddTicks(9175), false, "Web Development", "Intermediate" },
                    { new Guid("a3164b39-0fe5-4b56-942c-2322cdfeece8"), new DateTime(2025, 1, 29, 17, 18, 2, 729, DateTimeKind.Utc).AddTicks(9170), false, "C# Programming", "Advanced" }
                });
        }
    }
}
