﻿// <auto-generated />
using System;
using ElectronVueDesktopToolApi.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronVueDesktopToolApi.Database.Migrations.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            KeyValue = "test",
                            Name = "百小僧",
                            TypeId = 1,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "test",
                            Name = "百小僧",
                            TypeId = 1,
                            UpdatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KeyValue = "test",
                            Name = "百小僧",
                            TypeId = 1,
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

                    b.Property<int>("CmdId")
                        .HasColumnType("int(3)")
                        .HasColumnName("cmd_id")
                        .HasComment("cmd_id");

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
                            CmdId = 1,
                            Description = "test",
                            Name = "百小僧"
                        });
                });

            modelBuilder.Entity("ElectronVueDesktopToolApi.EntityFramework.Core.entity.Cmd", b =>
                {
                    b.HasOne("ElectronVueDesktopToolApi.EntityFramework.Core.entity.CmdType", "cmdType")
                        .WithMany("Cmds")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cmdType");
                });

            modelBuilder.Entity("ElectronVueDesktopToolApi.EntityFramework.Core.entity.CmdType", b =>
                {
                    b.Navigation("Cmds");
                });
#pragma warning restore 612, 618
        }
    }
}
