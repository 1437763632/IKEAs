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
        IEnumerable<ShowManage> GetManage(int id);
        /// <summary>
        /// 获取管理员信息
        /// </summary>
        /// <returns></returns>

        IEnumerable<ShowManage> GetManages( );

        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        int Update(TManage manage);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="ManageNumber"></param>
        /// <param name="ManagePass"></param>
        /// <returns></returns>
        TManage Login(string ManageNumber, string ManagePass);
        /// <summary>
        /// 获得角色Id查询权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<TRight> Getrights(int id);
    }
}
