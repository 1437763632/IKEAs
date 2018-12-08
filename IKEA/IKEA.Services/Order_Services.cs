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
    public class Order_Services : IOrder_Services
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="order">订单</param>
        /// <returns>int</returns>
        public int Add(TOrder order)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert into TOrder (UserID,SumNumber,SumPrice,IsOnSale,DisCountD,RealPay,AddressID,IsPayment,State) values(@UserID,@SumNumber,@SumPrice,@IsOnSale,@DisCountD,@RealPay,@AddressID,@IsPayment,@State)");
                int i = conn.Execute(sql, order);
                return i;
            }
        }
        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int</returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("delete from TOrder where Id=@Id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }
        /// <summary>
        /// 获取单个订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TOrder</returns>
        public TOrder GetOrder(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TOrder where Id=@Id");
                var i = conn.Query<TOrder>(sql, mySqlParameters).SingleOrDefault();
                return i;
            }
        }
        /// <summary>
        /// 根据用户ID获取所有订单
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>IEnumerable<TOrder></returns>
        public IEnumerable<TOrder> GetOrders(int userID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TOrder where UserID=@userID");
                var i = conn.Query<TOrder>(sql, userID);
                return i;
            }
        }
        /// <summary>
        /// 修改订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns>int</returns>
        public int Update(TOrder order)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TOrder set ManageName=@ManageName,ManagePass=@ManagePass,CreateTime=@CreateTime,LoginTime=@LoginTime,LastLoginTime=@LastLoginTime,Count=@Count where Id=@Id");
                var i = conn.Execute(sql, order);
                return i;
            }
        }
    }
}
