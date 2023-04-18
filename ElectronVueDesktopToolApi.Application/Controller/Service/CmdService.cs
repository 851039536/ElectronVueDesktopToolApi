namespace ElectronVueDesktopToolApi.Application.Controller.Service
{
    /// <summary>
    /// 文档路由
    /// </summary>
    public class CmdService
    {
        private readonly IRepository<Cmd> repository;

        /// <summary>
        /// SoftwareService
        /// </summary>
        /// <param name="repository"></param>
        public CmdService(IRepository<Cmd> repository)
        {
            this.repository = repository;
        }
        /// <summary>
        /// 主键查询
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<Cmd> GetByIdAsync(int id)
        {
            return await repository.Where(w => w.Id == id)
                      .AsNoTracking()
                      .FirstOrDefaultAsync();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<Cmd> Insert(Cmd entity)
        {
            var result = await entity.InsertNowAsync();
            entity = await GetByIdAsync(result.Entity.Id);
            return entity;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<Cmd> Delete(int id)
        {
            var entity = await repository.FindOrDefaultAsync(id);
            var result = await repository.DeleteNowAsync(entity);
            return result.Entity;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="identity">所有:0 || 分类:1 || 用户:2 || 标签:3 || 用户-分类:4</param>
        /// <param name="type">查询参数</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页记录条数</param>
        /// <param name="isDesc">是否倒序[true/false]</param>
        public async Task<PagedList<Cmd>> GetFyAsync(int identity,string type,int pageIndex,int pageSize,bool isDesc)
        {
            PagedList<Cmd> entityList = default;
            switch (identity) {
                case 0:
                entityList = await GetFyAll(pageIndex,pageSize,isDesc);
                break;
            }
            return entityList;
        }

        private async Task<PagedList<Cmd>> GetFyAll(int pageIndex,int pageSize,bool isDesc)
        {
            PagedList<Cmd> entityList = default;
            if (isDesc)//降序
            {
                entityList = await repository.Entities.OrderByDescending(e => e.Id)
                .Select(e => new Cmd() {
                    Id = e.Id,
                    Name = e.Name,
                    KeyValue = e.KeyValue,

                }).ToPagedListAsync(pageIndex,pageSize);

            } else //升序
              {
                entityList = await repository.Entities.OrderBy(e => e.Id)
           .Select(e => new Cmd() {
               Id = e.Id,
               Name = e.Name,
               KeyValue = e.KeyValue,
           }).ToPagedListAsync(pageIndex,pageSize);
            }
            return entityList;
        }

    }
}