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
    public class Manager_Services : IManager_Services
    {
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int Add(TManage manage)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert into TManage (ManageName,ManagePass,CreateTime,LoginTime,LastLoginTime,Count) values(@ManageName,@ManagePass,@CreateTime,@LoginTime,@LastLoginTime,@Count)");
                int i = conn.Execute(sql, manage);
                return i;
            }
        }
        /// <summary>
        /// 获取单个管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TManage GetManage(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TManage where Id=@Id");
                var i = conn.Query<TManage>(sql, mySqlParameters).SingleOrDefault();
                return i;
            }
        }
     
        /// <summary>
        /// 根据角色获取
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TManage> GetManages(int RoleID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TManage where RoleID=@RoleID");
                var i = conn.Query<TManage>(sql, null).ToList();
                return i;
            }
        }

        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int Update(TManage manage)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TManage set ManageName=@ManageName,ManagePass=@ManagePass,CreateTime=@CreateTime,LoginTime=@LoginTime,LastLoginTime=@LastLoginTime,Count=@Count where Id=@Id");
                var i = conn.Execute(sql, manage);
                return i;
            }
        }
    }
}
