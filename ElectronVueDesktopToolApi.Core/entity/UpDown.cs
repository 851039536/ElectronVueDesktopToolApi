namespace ElectronVueDesktopToolApi.Core.entity;

/// <summary>
/// 文档 
/// IEntity：实体基接口，是所有实体的基接口
/// </summary>
[Table("up_down")]
[Comment("上传下载实体")]
public class UpDown : IEntity, IEntityTypeBuilder<UpDown>
{
    // IEntityTypeBuilder<TEntity> 接口，我们无需在 DbContext 的 OnModelCreating 中配置，可在任意地方配置。

    [Comment("主键")]
    [Column(Order = 0, TypeName = "int(4)")]
    [Key]
    [Range(1, 9000, ErrorMessage = "Id 区间取值")]
    public int Id { get; set; }

    [Column(TypeName = "varchar(40)", Order = 1)]
    [Comment("zip名称")]
    public string ZipName { get; set; }

    [Column("up_zip_path", TypeName = "varchar(200)", Order = 2)]
    [Comment("上传路径")]
    public string UpZipPath { get; set; }

    [Column("down_zip_path", TypeName = "varchar(200)", Order = 3)]
    [Comment("下载到本地路径")]
    public string DownZipPath { get; set; }

    [Column("un_zip_path", TypeName = "varchar(200)", Order = 4)]
    [Comment("解压路径")]
    public string UnZipPath { get; set; }


    public void Configure(EntityTypeBuilder<UpDown> entityBuilder, DbContext dbContext, Type dbContextLocator)
    {
        entityBuilder.HasKey(c => c.Id);
    }
}