using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ejercicio14.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "36f4b365-893f-4ce5-ad23-dbf0fb6be867", null, "user", "USER" },
                    { "ff5ddbdc-6c64-41fa-8a6d-7f198faba721", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6557ea1f-06ea-466f-b120-17d8eab77b2c", 0, "35777b6e-d874-4357-880f-32f46ca18783", "user@correo.com", true, false, null, "USER@CORREO.COM", null, "AQAAAAIAAYagAAAAEOUdylCHeh8ousHt0M/FXY//JIABOjUv4taZqrrW3k8pLdjbjcqujX4aTtbSj0aUbw==", null, false, "3075d865-219b-4e36-b2a1-2a024feb6e0b", false, "user" },
                    { "92809db0-a4bd-45e6-b077-135fa6e941e6", 0, "36f2a3b6-04cc-46cd-91cf-1826644e9ed4", "admin@correo.com", true, false, null, "ADMIN@CORREO.COM", null, "AQAAAAIAAYagAAAAEEoxezY03AiviKZSi2CMaK3DRyQsDhdfFA3rvl8Vvo11v+3ve6wGITa3h1MUor+myA==", null, false, "eff63437-2d4c-45aa-a85b-c6892dd729be", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "36f4b365-893f-4ce5-ad23-dbf0fb6be867", "6557ea1f-06ea-466f-b120-17d8eab77b2c" },
                    { "ff5ddbdc-6c64-41fa-8a6d-7f198faba721", "92809db0-a4bd-45e6-b077-135fa6e941e6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "36f4b365-893f-4ce5-ad23-dbf0fb6be867", "6557ea1f-06ea-466f-b120-17d8eab77b2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff5ddbdc-6c64-41fa-8a6d-7f198faba721", "92809db0-a4bd-45e6-b077-135fa6e941e6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36f4b365-893f-4ce5-ad23-dbf0fb6be867");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff5ddbdc-6c64-41fa-8a6d-7f198faba721");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6557ea1f-06ea-466f-b120-17d8eab77b2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92809db0-a4bd-45e6-b077-135fa6e941e6");
        }
    }
}
