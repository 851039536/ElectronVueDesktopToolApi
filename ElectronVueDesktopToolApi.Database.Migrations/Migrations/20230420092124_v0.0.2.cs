using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronVueDesktopToolApi.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 4,
                column: "key_value",
                value: "shutdown -s -t 0");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 5,
                column: "key_value",
                value: "shutdown -r -t 0");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 6,
                column: "key_value",
                value: "shutdown -l -t 0");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 7,
                column: "key_value",
                value: "shutdown -a");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 8,
                column: "key_value",
                value: "explorer");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 9,
                column: "key_value",
                value: "explorer C:\\\\");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 10,
                column: "key_value",
                value: "explorer D:\\\\");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 11,
                column: "key_value",
                value: "explorer shell:desktop");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 12,
                column: "key_value",
                value: "explorer shell:mydocuments");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 13,
                column: "key_value",
                value: "explorer shell:downloads");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 4,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 5,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 6,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 7,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 8,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 9,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 10,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 11,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 12,
                column: "key_value",
                value: "taskmgr");

            migrationBuilder.UpdateData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 13,
                column: "key_value",
                value: "taskmgr");
        }
    }
}
