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

    class ProductSizeServices : IProductSizeServices
    {
        /// <summary>
        /// 添加产品尺寸信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public int Add(TProduct_Size product_Size)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TProduct_Size (ProductSize) value(@ProductSize)");
                int i = conn.Execute(sql, product_Size);
                return i;
            }
        }

        /// <summary>
        /// 删除产品尺寸信息
        /// </summary>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete  TProduct_Size(Id) where id=@Id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个材质信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TProduct_Size GetProduct_Size(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TProduct_Size where id=@Id");
                var i = conn.Query<TProduct_Size>(sql, mySqlParameters).FirstOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 获取所有材质信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public IEnumerable<TProduct_Size> GetProduct_Sizes()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                //MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TProduct_Size ");
                var i = conn.Query<TProduct_Size>(sql, null).ToList();
                return i;
            }
        }

        /// <summary>
        /// 修改产品尺寸信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(TProduct_Size product_Size)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TProduct_Size set ProductSize=@ProductSize where Id=@Id");
                var i = conn.Execute(sql, product_Size);
                return i;
            }
        }


    }
}
