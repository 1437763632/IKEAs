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
    public class Payment_Services : IPayment_Services
    {
        /// <summary>
        /// 添加支付
        /// </summary>
        /// <param name="payment"></param>
        /// <returns>int</returns>
        public int Add(TPayment payment)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert into TPayment (OrderID,UserID,PayType,PayNumber,PayMoney,State,Paytime) values(@OrderID,@UserID,@PayType,@PayNumber,@PayMoney,@State,@Paytime)");
                int i = conn.Execute(sql, payment);
                return i;
            }
        }
        /// <summary>
        /// 删除支付
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("delete from TPayment where Id=@Id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }
        /// <summary>
        /// 根据ID获取支付信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TPayment GetPayment(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TPayment where Id=@Id");
                var i = conn.Query<TPayment>(sql, mySqlParameters).SingleOrDefault();
                return i;
            }
        }
        /// <summary>
        /// 获取用户所有支付信息
        /// </summary>
        /// <param name="id">用户信息</param>
        /// <returns>IEnumerable<TPayment></returns>
        public IEnumerable<TPayment> GetPayments(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TPayment where Id=@Id");
                var i = conn.Query<TPayment>(sql, id);
                return i;
            }
        }
        /// <summary>
        /// 修改支付信息
        /// </summary>
        /// <param name="payment"></param>
        /// <returns>int</returns>
        public int Update(TPayment payment)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TPayment set OrderID=@OrderID,UserID=@UserID,PayType=@PayType,PayNumber=@PayNumber,PayMoney=@PayMoney,State=@State,Paytime=@Paytime where Id=@Id");
                var i = conn.Execute(sql, payment);
                return i;
            }
        }
    }
}
