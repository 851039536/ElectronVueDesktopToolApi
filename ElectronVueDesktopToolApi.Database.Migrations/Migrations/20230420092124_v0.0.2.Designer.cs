﻿// <auto-generated />
using System;
using ElectronVueDesktopToolApi.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronVueDesktopToolApi.Database.Migrations.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20230420092124_v0.0.2")]
    partial class v002
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ElectronVueDesktopToolApi.EntityFramework.Core.entity.Cmd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(4)")
                        .HasColumnOrder(0)
                        .HasComment("主键");

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(4)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP()");

                    b.Property<string>("KeyValue")
                        .HasColumnType("varchar(30)")
                        .HasColumnName("key_value")
                        .HasColumnOrder(2)
                        .HasComment("启动指令");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(40)")
                        .HasColumnOrder(1)
                        .HasComment("指令名称");

                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(3)")
                        .HasDefaultValue(1)
                        .HasColumnOrder(3)
                        .HasComment("分类id");

                    b.Property<DateTime>("UpdatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasColumnOrder(5)
                        .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasDatabaseName("cmd_id");

                    b.HasIndex("TypeId");

                    b.ToTable("cmd", t =>
                        {
                            t.HasComment("窗口指令实体");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "calc",
                            Name = "计算机",
                            TypeId = 1,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "notepad",
                            Name = "记事本",
                            TypeId = 1,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "taskmgr",
                            Name = "任务器",
                            TypeId = 1,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "shutdown -s -t 0",
                            Name = "关机",
                            TypeId = 2,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "shutdown -r -t 0",
                            Name = "重启",
                            TypeId = 2,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "shutdown -l -t 0",
                            Name = "注销",
                            TypeId = 2,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "shutdown -a",
                            Name = "取消",
                            TypeId = 2,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "explorer",
                            Name = "资源管理",
                            TypeId = 3,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "explorer C:\\\\",
                            Name = "C盘",
                            TypeId = 3,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "explorer D:\\\\",
                            Name = "D盘",
                            TypeId = 3,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "explorer shell:desktop",
                            Name = "桌面",
                            TypeId = 3,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "explorer shell:mydocuments",
                            Name = "我的文档",
                            TypeId = 3,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "explorer shell:downloads",
                            Name = "下载",
                            TypeId = 3,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ElectronVueDesktopToolApi.EntityFramework.Core.entity.CmdType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(3)")
                        .HasColumnOrder(0)
                        .HasComment("主键");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasComment("描述");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(40)")
                        .HasComment("分类名称");

                    b.HasKey("Id");

                    b.ToTable("cmd_type", t =>
                        {
                            t.HasComment("窗口指令实体");
                        });

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "描述",
                            Name = "常用"
                        },
                        new
                        {
                            Id = 2,
                            Description = "描述",
                            Name = "电脑"
                        },
                        new
                        {
                            Id = 3,
                            Description = "描述",
                            Name = "资源"
                        });
                });

            modelBuilder.Entity("ElectronVueDesktopToolApi.EntityFramework.Core.entity.Cmd", b =>
                {
                    b.HasOne("ElectronVueDesktopToolApi.EntityFramework.Core.entity.CmdType", "CmdType")
                        .WithMany("Cmds")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CmdType");
                });

            modelBuilder.Entity("ElectronVueDesktopToolApi.EntityFramework.Core.entity.CmdType", b =>
                {
                    b.Navigation("Cmds");
                });
#pragma warning restore 612, 618
        }
    }
}