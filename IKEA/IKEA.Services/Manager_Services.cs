using IKEA.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

                
                string sql = string.Format("select * from TManage where Id=@Id");
                var i = conn.Query<TManage>(sql, new { Id= id }).SingleOrDefault();

                return i;
            }
        }
     
        /// <summary>
        /// 根据角色获取 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TManage> GetManages( )
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TManage ");
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
