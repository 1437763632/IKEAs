using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    public interface IRole_Services
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int Add(TRole role);
        /// <summary>
        /// 修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int Update(TRole role);
        /// <summary>
        /// 获取单个角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       IEnumerable<ShowRole> GetRole(int id);
        /// <summary>
        /// 删除角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 获取全部角色信息
        /// </summary>
        IEnumerable<ShowRole> GetRoles();
        /// <summary>
        /// 多表修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <param name="roleid"></param>
        /// <returns></returns>
        int RoleUpdate(TRole role);
    }
}
