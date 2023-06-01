using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronVueDesktopToolApi.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "up_down",
                columns: new[] { "Id", "down_zip_path", "un_zip_path", "up_zip_path", "ZipName" },
                values: new object[] { 1, "C:\\\\Users\\\\ch190006\\\\Desktop\\\\Test", "C:\\\\Users\\\\ch190006\\\\Desktop\\\\Test", "C:\\\\Users\\\\ch190006\\\\Desktop\\\\Test\\\\test1\\\\test2.zip", "test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "up_down",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
