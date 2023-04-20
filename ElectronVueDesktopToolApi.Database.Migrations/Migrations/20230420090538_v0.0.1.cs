using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectronVueDesktopToolApi.Database.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class v001 : Migration
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
                    { 4, "taskmgr", "关机", 2 },
                    { 5, "taskmgr", "重启", 2 },
                    { 6, "taskmgr", "注销", 2 },
                    { 7, "taskmgr", "取消", 2 },
                    { 8, "taskmgr", "资源管理", 3 },
                    { 9, "taskmgr", "C盘", 3 },
                    { 10, "taskmgr", "D盘", 3 },
                    { 11, "taskmgr", "桌面", 3 },
                    { 12, "taskmgr", "我的文档", 3 },
                    { 13, "taskmgr", "下载", 3 }
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
                name: "cmd_type");
        }
    }
}
