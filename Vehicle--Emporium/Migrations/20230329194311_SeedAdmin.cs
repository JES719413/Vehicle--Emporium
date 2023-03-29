using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle__Emporium.Migrations
{
    public partial class SeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297", "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a19c1725-ad09-4643-b551-33bc7c90fa5c", "e8f83272-0575-4a22-9bec-d3cb8204152a", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5668aa91-cfcf-4c4c-9690-8b65b570c5ef", 0, "acba3cbe-8824-430c-9efa-d3ea44c79d0a", "Admin@test.com", true, false, null, "Admin@test.com", "Admin", "AQAAAAEAACcQAAAAEFpLoCMPz2Hrebl8PEpFA59GulwONsJ5kqH5qgtnIRa2WPCLAtDTS15XHxfvGdI9cg==", null, false, "497e6f57-1967-4940-873f-01c1f0442582", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a19c1725-ad09-4643-b551-33bc7c90fa5c", "5668aa91-cfcf-4c4c-9690-8b65b570c5ef" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a19c1725-ad09-4643-b551-33bc7c90fa5c", "5668aa91-cfcf-4c4c-9690-8b65b570c5ef" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a19c1725-ad09-4643-b551-33bc7c90fa5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5668aa91-cfcf-4c4c-9690-8b65b570c5ef");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297", "6d274735-8c23-497e-bda0-85ba6db84a51", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214", 0, "208ddb3f-cc7c-4a5f-b4d4-61c108826023", "Admin@test.com", true, false, null, "Admin@test.com", "Admin", "AQAAAAEAACcQAAAAEFgNKpu8dNK1Cys+8B+BJcULzyZe1cD+U5tgPXgMEhJ1eDtapsDqm2AYDZzxfDADdg==", null, false, "cedeba31-2b8c-4368-bcc9-8b94aaa701f9", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297", "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214" });
        }
    }
}
