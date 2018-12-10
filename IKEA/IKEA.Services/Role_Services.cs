using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using Model;
    using IServices;
    using Common;
    using Dapper;
    using MySql.Data.MySqlClient;
    public class Role_Services : IRole_Services
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Add(TRole role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TRole(RoleName) value(@RoleName)");
                int i = conn.Execute(sql, role);
                return i;
            }
        }

        /// <summary>
        /// 删除角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from TRole where Id=@id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TRole GetRole(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select * from TRole where Id=@Id");
                var i = conn.Query<TRole>(sql, new { Id = id }).FirstOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Update(TRole role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TRole set RoleName=@RoleName where Id=@Id");
                var i = conn.Execute(sql, role);
                return i;
            }
        }
    }
}
