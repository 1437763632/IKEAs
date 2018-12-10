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
    public class TrolleyDetail_Services : ITrolleyDetail_Services
    {
        /// <summary>
        /// 添加购物车详情
        /// </summary>
        /// <param name="trolleyDetail"></param>
        /// <returns></returns>
        public int Add(TTrolleyDetail trolleyDetail)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert into TTrolleyDetail(TrolleyID,ProductID,ProductDetailID,BuyNumber,Price,RealPrice,Consume) value(@TrolleyID,@ProductID,@ProductDetailID,@BuyNumber,@Price,@RealPrice,@Consume)");
                int i = conn.Execute(sql, trolleyDetail);
                return i;
            }
        }

        /// <summary>
        /// 删除购物车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from TTrolleyDetail where Id=@id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个购物车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TTrolleyDetail GetTTrolleyDetail(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TTrolleyDetail where Id=@Id");
                var i = conn.Query<TTrolleyDetail>(sql, mySqlParameters).FirstOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 获取所有购物车详情信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TTrolleyDetail> GetTrolleyDetails()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select * from TTrolleyDetail ");
                var  result = conn.Query<TTrolleyDetail>(sql, null);
                return result.ToList<TTrolleyDetail>();
            }
        }

        /// <summary>
        /// 修改购物车详情
        /// </summary>
        /// <param name="trolleyDetail"></param>
        /// <returns></returns>
        public int Update(TTrolleyDetail trolleyDetail)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TTrolleyDetail set TrolleyID=@TrolleyID,ProductID=@ProductID,ProductDetailID=@ProductDetailID,BuyNumber=@BuyNumber,Price@Price,RealPrice=@RealPrice,Consume=@Consume where Id=@Id");
                var i = conn.Execute(sql, trolleyDetail);
                return i;
            }
        }
    }
}
