using ElectronVueDesktopToolApi.EntityFramework.Core.entity;
using System.Collections.Generic;
using ElectronVueDesktopToolApi.Core.entity;

namespace ElectronVueDesktopToolApi.Core.SeedData
{
    public class UpDownSeed : IEntitySeedData<UpDown>
    {
        // 配置种子数据
        public IEnumerable<UpDown> HasData(DbContext dbContext,Type dbContextLocator)
        {
            return new List<UpDown>
            {
                new UpDown { Id = 1, ZipName = "文件下载测试", UpZipPath= @"C:\\Users\\ch190006\\Desktop\\Test\\test1\\test2.zip",
                    DownZipPath = @"C:\\Users\\ch190006\\Desktop\\Test",UnZipPath = @"C:\\Users\\ch190006\\Desktop\\Test"},
            };
        }
    }
}
