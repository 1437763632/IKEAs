using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 管理员角色服务接口
    /// </summary>
    public  interface IManage_Role_Services
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        int Add(TManage_Role manage_Role);
        /// <summary>
        /// 获取单个用户角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TManage_Role GetManage(int id);
        /// <summary>
        /// 获取所有管理员角色关系表
        /// </summary>
        /// <returns></returns>
        IEnumerable<TManage_Role> GetManages(int ManageID);
        /// <summary>
        /// 修改管理员角色信息表
        /// </summary>
        /// <param name="manage_Role"></param>
        /// <returns></returns>
        int Update(TManage_Role manage_Role);
    }
}
