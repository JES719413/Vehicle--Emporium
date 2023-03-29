using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle__Emporium.Migrations
{
    public partial class SeedAdmin3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "aca3ded3-22bd-4d5f-aaba-dbf269b90ef7", "766edcc2-c01f-4229-a6c7-8f4517f448f3", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1526973c-74dc-4564-aaa4-21988ee56edc", 0, "7423777f-13d2-450c-aaee-66b82508496a", "Admin@test.com", true, false, null, "Admin@test.com", "Admin@test.com", "AQAAAAEAACcQAAAAENaajZNtdpVtI/4JAqZ6MHxbGCiqw2HsG4LT2NPve5d9lvyVqZUjUjnE4J1I/1rSmA==", null, false, "3366a7ee-24d6-4eaf-805c-903295c213cd", false, "Admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aca3ded3-22bd-4d5f-aaba-dbf269b90ef7", "1526973c-74dc-4564-aaa4-21988ee56edc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aca3ded3-22bd-4d5f-aaba-dbf269b90ef7", "1526973c-74dc-4564-aaa4-21988ee56edc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca3ded3-22bd-4d5f-aaba-dbf269b90ef7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1526973c-74dc-4564-aaa4-21988ee56edc");

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
    }
}
