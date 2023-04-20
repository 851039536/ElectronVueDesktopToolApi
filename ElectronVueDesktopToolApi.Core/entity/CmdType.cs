using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace ElectronVueDesktopToolApi.EntityFramework.Core.entity;

/// <summary>
/// 文档 
/// IEntity：实体基接口，是所有实体的基接口
/// 框架中有约定，实体统一定义在 Furion.Core 层。
/// </summary>
[Table("cmd_type")]
[Comment("窗口指令实体")]
public class CmdType : IEntity, IEntityTypeBuilder<CmdType>
{
    [Comment("主键")]
    [Column(Order = 0,TypeName ="int(3)")]
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "varchar(40)")]
    [Comment("分类名称")]
    public string Name { get; set; }

    [Column(TypeName = "text")]
    [Comment("描述")]
    public string Description { get; set; }

    [Column("cmd_id",TypeName = "int(3)")]
    [Comment("cmd_id")]


    public ICollection<Cmd> Cmds { get; } = new List<Cmd>();


    public void Configure(EntityTypeBuilder<CmdType> entityBuilder,DbContext dbContext,Type dbContextLocator)
    {
        entityBuilder.HasKey(c => c.Id);
    }
}
