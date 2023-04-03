using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle__Emporium.Migrations
{
    public partial class UserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdda2848-a8c7-4dd9-aa6a-bfd7eab3825c", "32178259-0e3e-4995-a1a7-6bbef7b998fc", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b7181aec-735c-42ad-a116-4076c50f3fd3", 0, "5fe57313-e24f-473f-94a2-081a2ca52d9b", "Admin@test.com", true, false, null, "Admin@test.com", "Admin@test.com", "AQAAAAEAACcQAAAAEETlVhSKt3MZYnE+UoA5U2vOOeCWsLlHBzE1NGWkp1KfMN97agurrZRZDCUU4xosMQ==", null, false, "5d923624-caad-4a67-8c31-638e0b2f37b7", false, "Admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fdda2848-a8c7-4dd9-aa6a-bfd7eab3825c", "b7181aec-735c-42ad-a116-4076c50f3fd3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fdda2848-a8c7-4dd9-aa6a-bfd7eab3825c", "b7181aec-735c-42ad-a116-4076c50f3fd3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdda2848-a8c7-4dd9-aa6a-bfd7eab3825c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7181aec-735c-42ad-a116-4076c50f3fd3");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "Vehicles");

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
    }
}
