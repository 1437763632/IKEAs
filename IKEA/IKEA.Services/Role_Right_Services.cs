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
    public class Role_Right_Services : IRole_Right_Services
    {
        /// <summary>
        /// 添加关联表
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Add(TRole_Right role_Right)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TRole_Right(RoleID,RightID ) value(@RoleID,@RightID)");
                int i = conn.Execute(sql, role_Right);
                return i;
            }
        }

        /// <summary>
        /// 删除关联信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from TRole_Right where Id=@id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个关联信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TRole_Right GetTRole_Right(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TRole_Right where id=@Id");
                var i = conn.Query<TRole_Right>(sql, mySqlParameters).FirstOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 修改关联信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Update(TRole_Right role_Right)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TRole_Right set RoleID=@RoleID,RightID=@RightID where Id=@Id");
                var i = conn.Execute(sql, role_Right);
                return i;
            }
        }
    }
}
