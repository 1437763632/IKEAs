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
    public class Right_Services : IRight_Services
    {
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public int Add(TRight right)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TRight(RightName,URL,IsUser) value(@RightName,@URL,@IsUser)");
                int i = conn.Execute(sql, right);
                return i;
            }
        }

        /// <summary>
        /// 根据ID获取权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TRight GetRight(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select * from TRight where id=@Id");
                var i = conn.Query<TRight>(sql, new { Id=id}).FirstOrDefault();
                return i;
            }
        }
        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TRight> GetRights()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("select * from TRight");
                var i = conn.Query<TRight>(sql, null).ToList();
                return i;
            }
        }

        /// <summary>
        /// 修改权限信息
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        public int Update(TRight right)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TRight set RightName=@RightName,URL=@URL,IsUser=@IsUser where Id=@Id");
                var i = conn.Execute(sql, right);
                return i;
            }
        }
    }
}
