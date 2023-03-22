using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle__Emporium.Migrations
{
    public partial class UserAndRoleSeedFinal5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297",
                column: "ConcurrencyStamp",
                value: "6d274735-8c23-497e-bda0-85ba6db84a51");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "208ddb3f-cc7c-4a5f-b4d4-61c108826023", "Admin@test.com", "Admin@test.com", "AQAAAAEAACcQAAAAEFgNKpu8dNK1Cys+8B+BJcULzyZe1cD+U5tgPXgMEhJ1eDtapsDqm2AYDZzxfDADdg==", "cedeba31-2b8c-4368-bcc9-8b94aaa701f9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4a78c7-e1e5-4bb5-8e8c-7100132f1297",
                column: "ConcurrencyStamp",
                value: "babf3c9f-916e-410f-8461-7ec97b112ba8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c4a78c7-e1e5-4bb5-8e8c-7100132f1214",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e2997e-3d1d-49a6-bc32-c52ca5cb1263", "Admin@gmail.com", "Admin@gmail.com", "AQAAAAEAACcQAAAAEItK/I1+y7iV/SKlqsB7nkchtSJKge4OyS3YdnpIChBfonvL7o6H2WTEn15Bk31FuQ==", "ab08fda9-da6b-41ab-b04a-f487d2bd20d0" });
        }
    }
}
