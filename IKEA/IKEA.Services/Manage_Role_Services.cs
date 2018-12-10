using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using Dapper;
    using IKEA.Common;
    using IKEA.IServices;
    using IKEA.Model;
    using MySql.Data.MySqlClient;
    public class Manage_Role_Services : IManage_Role_Services
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int Add(TManage_Role manage_Role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert into tmanage_role (ManageID,RoleID) values(@ManageID,@RoleID)");
                int i = conn.Execute(sql, manage_Role);
                return i;
            }
        }

        /// <summary>
        /// 获取单个用户角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TManage_Role GetManage(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select * from TManage_Role where Id=@Id");
                var i = conn.Query<TManage_Role>(sql, new { Id=id}).SingleOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 根据管理员id获取所有角色
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TManage_Role> GetManages( int ManageID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("select * from TManage_Role where ManageID=@ManageID");
                var i = conn.Query<TManage_Role>(sql,new { ManageID = ManageID });
                return i.ToList<TManage_Role>();
            }
        }

        /// <summary>
        /// 修改管理员角色信息表
        /// </summary>
        /// <param name="manage_Role"></param>
        /// <returns></returns>
        public int Update(TManage_Role manage_Role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TManage_Role set ManageID=@ManageID,RoleID=@RoleID where Id=@Id");
                var i = conn.Execute(sql, manage_Role);
                return i;
            }
        }
    }
}
