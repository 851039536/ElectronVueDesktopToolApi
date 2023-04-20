using ElectronVueDesktopToolApi.EntityFramework.Core.entity;
using System.Collections.Generic;

namespace ElectronVueDesktopToolApi.Core.SeedData
{
    public class CmdTypeSeed : IEntitySeedData<CmdType>
    {
        // 配置种子数据
        public IEnumerable<CmdType> HasData(DbContext dbContext,Type dbContextLocator)
        {
            return new List<CmdType>
            {
                new CmdType { Id = 1, Name = "百小僧", Description="test",CmdId =1 },
            };
        }
    }
}
