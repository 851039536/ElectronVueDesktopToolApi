using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronVueDesktopToolApi.EntityFramework.Core.entity
{
    /// <summary>
    /// 分类
    /// </summary>
    [Table("snippet_type")]
    public class SnippetType : IEntity, IEntityTypeBuilder<SnippetType>
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
        public void Configure(EntityTypeBuilder<SnippetType> entityBuilder,DbContext dbContext,Type dbContextLocator)
        {
            entityBuilder.HasKey(e => e.Id);
        }
    }
}