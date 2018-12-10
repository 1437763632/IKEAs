using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using Model;
    using Common;
    using Dapper;
    using MySql.Data.MySqlClient;
    using IServices;
    public class Evaluate_Services : IEvaluate_Services
    {
        /// <summary>
        /// 添加评价表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Add(Tevaluate evaluate)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("INSERT INTO tevaluate(UserID, ShopID, Evaluate, StarLevel, UpdateTime, Isdelete) VALUES(@UserID, @ShopID, @Evaluate, @StarLevel, @UpdateTime, @Isdelete)");
                int i = conn.Execute(sql, evaluate);
                return i;
            }
        }
        /// <summary>
        /// 根据ID删除评价表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("DELETE FROM tevaluate WHERE Id = @Id");
                int i = conn.Execute(sql, new { Id = id });
                return i;
            }
        }
        /// <summary>
        /// 根据ID查询评价表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Tevaluate GetEvaluate(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM tevaluate WHERE Id = @Id");
                var result = conn.Query<Tevaluate>(sql, new { Id = id }).FirstOrDefault();
                return result;
            }
        }
        /// <summary>
        /// 根据产品ID查询评价表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Tevaluate> GetTevaluates(int ProductID)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM tevaluate where ProductID=@Id");
                var result = conn.Query<Tevaluate>(sql, new { Id = ProductID }).ToList();
                return result;
            }
        }
        /// <summary>
        /// 修改评价表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(Tevaluate evaluate)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("UPDATE tevaluate SET UserID=@UserID, ShopID=@ShopID, Evaluate=@Evaluate, StarLevel=@StarLevel, UpdateTime=@UpdateTime, Isdelete=@Isdelete WHERE Id=@Id");
                int i = conn.Execute(sql, evaluate);
                return i;
            }
        }
    }
}
