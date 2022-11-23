using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.AdvertisementApp.DataAccess.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Defination" },
                values: new object[] { 1, "Member" });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Defination" },
                values: new object[] { 2, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
