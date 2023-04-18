using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronVueDesktopToolApi.EntityFramework.Core.entity
{
    /// <summary>
    /// 文档
    /// </summary>
    [Table("snippet")]
    public class Snippet : IEntity, IEntityTypeBuilder<Snippet>
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 分类Id
        /// </summary>
        [Column("typeid")]
        public int? typeId { get; set; }

        /// <summary>
        /// 标签id
        /// </summary>
        [Column("tagid")]
        public int? tagId { get; set; }
        /// <summary>
        /// 创建者Id
        /// </summary>
        [Column("userid")]
        public int? userId { get; set; }

        /// <summary>
        /// 所属用户（主表）
        /// </summary>
        //public User Users { get; set; }

        /// <summary>
        /// 所属分类
        /// </summary>
        public SnippetType Types { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public SnippetTag Tags { get; set; }

        /// <summary>
        /// Configure
        /// </summary>
        /// <param name="entityBuilder"></param>
        /// <param name="dbContext"></param>
        /// <param name="dbContextLocator"></param>
        public void Configure(EntityTypeBuilder<Snippet> entityBuilder,DbContext dbContext,Type dbContextLocator)
        {
            entityBuilder.HasKey(e => e.Id);
            //entityBuilder
            //    .HasOne(e => e.Users)
            //    .WithMany(u => u.Snippets)
            //    .HasForeignKey(e => e.userId);
            entityBuilder
                .HasOne(e => e.Types)
                .WithMany(c => c.Snippets)
                .HasForeignKey(e => e.typeId);
            entityBuilder
                .HasOne(e => e.Tags)
                .WithMany(c => c.Snippets)
                .HasForeignKey(e => e.tagId);
        }
    }
}