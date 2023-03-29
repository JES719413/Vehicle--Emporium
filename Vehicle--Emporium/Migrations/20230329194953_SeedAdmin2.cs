using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle__Emporium.Migrations
{
    public partial class SeedAdmin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c4258c18-677d-4595-8309-7e5990b51414", "9854d132-9dd4-497f-90fb-e0fdb703bc7e", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4cfdbe13-098f-4750-9d01-6d6bffa26d50", 0, "8df95c56-19c3-40fb-85f6-114b89a925a1", "Admin@test.com", true, false, null, "Admin@test.com", "Admin@test.com", "AQAAAAEAACcQAAAAEDOSflGLsgGsTMKt62gAqiOaud7JyZqywFPc3Tqz1w7KG9Df3SZdfAWdiBJKadXFKw==", null, false, "1d1af271-9ad2-4ddf-9fd3-f82def344c4c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c4258c18-677d-4595-8309-7e5990b51414", "4cfdbe13-098f-4750-9d01-6d6bffa26d50" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4258c18-677d-4595-8309-7e5990b51414", "4cfdbe13-098f-4750-9d01-6d6bffa26d50" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4258c18-677d-4595-8309-7e5990b51414");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4cfdbe13-098f-4750-9d01-6d6bffa26d50");

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
    }
}
