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

    public class ProductType_Services : IProductType_Services
    {
        /// <summary>
        /// 添加类别信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public int Add(TProductType productType)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TProductType(ProductTypeName,PID) value(@ProductTypeName,@PID)");
                int i = conn.Execute(sql, productType);
                return i;
            }
        }

        /// <summary>
        /// 删除产品类型
        /// </summary>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from TProductType where Id=@id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个产品类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TProductType GetProduct(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select * from TProductType where id=@Id");
                var i = conn.Query<TProductType>(sql, new { Id=id}).FirstOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 获取所有产品类型
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public IEnumerable<TProductType> GetProducts(int pid)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select * from TProductType  where PID=@PID");
                var i = conn.Query<TProductType>(sql, new { PID=pid}).ToList();
                return i;
            }
        }

        /// <summary>
        /// 修改产品类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(TProductType productType)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TProductType set ProductTypeName=@ProductTypeName,PID=@PID where Id=@Id");
                var i = conn.Execute(sql, productType);
                return i;
            }
        }
    }
}
