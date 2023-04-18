using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using Furion.DatabaseAccessor;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronVueDesktopToolApi.EntityFramework.Core.entity;

/// <summary>
/// 文档
/// </summary>
[Table("cmd")]
public class Cmd : IEntity, IEntityTypeBuilder<Cmd>
{
    public int Id { get; set; }

    public string Name { get; set; }

    [Column("key_value")]
    public string KeyValue { get; set; }

    public string Type { get; set; }

    public void Configure(EntityTypeBuilder<Cmd> entityBuilder,DbContext dbContext,Type dbContextLocator)
    {
        entityBuilder.HasKey(c => c.Id);
    }
}
