using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronVueDesktopToolApi.EntityFramework.Core.entity
{
    /// <summary>
    /// 标签
    /// </summary>
    [Table("snippet_tag")]
    public class SnippetTag : IEntity, IEntityTypeBuilder<SnippetTag>
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 此分类拥有的文档
        /// </summary>
        public IEnumerable<Snippet> Snippets { get; set; }


        /// <summary>
        /// Configure
        /// </summary>
        /// <param name="entityBuilder"></param>
        /// <param name="dbContext"></param>
        /// <param name="dbContextLocator"></param>
        public void Configure(EntityTypeBuilder<SnippetTag> entityBuilder,DbContext dbContext,Type dbContextLocator)
        {
            entityBuilder.HasKey(e => e.Id);
        }
    }
}