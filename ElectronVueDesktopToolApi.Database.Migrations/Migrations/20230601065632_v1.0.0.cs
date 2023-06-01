using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectronVueDesktopToolApi.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd_type",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(3)", nullable: false, comment: "主键")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(40)", nullable: true, comment: "分类名称"),
                    Description = table.Column<string>(type: "text", nullable: true, comment: "描述")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd_type", x => x.Id);
                },
                comment: "窗口指令实体")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "up_down",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(4)", nullable: false, comment: "主键")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ZipName = table.Column<string>(type: "varchar(40)", nullable: true, comment: "zip名称"),
                    up_zip_path = table.Column<string>(type: "varchar(200)", nullable: true, comment: "上传路径"),
                    down_zip_path = table.Column<string>(type: "varchar(200)", nullable: true, comment: "下载到本地路径"),
                    un_zip_path = table.Column<string>(type: "varchar(200)", nullable: true, comment: "解压路径")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_up_down", x => x.Id);
                },
                comment: "上传下载实体")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cmd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(4)", nullable: false, comment: "主键")
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(40)", nullable: true, comment: "指令名称"),
                    key_value = table.Column<string>(type: "varchar(30)", nullable: true, comment: "启动指令"),
                    TypeId = table.Column<int>(type: "int(3)", nullable: false, defaultValue: 1, comment: "分类id"),
                    CreatedTime = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP()"),
                    UpdatedTime = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cmd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cmd_cmd_type_TypeId",
                        column: x => x.TypeId,
                        principalTable: "cmd_type",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "窗口指令实体")
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "cmd_type",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "描述", "常用" },
                    { 2, "描述", "电脑" },
                    { 3, "描述", "资源" }
                });

            migrationBuilder.InsertData(
                table: "cmd",
                columns: new[] { "Id", "key_value", "Name", "TypeId" },
                values: new object[,]
                {
                    { 1, "calc", "计算机", 1 },
                    { 2, "notepad", "记事本", 1 },
                    { 3, "taskmgr", "任务器", 1 },
                    { 4, "shutdown -s -t 0", "关机", 2 },
                    { 5, "shutdown -r -t 0", "重启", 2 },
                    { 6, "shutdown -l -t 0", "注销", 2 },
                    { 7, "shutdown -a", "取消", 2 },
                    { 8, "explorer", "资源管理", 3 },
                    { 9, "explorer C:\\\\", "C盘", 3 },
                    { 10, "explorer D:\\\\", "D盘", 3 },
                    { 11, "explorer shell:desktop", "桌面", 3 },
                    { 12, "explorer shell:mydocuments", "我的文档", 3 },
                    { 13, "explorer shell:downloads", "下载", 3 },
                    { 14, "mstsc", "远程桌面", 1 },
                    { 15, "regedit", "注册表", 1 },
                    { 16, "control", "控制面板", 1 },
                    { 17, "ncpa.cpl", "网络", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "cmd_id",
                table: "cmd",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_cmd_TypeId",
                table: "cmd",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cmd");

            migrationBuilder.DropTable(
                name: "up_down");

            migrationBuilder.DropTable(
                name: "cmd_type");
        }
    }
}
