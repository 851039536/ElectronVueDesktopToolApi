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
            migrationBuilder.InsertData(
                table: "cmd",
                columns: new[] { "Id", "key_value", "Name", "TypeId" },
                values: new object[] { 3, "test", "百小僧", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cmd",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
