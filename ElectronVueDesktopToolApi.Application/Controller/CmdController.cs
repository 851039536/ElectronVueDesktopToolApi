namespace ElectronVueDesktopToolApi.Application.Controller
{

    public class CmdController : IDynamicApiController
    {
        private readonly IRepository<Cmd> _repository;
        private readonly CmdService _service;

        public CmdController(IRepository<Cmd> repository)
        {
            this._repository = repository;
            _service = new CmdService(this._repository);
        }

        #region 分页查询
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="identity">所有:0 </param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页记录条数</param>

        public async Task<PagedList<Cmd>> GetPaging(int identity = 0,int pageIndex = 1,int pageSize = 10)
        {
            return await _service.GetPagingAsync(identity,pageIndex,pageSize);
        }

        #endregion

        #region 主键查询 
        /// <summary>
        /// 主键查询
        /// </summary>
        /// <param name="id">文章id</param>
        /// <returns></returns>
        public async Task<Cmd> GetById(int id)
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
        public string GetToken(int id,string account)
        {
            // 生成 token
            var accessToken = JWTEncryption.Encrypt(new Dictionary<string,object>()
                        {
                { "UserId", id},  // 存储Id
                { "Account",account }, // 存储用户名
            });
            // 获取刷新 token
            var refreshToken = JWTEncryption.GenerateRefreshToken(accessToken,43200); // 第二个参数是刷新 token 的有效期（分钟），默认三十天
            return refreshToken;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        //[Authorize]
        public async Task<Cmd> Insert(Cmd entity)
        {
            return await _service.Insert(entity);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>

        public async Task<Cmd> Update(Cmd entity)
        {
            //创建时间函数
            entity.UpdatedTime = DateTime.Now;
            //排除时间字段进行更新操作
            var result = await entity.UpdateExcludeNowAsync(new[] { nameof(entity.CreatedTime) });
            return result.Entity;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">文档Id</param>
        /// <returns></returns>
        public async Task<Cmd> Delete(int id)
        {
            return await _service.Delete(id);
        }

    }
}