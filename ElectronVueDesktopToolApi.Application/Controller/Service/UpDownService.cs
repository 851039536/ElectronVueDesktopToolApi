using ElectronVueDesktopToolApi.Core.entity;

namespace ElectronVueDesktopToolApi.Application.Controller.Service
{
    /// <summary>
    /// 文档路由
    /// </summary>
    public class UpDownService
    {
        private readonly IRepository<UpDown> _repository;

        /// <summary>
        /// SoftwareService
        /// </summary>
        /// <param name="repository"></param>
        public UpDownService(IRepository<UpDown> repository)
        {
            this._repository = repository;
        }
        /// <summary>
        /// 主键查询
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<UpDown> GetByIdAsync(int id)
        {
            return await _repository.Where(w => w.Id == id)
                      .AsNoTracking()
                      .FirstOrDefaultAsync();
        }
        public async Task<int> GetSum()
        {
            return await _repository.CountAsync();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<UpDown> Insert(UpDown entity)
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
        public async Task<UpDown> Delete(int id)
        {
            var entity = await _repository.FindOrDefaultAsync(id);
            var result = await _repository.DeleteNowAsync(entity);
            return result.Entity;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页记录条数</param>
        public async Task<PagedList<UpDown>> GetPagingAsync(int pageIndex,int pageSize)
        {
            PagedList<UpDown> entityList = default;

                entityList = await _repository.Entities.OrderByDescending(e => e.Id)
                  .Select(e => new UpDown() {
                      Id = e.Id,
                      ZipName = e.ZipName,
                      UpZipPath = e.UpZipPath,
                      DownZipPath = e.DownZipPath,
                      UnZipPath = e.UnZipPath,
                  }).ToPagedListAsync(pageIndex,pageSize);

            return entityList;
        }

    }
}