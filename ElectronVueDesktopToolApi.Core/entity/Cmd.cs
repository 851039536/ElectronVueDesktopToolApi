namespace ElectronVueDesktopToolApi.EntityFramework.Core.entity;

/// <summary>
/// 文档 
/// IEntity：实体基接口，是所有实体的基接口
/// 框架中有约定，实体统一定义在 Furion.Core 层。
/// </summary>
[Table("cmd")]
[Comment("窗口指令实体")]
public class Cmd : IEntity, IEntityTypeBuilder<Cmd>
{
    // IEntityTypeBuilder<TEntity> 接口，我们无需在 DbContext 的 OnModelCreating 中配置，可在任意地方配置。

    [Comment("主键")]
    [Column(Order = 0,TypeName ="int(4)")]
    [Key]
    [Range(1,9000,ErrorMessage = "Id 区间取值")]
    public int Id { get; set; }

    [Column(TypeName = "varchar(40)",Order =1)]
    [Comment("指令名称")]
    public string Name { get; set; }

    [Column("key_value",TypeName = "varchar(30)",Order = 2)]
    [Comment("启动指令")]
    public string KeyValue { get; set; }

    [Column(TypeName = "int(3)",Order = 3)]
    [Comment("分类id")]
    public int TypeId { get; set; }

    /// <summary>
    /// 创建时间  表示这个属性的值将由数据库在插入时自动生成。
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(Order = 4)]
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 添加时间  指定了UpdatedTime字段为计算列，也就是根据其他列的值自动计算。(更新myql出错)
    /// </summary>
    //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] 
    [Column(Order = 5)]
    public DateTime UpdatedTime { get; set; }

    public CmdType CmdType { get; set; } = null!;



    public void Configure(EntityTypeBuilder<Cmd> entityBuilder,DbContext dbContext,Type dbContextLocator)
    {
        entityBuilder.HasKey(c => c.Id);
        entityBuilder.HasIndex(c => c.Id).HasDatabaseName("cmd_id"); ;  //创建索引
        entityBuilder.Property(c => c.TypeId).HasDefaultValue(1);
        // 配置CreatedTime字段
        entityBuilder.Property(t => t.CreatedTime)
         // 设置列的类型是DATETIME
         .HasColumnType("DATETIME")
         // 设置列的默认值
         .HasDefaultValueSql("CURRENT_TIMESTAMP()");

        // 配置UpdatedTime字段
        entityBuilder.Property(t => t.UpdatedTime)
        // 设置列的类型是DATETIME
        .HasColumnType("DATETIME")
        // 设置列的默认值.
        .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP");

        //配置一对多关系(多)
        entityBuilder.HasOne(d => d.CmdType)
             .WithMany(p => p.Cmds)
             .HasForeignKey(d => d.TypeId) //设置外键
             .IsRequired(); //外键不可为空
    }

}
