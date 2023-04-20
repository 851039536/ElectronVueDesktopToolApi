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
                new Cmd { Id =1, Name = "计算机", KeyValue="calc",TypeId =1 },
                new Cmd { Id =2, Name = "记事本", KeyValue="notepad",TypeId =1 },
                new Cmd { Id =3, Name = "任务器", KeyValue="taskmgr",TypeId =1 },
                new Cmd { Id =14, Name = "远程桌面", KeyValue="mstsc",TypeId =1 },
                new Cmd { Id =15, Name = "注册表", KeyValue="regedit",TypeId =1 },
                new Cmd { Id =16, Name = "控制面板", KeyValue="control",TypeId =1 },
                new Cmd { Id =17, Name = "网络", KeyValue="ncpa.cpl",TypeId =1 },

                new Cmd { Id =4, Name = "关机", KeyValue="shutdown -s -t 0",TypeId =2 },
                new Cmd { Id =5, Name = "重启", KeyValue="shutdown -r -t 0",TypeId =2 },
                new Cmd { Id =6, Name = "注销", KeyValue="shutdown -l -t 0",TypeId =2 },
                new Cmd { Id =7, Name = "取消", KeyValue="shutdown -a",TypeId =2 },

                new Cmd { Id =8, Name = "资源管理", KeyValue="explorer",TypeId =3 },
                new Cmd { Id =9, Name = "C盘", KeyValue=@"explorer C:\\",TypeId =3 },
                new Cmd { Id =10, Name = "D盘", KeyValue=@"explorer D:\\",TypeId =3 },
                new Cmd { Id =11, Name = "桌面", KeyValue="explorer shell:desktop",TypeId =3 },
                new Cmd { Id =12, Name = "我的文档", KeyValue="explorer shell:mydocuments",TypeId =3 },
                new Cmd { Id =13, Name = "下载", KeyValue="explorer shell:downloads",TypeId =3 },

            };
        }
    }
}
