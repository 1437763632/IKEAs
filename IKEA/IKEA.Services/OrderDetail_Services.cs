using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IKEA.Common;
using IKEA.IServices;
using IKEA.Model;
using MySql.Data.MySqlClient;

namespace IKEA.Services
{
    public class OrderDetail_Services : IOrderDetail_Services
    {
        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="id">订单详情ID</param>
        /// <returns>TOrderDetail</returns>
        public TOrderDetail GetOrderDetail(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TOrderDetail where Id=@Id");
                var i = conn.Query<TOrderDetail>(sql, mySqlParameters).SingleOrDefault();
                return i;
            }
        }
        /// <summary>
        /// 根据订单id获取所有订单详情
        /// </summary>
        /// <param name="orderID">订单id</param>
        /// <returns>IEnumerable<TOrderDetail> </returns>
        public IEnumerable<TOrderDetail> GetOrderDetails(int orderID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TOrderDetail where OrderID=@orderID");
                var i = conn.Query<TOrderDetail>(sql, orderID);
                return i;
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="orderDetail">订单详情实体</param>
        /// <returns>int</returns>
        public int Update(TOrderDetail orderDetail)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TOrderDetail set OrderID=@OrderID,ProductID=@ProductID,ProductDetailID=@ProductDetailID,BuyNumber=@BuyNumber,Price=@Price,RealPrice=@RealPrice,Consume=@Consume where Id=@Id");
                var i = conn.Execute(sql, orderDetail);
                return i;
            }
        }
    }
}
