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

    public class DisCount_Services : IDisCount_Services
    {
        /// <summary>
        /// 添加优惠券
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Add(TDisCount disCount)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert INTO tdiscount(Price,Image) VALUES(Price,Image)");
                int i = conn.Execute(sql, disCount);
                return i;
            }
        }
        /// <summary>
        /// 删除优惠券
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("DELETE FROM tdiscount WHERE Id=@Id");
                int i = conn.Execute(sql, new { Id = id });
                return i;
            }
        }
        /// <summary>
        /// 根据ID优惠券
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TDisCount GetDisCount(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM tdiscount WHERE Id=@Id");
                var result = conn.Query<TDisCount>(sql, new { Id = id }).FirstOrDefault();
                return result;
            }
        }
        /// <summary>
        /// 查询优惠券
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TDisCount> GetDisCounts()
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM tdiscount");
                var result = conn.Query<TDisCount>(sql,null);
                return result;
            }
        }

        public IEnumerable<TDisCount> GetDisCounts(int UserID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改优惠券
        /// </summary>
        /// <param name="disCount"></param>
        /// <returns></returns>
        public int Update(TDisCount disCount)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("UPDATE tdiscount SET Price=@Price,Image=@Image where Id =@Id");
                int i = conn.Execute(sql, disCount);
                return i;
            }
        }
    }
}
