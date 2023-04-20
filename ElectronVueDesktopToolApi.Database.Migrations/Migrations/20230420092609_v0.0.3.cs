using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectronVueDesktopToolApi.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "cmd",
                columns: new[] { "Id", "key_value", "Name", "TypeId" },
                values: new object[,]
                {
                    { 14, "mstsc", "远程桌面", 1 },
                    { 15, "regedit", "注册表", 1 },
                    { 16, "control", "控制面板", 1 },
                    { 17, "ncpa.cpl", "网络", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
