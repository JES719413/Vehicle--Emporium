using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle__Emporium.Migrations
{
    public partial class engineAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "engineAdded",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aaa9163-f58c-48cc-be0f-5a5539bf619d", "005f28ab-87e9-4ace-99e1-3de2096b5f88", "ADMIN", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "39cee74a-07f1-400c-8fa3-e48229f17aa3", 0, "675ae4ae-a85d-45e4-b019-dd9834de9034", "Admin@test.com", true, false, null, "Admin@test.com", "Admin@test.com", "AQAAAAEAACcQAAAAEEV++bRp+gGos0TcBi9XDdvs6d/6nIGpp4guzofvFRxpxaxh0T1xLR4B6NoH9KezcQ==", null, false, "d37e813f-6a9b-4787-98f6-f1c099f1fbeb", false, "Admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8aaa9163-f58c-48cc-be0f-5a5539bf619d", "39cee74a-07f1-400c-8fa3-e48229f17aa3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8aaa9163-f58c-48cc-be0f-5a5539bf619d", "39cee74a-07f1-400c-8fa3-e48229f17aa3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aaa9163-f58c-48cc-be0f-5a5539bf619d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39cee74a-07f1-400c-8fa3-e48229f17aa3");

            migrationBuilder.DropColumn(
                name: "engineAdded",
                table: "Vehicles");

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
    }
}
