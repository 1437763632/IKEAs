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
    public class Trolley_Services : ITrolley_Services
    {
        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        public int Add(TTrolley trolley)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TTrolley(UserID,SumNumber,p_Sum) value(@UserID,@SumNumber,@p_Sum)");
                int i = conn.Execute(sql, trolley);
                return i;
            }
        }

        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from TTrolley where Id=@id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个购物车信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TTrolley GetTrolley(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select * from TTrolley where Id=@Id");
                var i = conn.Query<TTrolley>(sql, new { Id = id }).FirstOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 获取购物车信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TTrolley> GetTrolleys()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                //MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TTrolley ");
                var i = conn.Query<TTrolley>(sql, null).ToList();
                return i;
            }
        }

        /// <summary>
        /// 修改购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        public int Update(TTrolley trolley)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TTrolley set UserID=@UserID,SumNumber=@SumNumber,p_Sum=@p_Sum where Id=@Id");
                var i = conn.Execute(sql, trolley);
                return i;
            }
        }
    }
}
