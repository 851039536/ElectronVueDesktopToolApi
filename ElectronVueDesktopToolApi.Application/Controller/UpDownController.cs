using ElectronVueDesktopToolApi.Core.entity;

namespace ElectronVueDesktopToolApi.Application.Controller
{

    public class UpDownController : IDynamicApiController
    {
        private readonly IRepository<UpDown> _repository;
        private readonly UpDownService _service;

        public UpDownController(IRepository<UpDown> repository)
        {
            this._repository = repository;
            _service = new UpDownService(this._repository);
        }

        #region 分页查询
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页记录条数</param>

        public async Task<PagedList<UpDown>> GetPaging(int pageIndex = 1,int pageSize = 10)
        {
            return await _service.GetPagingAsync(pageIndex,pageSize);
        }

        #endregion

        #region 主键查询 
        /// <summary>
        /// 主键查询
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<UpDown> GetById(int id)
        {
            return await _service.GetByIdAsync(id);
        }
        #endregion

        #region 查询总数 
        /// <summary>
        /// 总条数
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetSum()
        {
            return await _service.GetSum();
        }
        #endregion
  

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        //[Authorize]
        public async Task<UpDown> Insert(UpDown entity)
        {
            return await _service.Insert(entity);
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<UpDown> Delete(int id)
        {
            return await _service.Delete(id);
        }

    }
}