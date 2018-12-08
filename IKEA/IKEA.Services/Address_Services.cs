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

    public class Address_Services : IAddress_Services
    {

        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="adderss"></param>
        /// <returns></returns>
        public int Add(TAdderss adderss)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert INTO tadderss(UserID,AddressName,Phone) VALUES(@UserID,@AddressName,@Phone)");
                int i = conn.Execute(sql, adderss);
                return i;
            }
        }
        /// <summary>
        /// 根据ID删除地址信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("DELETE FROM tadderss WHERE Id = @Id");
                int i = conn.Execute(sql, new { Id = id });
                return i;
            }
        }
        /// <summary>
        /// 根据主键ID查询单条地址信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TAdderss GetAddressByID(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * from tadderss WHERE Id = @Id");
                var result = conn.Query<TAdderss>(sql, new { Id = id }).FirstOrDefault();
                return result;
            }
        }

        /// <summary>
        /// 根据用户ID查询用户地址信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public IEnumerable<TAdderss> GetAddressesByUserID(int UserID)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * from tadderss WHERE userID=@UserID");
                var result = conn.Query<TAdderss>(sql, UserID).ToList();
                return result;
            }
        }
        /// <summary>
        /// 修改地址信息
        /// </summary>
        /// <param name="adderss"></param>
        /// <returns></returns>
        public int Update(TAdderss adderss)
        {            
                using (MySqlConnection conn = DapperHelper.GetConnString())
                {
                string sql = string.Format("UPDATE tadderss SET UserID=@UserID , AddressName=@AddressName,  Phone=@Phone where Id =@Id");
                int i = conn.Execute(sql, adderss);
                return i;
            }
            
        }
    }
}
