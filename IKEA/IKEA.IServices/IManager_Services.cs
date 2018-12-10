using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 管理员服务接口
    /// </summary>
    public interface IManager_Services
    {
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        int Add(TManage manage);
        /// <summary>
        /// 获取单个管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TManage GetManage(int id);
        /// <summary>
        /// 根据角色获取
        /// </summary>
        /// <returns></returns>
        IEnumerable<TManage> GetManages();
        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        int Update(TManage manage);
    }
}
