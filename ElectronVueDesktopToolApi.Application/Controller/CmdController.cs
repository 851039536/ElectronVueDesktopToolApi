namespace ElectronVueDesktopToolApi.Application.Controller
{

    public class CmdController : IDynamicApiController
    {
        private readonly IRepository<Cmd> repository;
        private readonly CmdService service;

        public CmdController(IRepository<Cmd> repository)
        {
            this.repository = repository;
            service = new CmdService(this.repository);
        }

        #region 分页查询GetFyAsync
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="identity">所有:0 || 分类:1 || 用户:2 || 标签:3 || 用户-分类:4</param>
        /// <param name="type">查询参数</param>
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页记录条数</param>
        /// <param name="isDesc">是否倒序[true/false]</param>

        public async Task<PagedList<Cmd>> GetFyAsync(int identity = 0,string type = "null",int pageIndex = 1,int pageSize = 10,bool isDesc = true)
        {

            // 生成 token
            //var accessToken = JWTEncryption.Encrypt(new Dictionary<string, object>()
            //{
            //    { "UserId", user.Id },  // 存储Id
            //    { "Account",user.Account }, // 存储用户名
            //});
            return await service.GetFyAsync(identity,type,pageIndex,pageSize,isDesc);
        }

        #endregion

        #region 主键查询 GetById
        /// <summary>
        /// 主键查询
        /// </summary>
        /// <param name="id">文章id</param>
        /// <returns></returns>
        public async Task<Cmd> GetById2(int id)
        {
            return await service.GetByIdAsync(id);
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
        [Authorize]
        public async Task<Cmd> Insert(Cmd entity)
        {
            return await service.Insert(entity);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>

        public async Task<Cmd> Update(Cmd entity)
        {
            var result = await entity.UpdateNowAsync();
            return result.Entity;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">文档Id</param>
        /// <returns></returns>
        public async Task<Cmd> Delete(int id)
        {
            return await service.Delete(id);
        }

    }
}