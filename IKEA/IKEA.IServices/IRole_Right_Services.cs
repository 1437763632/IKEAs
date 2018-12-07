using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 角色权限关联接口
    /// </summary>
    public interface IRole_RightServices
    {
        /// <summary>
        /// 添加关联表
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int Add(TRole_Right role_Right );
        /// <summary>
        /// 修改关联信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int Update(TRole_Right role_Right );
        /// <summary>
        /// 获取单个关联信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TRole GetRole(int id);
        /// <summary>
        /// 删除关联信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
    }
}
