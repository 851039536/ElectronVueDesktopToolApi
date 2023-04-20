using ElectronVueDesktopToolApi.EntityFramework.Core.entity;
using System.Collections.Generic;

namespace ElectronVueDesktopToolApi.Core.SeedData
{
    public class CmdSeed : IEntitySeedData<Cmd>
    {
        // 配置种子数据
        public IEnumerable<Cmd> HasData(DbContext dbContext,Type dbContextLocator)
        {
            return new List<Cmd>
            {
                new Cmd { Id = 1, Name = "百小僧", KeyValue="test",TypeId =1 },
                 new Cmd { Id =2, Name = "百小僧", KeyValue="test",TypeId =1 },
                  new Cmd { Id =3, Name = "百小僧", KeyValue="test",TypeId =1 },
            };
        }
    }
}
