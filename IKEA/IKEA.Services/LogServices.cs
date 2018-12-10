using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using IKEA.Model;
    using MySql.Data.MySqlClient;
    using IServices;
    using IKEA.Common;
    using Dapper;
    public class LogServices : ILogServices
    {
        public int Add(TLog log)
        {
            ///添加日志
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("INSERT INTO tlog(Content,UserID,RoleID,UpdateTime) VALUES(@Content,@UserID,@RoleID,@UpdateTime)");
                int i = conn.Execute(sql, log);
                return i;
            }
        }
        /// <summary>
        /// 显示日志
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<TLog> GetLogs(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM tlog where Id=@Id");
                var result = conn.Query<TLog>(sql, new { Id=id}).ToList();
                return result;
            }
        }
    }
}
