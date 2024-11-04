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
                    { "4db37310-2854-498a-ac5c-68139fc844ef", null, "user", "USER" },
                    { "7ec6c861-01d6-44b8-a7cd-a9fc6f8af6ba", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "59e735cf-46a1-4553-b462-206164809dbd", 0, "c640059e-ce74-4075-bbf6-921f4d9578c8", "user@correo.com", true, false, null, "USER@CORREO.COM", "USER", "AQAAAAIAAYagAAAAEMz42VR5N/0DY8pST5zvzOQdCr6Nxrh0k5wXJblJPN/50wwoXAGydPy/u2U6QPI3Ng==", null, false, "50b653db-fda5-4f72-a260-e77305f66da9", false, "user" },
                    { "f4d47946-974e-4dc7-9094-ea246ae28988", 0, "00d5ac00-96ce-4fe1-8a92-d620c27bfccd", "admin@correo.com", true, false, null, "ADMIN@CORREO.COM", "ADMIN", "AQAAAAIAAYagAAAAEFX48uaRSpCTE0gPXISl/csrNEE4ztJ7o2dCAocA0KrIoxG7tjFC6e7pMRTmgLpz5Q==", null, false, "1904ff98-c734-4a0e-9327-e1e655f0dd78", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4db37310-2854-498a-ac5c-68139fc844ef", "59e735cf-46a1-4553-b462-206164809dbd" },
                    { "7ec6c861-01d6-44b8-a7cd-a9fc6f8af6ba", "f4d47946-974e-4dc7-9094-ea246ae28988" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4db37310-2854-498a-ac5c-68139fc844ef", "59e735cf-46a1-4553-b462-206164809dbd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ec6c861-01d6-44b8-a7cd-a9fc6f8af6ba", "f4d47946-974e-4dc7-9094-ea246ae28988" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4db37310-2854-498a-ac5c-68139fc844ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ec6c861-01d6-44b8-a7cd-a9fc6f8af6ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59e735cf-46a1-4553-b462-206164809dbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4d47946-974e-4dc7-9094-ea246ae28988");
        }
    }
}
